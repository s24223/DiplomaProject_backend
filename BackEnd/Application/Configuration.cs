using Application.Features.Addresses.Commands.Interfaces;
using Application.Features.Addresses.Commands.Services;
using Application.Features.Addresses.Queries.Interfaces;
using Application.Features.Addresses.Queries.Services;
using Application.Features.Characteristics.Mappers;
using Application.Features.Characteristics.Queries.Interfaces;
using Application.Features.Characteristics.Queries.Services;
using Application.Features.Companies.Commands.BranchOffers.Interfaces;
using Application.Features.Companies.Commands.BranchOffers.Services;
using Application.Features.Companies.Commands.CompanyBranches.Interfaces;
using Application.Features.Companies.Commands.CompanyBranches.Services;
using Application.Features.Companies.Mappers;
using Application.Features.Companies.Queries.QueriesOffer.Interfaces;
using Application.Features.Companies.Queries.QueriesOffer.Services;
using Application.Features.Companies.Queries.QueriesUser.Interfaces;
using Application.Features.Companies.Queries.QueriesUser.Services;
using Application.Features.Internship.InternshipPart.Interfaces;
using Application.Features.Internship.InternshipPart.Services;
using Application.Features.Internship.RecrutmentPart.Interfaces;
using Application.Features.Internship.RecrutmentPart.Services;
using Application.Features.Persons.Commands.Interfaces;
using Application.Features.Persons.Commands.Services;
using Application.Features.Persons.Mappers;
using Application.Features.Users.Commands.Notifications.Interfaces;
using Application.Features.Users.Commands.Notifications.Services;
using Application.Features.Users.Commands.Urls.Interfaces;
using Application.Features.Users.Commands.Urls.Services;
using Application.Features.Users.Commands.Users.Interfaces;
using Application.Features.Users.Commands.Users.Services;
using Application.Features.Users.Mappers;
using Application.Features.Users.Queries.QueriesUser.Interfaces;
using Application.Features.Users.Queries.QueriesUser.Services;
using Application.Shared.Interfaces.DomainRepositories;
using Application.Shared.Interfaces.EntityToDomainMappers;
using Application.Shared.Interfaces.Exceptions;
using Application.Shared.Services.Authentication;
using Application.Shared.Services.OrderBy;
using Domain.Features.Characteristic.Repositories;
using Domain.Features.Notification.Repositories;
using Domain.Features.Url.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class Configuration
    {
        public static IServiceCollection ApplicationConfiguration
            (
            this IServiceCollection serviceCollection,
            IConfiguration configuration
            )
        {
            // Rejestracja IConfiguration jako Singleton
            serviceCollection.AddSingleton<IConfiguration>(configuration);
            serviceCollection.AddTransient<IAuthJwtSvc, AuthJwtSvc>();
            serviceCollection.AddTransient<IExceptionsRepository, ExceptionsRepository>();
            serviceCollection.AddTransient<IEntityToDomainMapper, EntityToDomainMapper>();
            serviceCollection.AddTransient<IOrderBySvc, OrderBySvc>();

            //Doamain Connections
            serviceCollection.AddTransient<IDomainNotificationDictionariesRepository, DomainNotificationDictionariesRepository>();
            serviceCollection.AddTransient<IDomainUrlTypeDictionariesRepository, DomainUrlTypeDictionariesRepository>();

            //===============================================================================================================
            //User Module

            //Commands
            //User Part 
            serviceCollection.AddTransient<IUserMapper, UserMapper>();

            serviceCollection.AddTransient<IUserCommandRepository, UserCommandRepository>();
            serviceCollection.AddTransient<IUserCommandService, UserCommandService>();

            //Url Part 
            serviceCollection.AddTransient<IUrlCmdRepo, UrlCmdRepo>();
            serviceCollection.AddTransient<IUrlCmdSvc, UrlCmdSvc>();

            //Notification Part 
            serviceCollection.AddTransient<INotificationCmdSvc, NotificationCmdSvc>();
            serviceCollection.AddTransient<INotificationCmdRepo, NotificationCmdRepo>();

            //Queries
            serviceCollection.AddTransient<IUserQuerySvc, UserQuerySvc>();
            serviceCollection.AddTransient<IUserQueryRepo, UserQueryRepo>();

            //===============================================================================================================
            //Address Module
            //Address Part
            serviceCollection.AddTransient<IAddressCommandRepository, AddressCommandRepository>();
            serviceCollection.AddTransient<IAddressCommandService, AddressCommandService>();

            serviceCollection.AddTransient<IAddressQueryRepo, AddressQueryRepo>();
            serviceCollection.AddTransient<IAddressQueryService, AddressQueryService>();

            //===============================================================================================================
            //Person Module 
            //Person Part 
            serviceCollection.AddTransient<IPersonCmdRepo, PersonCmdRepo>();
            serviceCollection.AddTransient<IPersonCmdSvc, PersonCmdSvc>();
            serviceCollection.AddTransient<IPersonMapper, PersonMapper>();

            //===============================================================================================================
            //Company Module 
            serviceCollection.AddTransient<ICompanyMapper, CompanyMapper>();

            //Company Branch Part 
            serviceCollection.AddTransient<ICompanyBranchCmdRepo, CompanyBranchCmdRepo>();
            serviceCollection.AddTransient<ICompanyBranchCommandService, CompanyBranchCmdSvc>();

            //Offer Branch Part 
            serviceCollection.AddTransient<IBranchOfferRepository, BranchOfferRepository>();
            serviceCollection.AddTransient<IBranchOfferCommandService, BranchOfferCommandService>();

            //Queries
            serviceCollection.AddTransient<IOfferQueryRepository, OfferQueryRepository>();
            serviceCollection.AddTransient<ICompanyQueryService, CompanyQueryService>();

            serviceCollection.AddTransient<IUserCompanyRepo, UserCompanyRepo>();
            serviceCollection.AddTransient<IUserCompanySvc, UserCompanySvc>();
            //===============================================================================================================
            //Intership module 
            //Recruitment part
            serviceCollection.AddTransient<IRecruitmentRepository, RecruitmentRepository>();
            serviceCollection.AddTransient<IRecruitmentService, RecruitmentService>();

            //Internship Part
            serviceCollection.AddTransient<IInternshipRepository, InternshipRepository>();
            serviceCollection.AddTransient<IInternshipService, InternshipService>();

            //===============================================================================================================
            //Characteristic Part
            serviceCollection.AddTransient<ICharacteristicQueryRepository, CharacteristicQueryRepository>();
            serviceCollection.AddTransient<ICharacteristicQueryService, CharacteristicQueryService>();

            serviceCollection.AddTransient<ICharacteristicMapper, CharacteristicMapper>();

            return serviceCollection;
        }
    }
}
