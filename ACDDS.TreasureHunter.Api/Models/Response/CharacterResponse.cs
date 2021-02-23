using System.Collections.Generic;

namespace ACDDS.TreasureHunter.Api.Models.Response
{
    public class CharacterResponse
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int Luck { get; set; }
        public int Wealth { get; set; }        
        public IList<EquipmentResponse> Equipment { get; set; }
    }

    public class CharacterResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hit_points { get; set; }
        public int Luck { get; set; }
        public string Characterimage { get; set; }        
    }
}
