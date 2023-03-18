import React, {useState, useEffect} from 'react';
import './styles.css';
import Logo from '../../assets/logo.png'
import { Link, useNavigate } from 'react-router-dom';
import {FiPower, FiEdit, FiTrash2} from 'react-icons/fi';
import api from '../../services/api';

export default function Books(){

    const history=useNavigate();
    const accessToken = localStorage.getItem('accessToken');
    const authorization = { 
        headers:{
            Authorization: `Bearer ${accessToken}`
        }}
    const [books, setBooks]=useState([]);
    const [page, setPage]=useState(0);
    const userName = localStorage.getItem('userName');

    useEffect(()=>{
        fetchMoreBooks();
    }, [accessToken])

    async function fetchMoreBooks(){
        const response = await api.get(`api/Book/v1.0/asc/4/${page}`, authorization);
            setBooks([...books,...response.data.list]);
            setPage(page+1);
    }

    async function deleteBook(id){
        try {
            await api.delete(`api/Book/v1.0/${id}`,authorization)
            setBooks(books.filter(book=>book.id!==id))
        } catch (error) {
            alert('Delete failed!');
        }
    }

    async function editBook(id){
        try {
            history(`/books/new/${id}`)
        } catch (error) {
            alert('Edit book failed!');
        }
    }

    async function logout(){
        try {
            const response = await api.get('api/auth/v1.0/revoke',authorization);
            if(response.status === 204){
                alert('Ok!');
                localStorage.clear();
                history('/');
            } 
        } catch (error) {
            alert('Error!');
        }
    }

    return(
        <div className="book-container">
            <header>
                <img src={Logo} alt="Logo"/>
                <span>Welcome,
                    <strong> {userName.charAt(0).toUpperCase() + 
                    userName.slice(1).toLowerCase()}</strong>!</span>

                <Link className="button" to="/books/new/0">Add new Book</Link>
                <button onClick={logout} type="button" >
                    <FiPower size={25}/> 
                </button>
            </header>

            <h1>Registered Books</h1>
            <ul>
                {books.map(book=>(
                    <li key={book.id}>
                        <strong>Title:</strong>
                        <p>{book.title}</p> 
                        <strong>Author:</strong>
                        <p>{book.author}</p>
                        <strong>Price:</strong>
                        <p>{Intl.NumberFormat('pt-br',{style: 'currency', currency: 'BRL'}).format(book.price)}</p>
                        <strong>Release Date:</strong>
                        <p>{Intl.DateTimeFormat('pt-br').format(new Date(book.launchDate))}</p>

                        <button onClick={()=>editBook(book.id)} type="button">
                            <FiEdit size={20}/>
                        </button>
                        <button onClick={()=>deleteBook(book.id)} type="button">
                            <FiTrash2 size={20}/>
                        </button>
                </li>
                ))}
            </ul>
            <button className="button" onClick={fetchMoreBooks} type="button">Load more</button>
        </div>
    );
}