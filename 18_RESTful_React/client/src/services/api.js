import axios from 'axios';

const api = axios.create({
    baseURL: 'https://localhost:7121',
})

export default api;