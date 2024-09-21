﻿using Application.Shared.DTOs.Response;
using Application.VerticalSlice.UserPart.DTOs.CreateProfile;
using Application.VerticalSlice.UserPart.DTOs.LoginIn;
using Application.VerticalSlice.UserPart.DTOs.Refresh;
using Domain.ValueObjects;
using System.Security.Claims;

namespace Application.VerticalSlice.UserPart.Services
{
    public interface IUserService
    {
        Task<Response> CreateProfileAsync
            (
            CreateProfileRequestDto dto,
            CancellationToken cancellation
            );
        Task<ItemResponse<LoginInResponseDto>> LoginInAsync
            (
            LoginInRequestDto dto,
            CancellationToken cancellation
            );
        Task<ItemResponse<RefreshResponseDto>> RefreshTokenAsync
            (
            string jwtFromHeader,
            RefreshRequestDto dto,
            CancellationToken cancellation
            );
        Task<Response> LogOutAsync
            (
            IEnumerable<Claim> claims,
            CancellationToken cancellation
            );
        Task<Response> CreateUserProblemAuthorizedAsync(
           IEnumerable<Claim> claims,
           string userMessage,
           CancellationToken cancellationToken
           );
        Task<Response> CreateUserProblemUnauthorizedAsync(
            string userMessage,
            Email email,
            CancellationToken cancelToken
            );
    }
}
