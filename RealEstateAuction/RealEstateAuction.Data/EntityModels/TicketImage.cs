using System;
using System.Collections.Generic;

namespace RealEstateAuction.Data.EntityModels;

public partial class TicketImage
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public string Url { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
