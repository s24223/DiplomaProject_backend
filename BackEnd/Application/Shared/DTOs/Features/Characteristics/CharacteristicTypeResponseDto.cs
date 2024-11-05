﻿using Domain.Features.Characteristic.ValueObjects;

namespace Application.Shared.DTOs.Features.Characteristics
{
    public class CharacteristicTypeResponseDto
    {
        //Values
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;


        //Constructor
        public CharacteristicTypeResponseDto(DomainCharacteristicType domain)
        {
            Id = domain.Id;
            Name = domain.Name;
            Description = domain.Description;
        }
    }
}
