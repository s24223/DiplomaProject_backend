﻿using Application.Shared.DTOs.Features.Internships;
using Domain.Features.Recruitment.ValueObjects.Identificators;
using Domain.Features.User.ValueObjects.Identificators;

namespace Application.Shared.Interfaces.SqlClient
{
    public interface ISqlClientRepo
    {
        Task<InternshipDetailsResp> GetInternshipDetailsAsync
            (
            RecrutmentId recrutmentId,
            UserId userId,
            CancellationToken cancellation
            );

        Task<(int DivisionId, int? StreetId)> GetDivisionIdStreetIdAsync
            (
            string wojewodztwo,
            string? powiat,
            string? gmina,
            string city,
            string? dzielnica,
            string? street,
            CancellationToken cancellation
            );

        Task<(int? WojId, IEnumerable<int> DivisionIds)> GetChildDivisionIdsAsync(
            string wojewodztwo,
            string? divisionName,
            CancellationToken cancellation);

        //Past Procedures
        /*Task<IEnumerable<(int DivisionId, Street Street)>> GetCollocationsAsync
            (
            string divisionName,
            string streetName,
            CancellationToken cancellation
            );

        Task<Dictionary<DivisionId, AdministrativeDivision>> GetDivisionsHierachyUpAsync
            (
            int divisionId,
            CancellationToken cancellation
            );

        Task<(int TotalCount, IEnumerable<Guid> Ids)> GetBranchIdsSorted
            (
            Guid companyId,
            int? divisionId,
            int? streetId,
            int maxItems,
            int page,
            bool ascending,
            CancellationToken cancellation
            );

        Task<IEnumerable<int>> GetDivisionIdsDownAsync
            (
            int divisionId,
            CancellationToken cancellation
            );*/
    }
}
