﻿using Domain.Entities.CompanyPart;
using Domain.Entities.PersonPart;
using Domain.Entities.RecrutmentPart;
using Domain.Entities.UserPart;
using Domain.Exceptions.UserExceptions;
using Domain.Providers;
using Domain.ValueObjects.PartUrlType;

namespace Domain.Factories
{
    public interface IDomainFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="loginEmail"></param>
        /// <param name="lastLoginIn"></param>
        /// <param name="lastUpdatePassword"></param>
        /// <returns></returns>
        /// <exception cref="EmailException"></exception>
        DomainUser CreateDomainUser
           (
           Guid? id,
           string loginEmail,
           DateTime? lastLoginIn,
           DateTime? lastUpdatePassword
           );
        DomainCompany CreateDomainCompany
            (
            Guid id,
            string? urlSegment,
            string contactEmail,
            string name,
            string regon,
            string? description,
            DateOnly? createDate
            );
        DomainPerson CreateDomainPerson
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
            );

        DomainUserProblem CreateDomainUserProblem
           (
           Guid? id,
           DateTime? dateTime,
           string userMessage,
           string? response,
           Guid? previousProblemId,
           string? email,
           string? status,
           Guid? userId
           );
        DomainOffer CreateDomainOffer
           (
           Guid? id,
           string name,
           string description,
           decimal? minSalary,
           decimal? maxSalary,
           string? isNegotiatedSalary,
           string forStudents
           );
        
     
        DomainUrl CreateDomainUrl
            (
            Guid UserId,
            UrlType urlType,
            DateTime publishDate,
            string url,
            string? name,
            string? description,
            IDomainProvider provider
            );

        DomainBranchOffer CreateDomainBranchOffer
            (
            Guid branchId,
            Guid offerId,
            DateTime created,
            DateTime publishStart,
            DateTime? publishEnd,
            DateOnly? workStart,
            DateOnly? workEnd,
            DateTime lastUpdate,
            IDomainProvider provider
            );
        DomainRecruitment CreateDomainRecrutment
            (
            Guid personId,
            Guid branchId,
            Guid offerId,
            DateTime created,
            DateTime? applicationDate,
            string? personMessage,
            string? companyResponse,
            string? acceptedRejected
            );
        
     }
}
