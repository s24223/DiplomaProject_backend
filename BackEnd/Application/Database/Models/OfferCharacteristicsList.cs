﻿namespace Application.Database.Models;

public partial class OfferCharacteristicsList
{
    public Guid OfferId { get; set; }

    public int QualityId { get; set; }

    public int CharacteristicId { get; set; }

    public virtual Characteristic Characteristic { get; set; } = null!;

    public virtual Offer Offer { get; set; } = null!;

    public virtual Quality Quality { get; set; } = null!;
}
