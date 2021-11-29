﻿using System.Collections.Generic;
using TYITools.Models.Rules;

namespace TYITools.Models.Units.Tanks
{
    public class TankUnit
    {
        public int Courage { get; set; }
        public int Morale { get; set; }
        public int Remount { get; set; }
        public int Skill { get; set; }
        public int Assault { get; set; }
        public int CounterAttack { get; set; }
        public int IsHitOn { get; set; }
        public List<Armour> Armours { get; set; }
        public int Tactical { get; set; }
        public int TerrainDash { get; set; }
        public int CrossCountryDash { get; set; }
        public int RoadDash { get; set; }
        public int Cross { get; set; }
        public List<Weapons> Weapons { get; set; }
        public List<Options> Options { get; set; }
        public List<UntitsRules> SpecialRules { get; set; }

        public TankUnit()
        {
            Armours = new();
            Weapons = new();
            Options = new();
            SpecialRules = new();
        }
    }
}
