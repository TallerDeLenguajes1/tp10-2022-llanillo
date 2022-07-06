namespace Ejercicio1{
    public class Civilizacion{
        
        [JsonPropertyName("id")]
        public int Id{ get; set; }

        [JsonPropertyName("name")]
        public string Name{ get; set; }

        [JsonPropertyName("expasion")]
        public string Expansion{ get; set; }

        [JsonPropertyName("army_type")]
        public strig ArmyType{ get; set; }

        [JsonPropertyName("unique_unit")]
        public List<string> UniqueUnit;

        [JsonPropertyName("unique_tech")]
        public List<string> UniqueTech;

        [JsonPropertyName("team_bonus")]
        public string TeamBonus { get; set; }

        [JsonPropertyName("civilization_bonus")]
        public List<string> CivilizationBonus;

        public override string ToString(){
            return "Id: " + Id + '\n'
                "Name: " + Name + '\n'
                "Expansion: " + Expansion + '\n'
                "Army Type: " + ArmyType.ToString() + '\n'
                "Unique Unit: " + UniqueUnit.ToString() + '\n'
                "Team Bonus: " + TeamBonus + '\n'
                "Civilizations Bonuses: " + CivilizationBonus.ToString() + '\n';
        }
    }
}