using System.Collections.Generic;

namespace TYITools.Models.Formations
{
    public class FormationsModels
    {
        public List<HQInFormation> HQ { get; set; }
        public List<string> RequiredUnits { get; set; }
        public List<string> AdditionalUits { get; set; }

        public FormationsModels()
        {
            HQ = new();
            RequiredUnits = new();
            AdditionalUits = new();
        }
    }
}
