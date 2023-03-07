using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BGoTWebApplication.Models;

public partial class BgoTContext : DbContext
{
    public BgoTContext()
    {
    }

    public BgoTContext(DbContextOptions<BgoTContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Army> Armies { get; set; }

    public virtual DbSet<Battle> Battles { get; set; }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<House> Houses { get; set; }

    public virtual DbSet<Territory> Territories { get; set; }

    public virtual DbSet<TrackPosition> TrackPositions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-352JT5N\\SQLEXPRESS; Database=BGoT; Trusted_Connection=True; Trust Server Certificate=True; ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Army>(entity =>
        {
            entity.HasKey(e => e.HouseId);

            entity.ToTable("Army");

            entity.Property(e => e.HouseId).ValueGeneratedNever();

            entity.HasOne(d => d.House).WithOne(p => p.Army)
                .HasForeignKey<Army>(d => d.HouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Army_House");
        });

        modelBuilder.Entity<Battle>(entity =>
        {
            entity.Property(e => e.BattleId).ValueGeneratedNever();

            entity.HasOne(d => d.AttackerCharacter).WithMany(p => p.BattleAttackerCharacters)
                .HasForeignKey(d => d.AttackerCharacterId)
                .HasConstraintName("FK_AttackerCharacter");

            entity.HasOne(d => d.Attacker).WithMany(p => p.BattleAttackers)
                .HasForeignKey(d => d.AttackerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attacker");

            entity.HasOne(d => d.AttackerSupporter1).WithMany(p => p.BattleAttackerSupporter1s)
                .HasForeignKey(d => d.AttackerSupporter1Id)
                .HasConstraintName("FK_AttackerSupporter1");

            entity.HasOne(d => d.AttackerSupporter2).WithMany(p => p.BattleAttackerSupporter2s)
                .HasForeignKey(d => d.AttackerSupporter2Id)
                .HasConstraintName("FK_AttackerSupporter2");

            entity.HasOne(d => d.AttackerSupporter3).WithMany(p => p.BattleAttackerSupporter3s)
                .HasForeignKey(d => d.AttackerSupporter3Id)
                .HasConstraintName("FK_AttackerSupporter3");

            entity.HasOne(d => d.AttackerSupporter4).WithMany(p => p.BattleAttackerSupporter4s)
                .HasForeignKey(d => d.AttackerSupporter4Id)
                .HasConstraintName("FK_AttackerSupporter4");

            entity.HasOne(d => d.DefenderCharacter).WithMany(p => p.BattleDefenderCharacters)
                .HasForeignKey(d => d.DefenderCharacterId)
                .HasConstraintName("FK_DefenderCharacter");

            entity.HasOne(d => d.Defender).WithMany(p => p.BattleDefenders)
                .HasForeignKey(d => d.DefenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Defender");

            entity.HasOne(d => d.DefenderSupporter1).WithMany(p => p.BattleDefenderSupporter1s)
                .HasForeignKey(d => d.DefenderSupporter1Id)
                .HasConstraintName("FK_DefenderSupporter1");

            entity.HasOne(d => d.DefenderSupporter2).WithMany(p => p.BattleDefenderSupporter2s)
                .HasForeignKey(d => d.DefenderSupporter2Id)
                .HasConstraintName("FK_DefenderSupporter2");

            entity.HasOne(d => d.DefenderSupporter3).WithMany(p => p.BattleDefenderSupporter3s)
                .HasForeignKey(d => d.DefenderSupporter3Id)
                .HasConstraintName("FK_DefenderSupporter3");

            entity.HasOne(d => d.DefenderSupporter4).WithMany(p => p.BattleDefenderSupporter4s)
                .HasForeignKey(d => d.DefenderSupporter4Id)
                .HasConstraintName("FK_DefenderSupporter4");

            entity.HasOne(d => d.Territorry).WithMany(p => p.Battles)
                .HasForeignKey(d => d.TerritorryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Battles_Territory");

            entity.HasOne(d => d.Winner).WithMany(p => p.BattleWinners)
                .HasForeignKey(d => d.WinnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Winner");
        });

        modelBuilder.Entity<Character>(entity =>
        {
            entity.ToTable("Character");

            entity.Property(e => e.CharacterId).ValueGeneratedNever();
            entity.Property(e => e.CharacterDescription).HasColumnType("text");
            entity.Property(e => e.CharacterName).HasColumnType("text");

            entity.HasOne(d => d.House).WithMany(p => p.Characters)
                .HasForeignKey(d => d.HouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Character_Character");
        });

        modelBuilder.Entity<House>(entity =>
        {
            entity.ToTable("House");

            entity.Property(e => e.HouseId).ValueGeneratedNever();
            entity.Property(e => e.HouseDescription).HasColumnType("text");
            entity.Property(e => e.HouseMotto).HasColumnType("text");
            entity.Property(e => e.HouseName).HasColumnType("text");
        });

        modelBuilder.Entity<Territory>(entity =>
        {
            entity.ToTable("Territory");

            entity.Property(e => e.TerritoryId).ValueGeneratedNever();
            entity.Property(e => e.TerritoryName).HasColumnType("text");

            entity.HasOne(d => d.House).WithMany(p => p.Territories)
                .HasForeignKey(d => d.HouseId)
                .HasConstraintName("FK_Territory_Territory");
        });

        modelBuilder.Entity<TrackPosition>(entity =>
        {
            entity.HasKey(e => e.HouseId);

            entity.Property(e => e.HouseId).ValueGeneratedNever();

            entity.HasOne(d => d.House).WithOne(p => p.TrackPosition)
                .HasForeignKey<TrackPosition>(d => d.HouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrackPositions_House");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
