using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYITools.Models.Units
{
    public class Weapons
    {
        private string halted;
        private string moved;
        public string Name { get; set; }
        public string Range { get; set; }
        public string Halted
        {
            get => halted; set
            {
                if (value.Contains("SALVO") || value.Contains("ARTILLERY"))
                {
                    halted = value;
                    moved = value;
                }
            }
        }
        public string Moved
        {
            get => moved; set
            {
                if (value.Contains("SALVO") || value.Contains("ARTILLERY"))
                {
                    halted = value;
                    moved = value;
                }
            }
        }
        public int Antitank { get; set; }
        public int FirePower { get; set; }
        public List<string> Notes { get; set; }

        public Weapons()
        {
            Notes = new();
        }
    }
}
