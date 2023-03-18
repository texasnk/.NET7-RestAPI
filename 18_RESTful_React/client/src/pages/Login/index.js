import React, {useState} from 'react';
import {useNavigate} from 'react-router-dom';
import './styles.css'
import Padlock from '../../assets/padlock.png'
import api from '../../services/api';

export default function Login(){
    const [userName, setUserName]=useState('');
    const [password, setPassword]=useState('');

    const history = useNavigate();

    async function login(e){
        e.preventDefault();

        const data ={
            userName,
            password,
        };
        try {
            const response = await api.post('api/auth/v1.0/signin', data);
            localStorage.setItem('userName', userName);
            localStorage.setItem('accessToken', response.data.accessToken);
            localStorage.setItem('refreshToken', response.data.refreshToken);
            
            history('/books');

        } catch (error) {
            alert('Login failed. Try again!');
        }
    }

    return (
        <div className="login-container">
            <section className="form">
            <img src={Padlock} alt="Padlock :D"/>
                <form onSubmit={login}>
                    <h1>Login</h1>
                    <input 
                        placeholder="Username"
                        value={userName}
                        onChange={e=>setUserName(e.target.value)}
                    />
                    <input 
                        type="password" 
                        placeholder="Password"
                        value={password}
                        onChange={e=>setPassword(e.target.value)}
                    />
                    <button className="button" type="submit">Login</button>
                </form>
            </section>
        </div>

    )
}