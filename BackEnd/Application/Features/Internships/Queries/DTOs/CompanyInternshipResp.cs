﻿using Application.Shared.DTOs.Features.Companies.Responses;
using Application.Shared.DTOs.Features.Internships;
using Application.Shared.DTOs.Features.Persons;
using Domain.Features.Intership.Entities;

namespace Application.Features.Internships.Queries.DTOs
{
    public class CompanyInternshipResp
    {
        //Values
        public PersonPartialResp Person { get; set; } = null!;
        public BranchResp Branch { get; set; } = null!;
        public BranchOfferResp BranchOffer { get; set; } = null!;
        public OfferResp Offer { get; set; } = null!;
        public InternshipResp Internship { get; init; } = null!;
        public InternshipDetailsResp Details { get; init; } = null!;


        //Constructor
        public CompanyInternshipResp(
            DomainIntership domain,
            InternshipDetailsResp details)
        {
            Internship = new InternshipResp(domain);
            Details = details;

            if (domain.Recrutment.BranchOffer != null)
            {
                BranchOffer = new BranchOfferResp(domain.Recrutment.BranchOffer);
            }
            if (domain.Recrutment.BranchOffer?.Offer != null)
            {
                Offer = new OfferResp(domain.Recrutment.BranchOffer.Offer);
            }
            if (domain.Recrutment.BranchOffer?.Branch != null)
            {
                Branch = new BranchResp(domain.Recrutment.BranchOffer.Branch);
            }
            if (domain.Recrutment.Person != null)
            {
                Person = new PersonPartialResp(domain.Recrutment.Person);
            }
        }
    }
}
