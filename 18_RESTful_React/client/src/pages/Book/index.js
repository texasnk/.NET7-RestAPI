import React from 'react';
import './styles.css';
import Logo from '../../assets/logo.png'
import { Link } from 'react-router-dom';
import {FiPower, FiEdit, FiTrash2} from 'react-icons/fi';

export default function Book(){
    return(
        <div className="book-container">
            <header>
                <img src={Logo} alt="Logo"/>
                <span>Welcome, <strong>user</strong>!</span>
                <Link className="button" to="book/new">Add new Book</Link>
                <button type="button">
                    <FiPower size={25}/> 
                </button>
            </header>

            <h1>Registered Books</h1>
            <ul>
                <li>
                    <strong>Title:</strong>
                    <p>Docker Deep Diver</p> 
                    <strong>Author:</strong>
                    <p>Nigel Poulton</p>
                    <strong>Price:</strong>
                    <p>R$ 50,99</p>
                    <strong>Release Date:</strong>
                    <p>12/07/2018</p>

                    <button type="button">
                        <FiEdit size={20}/>
                    </button>
                    <button type="button">
                        <FiTrash2 size={20}/>
                    </button>
                </li>
                <li>
                    <strong>Title:</strong>
                    <p>Docker Deep Diver</p> 
                    <strong>Author:</strong>
                    <p>Nigel Poulton</p>
                    <strong>Price:</strong>
                    <p>R$ 50,99</p>
                    <strong>Release Date:</strong>
                    <p>12/07/2018</p>

                    <button type="button">
                        <FiEdit size={20}/>
                    </button>
                    <button type="button">
                        <FiTrash2 size={20}/>
                    </button>
                </li>
                <li>
                    <strong>Title:</strong>
                    <p>Docker Deep Diver</p> 
                    <strong>Author:</strong>
                    <p>Nigel Poulton</p>
                    <strong>Price:</strong>
                    <p>R$ 50,99</p>
                    <strong>Release Date:</strong>
                    <p>12/07/2018</p>

                    <button type="button">
                        <FiEdit size={20}/>
                    </button>
                    <button type="button">
                        <FiTrash2 size={20}/>
                    </button>
                </li>
                <li>
                    <strong>Title:</strong>
                    <p>Docker Deep Diver</p> 
                    <strong>Author:</strong>
                    <p>Nigel Poulton</p>
                    <strong>Price:</strong>
                    <p>R$ 50,99</p>
                    <strong>Release Date:</strong>
                    <p>12/07/2018</p>

                    <button type="button">
                        <FiEdit size={20}/>
                    </button>
                    <button type="button">
                        <FiTrash2 size={20}/>
                    </button>
                </li>
            </ul>
        </div>
    );
}