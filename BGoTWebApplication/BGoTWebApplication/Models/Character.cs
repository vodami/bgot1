using System;
using System.Collections.Generic;

namespace BGoTWebApplication.Models;

public partial class Character
{
    public int CharacterId { get; set; }

    public int HouseId { get; set; }

    public int Strength { get; set; }

    public string? CharacterDescription { get; set; }

    public int Swords { get; set; }

    public int Towers { get; set; }

    public bool Available { get; set; }

    public string CharacterName { get; set; } = null!;

    public virtual ICollection<Battle> BattleAttackerCharacters { get; } = new List<Battle>();

    public virtual ICollection<Battle> BattleDefenderCharacters { get; } = new List<Battle>();

    public virtual House House { get; set; } = null!;
}
