﻿using Domain.Features.Address.Entities;
using Domain.Features.Branch.Entities;
using Domain.Features.BranchOffer.Entities;
using Domain.Features.Comment.Entities;
using Domain.Features.Company.Entities;
using Domain.Features.Intership.Entities;
using Domain.Features.Offer.Entities;
using Domain.Features.Person.Entities;
using Domain.Features.Recruitment.Entities;
using Domain.Features.Url.Entities;
using Domain.Features.User.Entities;
using Domain.Features.UserProblem.Entities;
using Domain.Shared.Providers;

namespace Domain.Shared.Factories
{
    public class DomainFactory : IDomainFactory
    {
        //Values
        private readonly IProvider _provider;


        //Constructor
        public DomainFactory(IProvider provider)
        {
            _provider = provider;
        }


        //Methods
        //=================================================================================================
        //=================================================================================================
        //=================================================================================================
        //User Part
        public DomainUser CreateDomainUser(string login)
        {
            return new DomainUser(null, login, null, null, _provider);
        }

        public DomainUser CreateDomainUser
            (
            Guid id,
            string login,
            DateTime? lastLoginIn,
            DateTime lastPasswordUpdate
            )
        {
            return new DomainUser(id, login, lastLoginIn, lastPasswordUpdate, _provider);
        }


        public DomainUserProblem CreateDomainUserProblem
            (
            string userMessage,
            Guid? previousProblemId,
            string? email,
            Guid? userId
            )
        {
            return new DomainUserProblem
                (
                null,
                null,
                userMessage,
                null,
                previousProblemId,
                email,
                null,
                userId,
            _provider
            );
        }

        public DomainUserProblem CreateDomainUserProblem
            (
            Guid id,
            DateTime created,
            string userMessage,
            string? response,
            Guid? previousProblemId,
            string? email,
            string status,
            Guid? userId
            )
        {
            return new DomainUserProblem
                (
                id,
                created,
                userMessage,
                response,
                previousProblemId,
                email,
                status,
                userId,
            _provider
            );
        }


        public DomainUrl CreateDomainUrl
            (
            Guid userId,
            int urlTypeId,
            DateTime created,
            string path,
            string? name,
            string? description
            )
        {
            return new DomainUrl
                (
                 userId,
                 urlTypeId,
                 created,
                 path,
                 name,
                 description,
                _provider
            );
        }

        //=================================================================================================
        //=================================================================================================
        //=================================================================================================
        //Person Part
        public DomainPerson CreateDomainPerson
            (
            Guid id,
            string? urlSegment,
            DateOnly? createDate,
            string contactEmail,
            string name,
            string surname,
            DateOnly? birthDate,
            string? contactPhoneNum,
            string? description,
            string isStudent,
            string isPublicProfile,
            Guid? addressId
            )
        {
            return new DomainPerson(
                id,
                urlSegment,
                createDate,
                contactEmail,
                name,
                surname,
                birthDate,
                contactPhoneNum,
                description,
                isStudent,
                isPublicProfile,
                addressId,
                _provider
                );
        }

        //=================================================================================================
        //=================================================================================================
        //=================================================================================================
        //Company Part
        public DomainBranch CreateDomainBranch
            (
            Guid? id,
            Guid companyId,
            Guid addressId,
            string? urlSegment,
            string name,
            string? description
            )
        {
            return new DomainBranch
                (
                id,
                companyId,
                addressId,
                urlSegment,
                name,
                description,
                _provider
                );
        }

        public DomainBranch CreateDomainBranch(Guid id, string? urlSegment, string name, string? description)
        {
            throw new NotImplementedException();
        }
        public DomainBranchOffer CreateDomainBranchOffer
           (
           Guid branchId,
           Guid offerId,
           DateTime created,
           DateTime publishStart,
           DateTime? publishEnd,
           DateOnly? workStart,
           DateOnly? workEnd,
           DateTime lastUpdate
           )
        {
            return new DomainBranchOffer
                (
                branchId,
                offerId,
                created,
                publishStart,
                publishEnd,
                workStart,
                workEnd,
                lastUpdate,
                _provider
           );
        }

        public DomainCompany CreateDomainCompany
            (
            Guid id,
            string? urlSegment,
            string contactEmail,
            string name,
            string regon,
            string? description,
            DateOnly? createDate
            )
        {
            return new DomainCompany
                (
                id,
                urlSegment,
                contactEmail,
                name,
                regon,
                description,
                createDate,
        _provider
                );
        }

        public DomainOffer CreateDomainOffer
           (
           Guid? id,
           string name,
           string description,
           decimal? minSalary,
           decimal? maxSalary,
           string? NegotiatedSalary,
           string forStudents
           )
        {
            return new DomainOffer
                (
                id,
                name,
                description,
                minSalary,
                maxSalary,
                NegotiatedSalary,
                forStudents,
            _provider
           );
        }

        //=================================================================================================
        //=================================================================================================
        //=================================================================================================
        //Recruitment Part
        public DomainComment CreateDomainComment
            (
            Guid internshipId,
            int commentTypeId,
            DateTime published,
            string description,
            int? evaluation
            )
        {
            return new DomainComment
                (
                 internshipId,
                 commentTypeId,
                 published,
                 description,
                 evaluation,
                 _provider
            );
        }

        public DomainIntership CreateDomainIntership
            (
            Guid? id,
            Guid personId,
            Guid branchId,
            Guid offerId,
            DateTime created,
            string contractNumber
            )
        {
            return new DomainIntership
                (
            id,
             personId,
             branchId,
             offerId,
             created,
             contractNumber,
             _provider
            );
        }

        public DomainIntership CreateDomainInternship(string contactNumber, Guid personId, Guid branchId, Guid offerId, DateTime created)
        {
            return new DomainIntership(
                null,
                personId,
                branchId,
                offerId,
                created,
                contactNumber,
                _provider
                );
        }

        public DomainRecruitment CreateDomainRecruitment
            (
            Guid personId,
            Guid branchId,
            Guid offerId,
            DateTime created,
            DateTime? applicationDate,
            string? personMessage,
            string? companyResponse,
            string? acceptedRejected
            )
        {
            return new DomainRecruitment
                (
                 personId,
                 branchId,
                 offerId,
                 created,
                 applicationDate,
                 personMessage,
                 companyResponse,
                 acceptedRejected,
                 _provider
            );
        }

        //=================================================================================================
        //=================================================================================================
        //=================================================================================================
        //Address Part
        public DomainAddress CreateDomainAddress
            (
            Guid? id,
            int divisionId,
            int streetId,
            string buildingNumber,
            string? apartmentNumber,
            string zipCode
            )
        {
            return new DomainAddress
                (
                id,
                divisionId,
                streetId,
                buildingNumber,
                apartmentNumber,
                zipCode,
            _provider
            );
        }
        /// <summary>
        /// For creating new DomainAddress
        /// </summary>
        /// <param name="divisionId"></param>
        /// <param name="streetId"></param>
        /// <param name="buildingNumber"></param>
        /// <param name="apartmentNumber"></param>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        public DomainAddress CreateDomainAddress
            (
            int divisionId,
            int streetId,
            string buildingNumber,
            string? apartmentNumber,
            string zipCode
            )
        {
            return new DomainAddress
                (
                null,
                divisionId,
                streetId,
                buildingNumber,
                apartmentNumber,
                zipCode,
            _provider
            );
        }


        //=================================================================================================
        //=================================================================================================
        //=================================================================================================
    }
}
