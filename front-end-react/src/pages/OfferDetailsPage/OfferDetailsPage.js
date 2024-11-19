import React from "react";
import MainPageButton from "../../components/MainPageButton/MainPageButton";
import OfferDetails from "../../components/OfferDetails/OfferDetails";
import ProfileButton from "../../components/ProfileButton/ProfileButton";


const ProfileCreatePage = () =>{
    return(
        <div>
            <MainPageButton/><br/>
            <ProfileButton/>
            <OfferDetails/>
        </div>
    )
}

export default ProfileCreatePage;