using System.Collections.Generic;
using TYITools.Models.Rules;

namespace TYITools.Models.Units.Aircraft
{
    public class AircraftUnit
    {
        public int Courage { get; set; }
        public int Morale { get; set; }
        public int Skill { get; set; }
        public int IsHitOn { get; set; }
        public int AircraftSave { get; set; }
        public List<Weapons> Weapons { get; set; }
        public List<Options> Options { get; set; }
        public List<UntitsRules> SpecialRules { get; set; }

        public AircraftUnit()
        {
            Weapons = new();
            Options = new();
            SpecialRules = new();
        }
    }
}
