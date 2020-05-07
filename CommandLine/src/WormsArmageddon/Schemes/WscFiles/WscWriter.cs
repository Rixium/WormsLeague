﻿using System.IO;

namespace Worms.WormsArmageddon.Schemes.WscFiles
{
    public class WscWriter
    {
        public void WriteModel(Scheme model, string filePath)
        {
            using var b = new BinaryWriter(File.Open(filePath, FileMode.Create));

            b.Write(model.Signature.ToCharArray(0, 4));
            b.Write((byte) model.Version);
            b.Write((byte) model.HotSeatDelay);
            b.Write((byte) model.RetreatTime);
            b.Write((byte) model.RopeRetreatTime);
            b.Write(model.DisplayTotalRoundTime);
            b.Write(model.AutomaticReplays);
            b.Write((byte) model.FallDamage);
            b.Write(model.ArtilleryMode);
            b.Write((byte) 0);
            b.Write(model.StockpilingMode);
            b.Write(model.WormSelect);
            b.Write(model.SuddenDeathEvent);
            b.Write((byte) model.WaterRiseRate);
            b.Write((byte) model.WeaponCrateProbability);
            b.Write(model.DonorCards);
            b.Write((byte) model.HealthCrateProbability);
            b.Write((byte) model.HealthCrateEnergy);
            b.Write((byte) model.UtilityCrateProbability);
            b.Write((byte) model.HazardObjectTypes);
            b.Write((byte) model.MineDelay);
            b.Write(model.DudMines);
            b.Write(model.WormPlacement);
            b.Write((byte) model.InitialWormEnergy);
            b.Write((byte) model.TurnTime);
            b.Write((byte) model.RoundTime);
            b.Write((byte) model.NumberOfRounds);
            b.Write(model.Blood);
            b.Write(model.AquaSheep);
            b.Write(model.SheepHeaven);
            b.Write(model.GodWorms);
            b.Write(model.IndestructibleLand);
            b.Write(model.UpgradedGrenade);
            b.Write(model.UpgradedShotgun);
            b.Write(model.UpgradedClusterBombs);
            b.Write(model.UpgradedLongbow);
            b.Write(model.TeamWeapons);
            b.Write(model.SuperWeapons);

            foreach (var weapon in model.Weapons)
            {
                b.Write((byte) weapon.Ammo);
                b.Write((byte) weapon.Power);
                b.Write((byte) weapon.Delay);
                b.Write((byte) weapon.CrateProbability);
            }
        }
    }
}
