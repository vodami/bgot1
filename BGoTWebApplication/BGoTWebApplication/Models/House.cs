using System;
using System.Collections.Generic;

namespace BGoTWebApplication.Models;

public partial class House
{
    public int HouseId { get; set; }

    public string HouseName { get; set; } = null!;

    public string HouseMotto { get; set; } = null!;

    public string HouseDescription { get; set; } = null!;

    public virtual Army? Army { get; set; }

    public virtual ICollection<Battle> BattleAttackerSupporter1s { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleAttackerSupporter2s { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleAttackerSupporter3s { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleAttackerSupporter4s { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleAttackers { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleDefenderSupporter1s { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleDefenderSupporter2s { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleDefenderSupporter3s { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleDefenderSupporter4s { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleDefenders { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleWinners { get; } = new List<Battle>();

    public virtual ICollection<Character> Characters { get; } = new List<Character>();

    public virtual ICollection<Territory> Territories { get; } = new List<Territory>();

    public virtual TrackPosition? TrackPosition { get; set; }
}
