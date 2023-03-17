import React from 'react';
import './styles.css'
import Padlock from '../../assets/padlock.png'

export default function Login(){
    return (
        <div className="login-container">
            <section className="form">
            <img src={Padlock} alt="Padlock :D"/>
                <form>
                    <h1>Login</h1>
                    <input placeholder="Username"/>
                    <input type="password" placeholder="Password"/>
                    <button className="button" type="submit">Login</button>
                </form>
            </section>
        </div>

    )
}