namespace ACDDS.TreasureHunter.Core.Models
{
    public class Character
    { 
        public Character()
        {
            Id = 1;
            Name = "Jim";
            HitPoints = 11;
            Luck = 4;
            
        }

        public int Id { get; }
        public string Name { get; }
        public int HitPoints { get; }
        public int Luck { get; }
    }
}

