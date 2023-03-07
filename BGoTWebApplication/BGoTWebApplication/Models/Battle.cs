using System;
using System.Collections.Generic;

namespace BGoTWebApplication.Models;

public partial class Battle
{
    public int BattleId { get; set; }

    public int AttackerId { get; set; }

    public int DefenderId { get; set; }

    public int WinnerId { get; set; }

    public int? AttackerSupporter1Id { get; set; }

    public int? AttackerSupporter2Id { get; set; }

    public int? AttackerSupporter3Id { get; set; }

    public int? AttackerSupporter4Id { get; set; }

    public int? DefenderSupporter1Id { get; set; }

    public int? DefenderSupporter2Id { get; set; }

    public int? DefenderSupporter3Id { get; set; }

    public int? DefenderSupporter4Id { get; set; }

    public int? AttackerCharacterId { get; set; }

    public int? DefenderCharacterId { get; set; }

    public int AttackFootmen { get; set; }

    public int AttackKnights { get; set; }

    public int AttackSiegeEngines { get; set; }

    public int AttackShips { get; set; }

    public int DefenceFootmen { get; set; }

    public int DefenceKnights { get; set; }

    public int DefenceShips { get; set; }

    public int TerritorryId { get; set; }

    public virtual House Attacker { get; set; } = null!;

    public virtual Character? AttackerCharacter { get; set; }

    public virtual House? AttackerSupporter1 { get; set; }

    public virtual House? AttackerSupporter2 { get; set; }

    public virtual House? AttackerSupporter3 { get; set; }

    public virtual House? AttackerSupporter4 { get; set; }

    public virtual House Defender { get; set; } = null!;

    public virtual Character? DefenderCharacter { get; set; }

    public virtual House? DefenderSupporter1 { get; set; }

    public virtual House? DefenderSupporter2 { get; set; }

    public virtual House? DefenderSupporter3 { get; set; }

    public virtual House? DefenderSupporter4 { get; set; }

    public virtual Territory Territorry { get; set; } = null!;

    public virtual House Winner { get; set; } = null!;
}
