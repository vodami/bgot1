using System;
using System.Collections.Generic;

namespace BGoTWebApplication.Models;

public partial class TrackPosition
{
    public int HouseId { get; set; }

    public int IronThrone { get; set; }

    public int Fiefdom { get; set; }

    public int Raven { get; set; }

    public virtual House House { get; set; } = null!;
}
