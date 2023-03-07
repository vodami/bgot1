using System;
using System.Collections.Generic;

namespace BGoTWebApplication.Models;

public partial class Territory
{
    public int TerritoryId { get; set; }

    public string TerritoryName { get; set; } = null!;

    public int? HouseId { get; set; }

    public int? Crowns { get; set; }

    public int? Barrels { get; set; }

    public bool? Castle { get; set; }

    public bool Land { get; set; }

    public bool Port { get; set; }

    public virtual ICollection<Battle> Battles { get; } = new List<Battle>();

    public virtual House? House { get; set; }
}
