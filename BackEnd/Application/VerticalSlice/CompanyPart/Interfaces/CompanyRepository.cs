﻿using Application.Database;
using Domain.Entities.CompanyPart;
using Domain.Exceptions.UserExceptions.EntitiesExceptions;
using Domain.Exceptions.UserExceptions.ValueObjectsExceptions;
using Microsoft.EntityFrameworkCore;

namespace Application.VerticalSlice.CompanyPart.Interfaces
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DiplomaProjectContext _context;

        public CompanyRepository(DiplomaProjectContext context)
        {
            _context = context;
        }

        public async Task CreateCompanyProfileAsync(DomainCompany company, CancellationToken cancellation)
        {
            var databaseCompany = await _context.Companies
                .Where(x => x.UserId == company.Id.Value)
                .AsNoTracking()
                .FirstOrDefaultAsync(cancellation);
            if (databaseCompany != null)
            {
                throw new CompanyException(Messages.IsExistCompany);
            }

            if (company.UrlSegment != null)
            {
                var databaseCompanyWithSameUrlSegment = await _context.Companies
                    .Where(x => x.UrlSegment == company.UrlSegment.Value)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellation);
                if (databaseCompanyWithSameUrlSegment != null)
                {
                    throw new UrlSegmentException(Messages.NotUniqueUrlSegment);
                }
            }

            var databaseCompanyWithSameContactEmail = await _context.Companies
                    .Where(x => x.ContactEmail == company.ContactEmail.Value)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellation);
            if (databaseCompanyWithSameContactEmail != null)
            {
                throw new EmailException(Messages.NotUniqueEmail);
            }

            //Uerl segment, Emaiil Unique 
            var inputDatabaseCompany = new Database.Models.Company
            {
                UserId = company.Id.Value,
                UrlSegment = (company.UrlSegment == null) ? null : company.UrlSegment.Value,
                CreateDate = company.CreateDate,
                ContactEmail = company.ContactEmail.Value,
                Name = company.Name,
                Regon = company.Regon.Value,
            };
            await _context.Companies.AddAsync(inputDatabaseCompany, cancellation);
            await _context.SaveChangesAsync(cancellation);
        }
    }
}
