import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { fetchBranchGet } from '../../services/BranchService/BranchService';

const BranchList = () =>{
    const [branchList, setBrarnchList] = useState([]);

    useEffect(() => {
        const fetchDummy = async () => {
            let response = await fetchBranchGet()
            if(response.error){
                throw new Error(response.error)
            }
            setBrarnchList(response.item.branches)
        }

        fetchDummy();
    }, [])

    return(
        <div className='profile-details'>
            {branchList && <h2>Branch list:</h2>}
            <nav>
                <ul>
                    {
                        branchList &&
                        branchList.map((item) => (
                            <li className="url" key={item.id}><Link id='branchLink' 
                            to={{ pathname: `/branch/${item.id}`}}
                            state={{ item }}>{item.name}</Link></li>
                        ))
                    }
                </ul>
            </nav>
        </div>
    )
}

export default BranchList;