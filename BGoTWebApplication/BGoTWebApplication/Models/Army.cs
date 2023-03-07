using System;
using System.Collections.Generic;

namespace BGoTWebApplication.Models;

public partial class Army
{
    public int HouseId { get; set; }

    public int Footmen { get; set; }

    public int Knights { get; set; }

    public int SiegeEngines { get; set; }

    public int Ships { get; set; }

    public virtual House House { get; set; } = null!;
}
