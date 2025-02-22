import React from 'react';
import { fetchLogout } from '../../../services/LogOutService/LogOutService';

const LoginButton = () => {
    const handleLogin = () => {
        window.location.href = "/login"; // lub jakikolwiek inny routing do logowania
    };

    const handleRegistration = () => {
        window.location.href = '/register';
    };

    const handleLogOut = () => {
        const fetchDummy = async () => {
            await fetchLogout()
            window.location.reload()
            window.location.href = '/'
        }
        fetchDummy()
    };

    const handleProfile = () => {
        window.location.href = "/userProfile";
    };
    return (
        <div className='login-div'>
            {localStorage.getItem("jwt") === null ?
                <div className='two-button'>
                    <button className='button-one' onClick={handleLogin} >
                        LogIn
                    </button>
                    <button className='button-two' onClick={handleRegistration} >
                        Sign up
                    </button>
                </div> :
                <div className='two-button'>
                    <button className='button-one' onClick={handleProfile} >
                        Profile
                    </button>
                    <button className='button-two' onClick={handleLogOut} >
                        LogOut
                    </button>
                </div>}
        </div>
    );
};

export default LoginButton;
