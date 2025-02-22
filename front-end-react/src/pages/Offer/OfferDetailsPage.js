import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import OfferDetails from "../../components/Offers/OfferDetails";
import { fetchOfferDetailsPublic } from "../../services/OffersService/OffersService";
import { jwtRefresh } from "../../services/JwtRefreshService/JwtRefreshService";
import ApplyButton from "../../components/Buttons/ApplyButton/ApplyButton";

const OfferDetailsPage = () => {
    jwtRefresh();
    
    const { offerId } = useParams();
    const [offerDetails, setOfferDetails] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        const loadOfferDetails = async () => {
            try {
                const data = await fetchOfferDetailsPublic(offerId);
                if(data.error){
                    throw new Error(data.error)
                }
                setOfferDetails(data);
            } catch (err) {
                setError("Failed to load offer details.");
            } finally {
                setLoading(false);
            }
        };
        loadOfferDetails();
    }, [offerId]);

    if (loading) return <p>Loading offer details...</p>;
    if (error) return <p>{error}</p>;

    return (
        <div>
            <OfferDetails offerDetails={offerDetails} />
            <div className="apply-container">
                <ApplyButton branchId={offerDetails.branchOffers[0]?.branchOffer?.id} />
            </div>

        </div>
    );
};

export default OfferDetailsPage;
