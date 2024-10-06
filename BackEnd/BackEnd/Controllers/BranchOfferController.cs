﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Company.OfferBranchPart.DTOs;
using Application.Features.Company.OfferBranchPart.Services;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchOfferController : ControllerBase
    {
        private readonly IBranchOfferService _service;

        public BranchOfferController(IBranchOfferService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBranchOfferAsync(CreateBranchOfferDto dto, CancellationToken cancellation)
        {
            return Ok(await _service.CreateBranchOfferAsync(dto, cancellation));
        }
    }
}
