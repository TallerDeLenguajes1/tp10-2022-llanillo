// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Cost
    {
        [JsonPropertyName("Wood")]
        public int Wood { get; set; }

        [JsonPropertyName("Gold")]
        public int Gold { get; set; }

        [JsonPropertyName("Food")]
        public int? Food { get; set; }

        [JsonPropertyName("info")]
        public string Info { get; set; }

        [JsonPropertyName("Cost")]
        public string Cost { get; set; }

        [JsonPropertyName("Provides")]
        public Provides Provides { get; set; }
    }

    public class Provides
    {
        [JsonPropertyName("Food")]
        public int Food { get; set; }

        [JsonPropertyName("Resource Decay")]
        public double ResourceDecay { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("units")]
        public List<Unit> Units { get; set; }
    }

    public class Unit
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("expansion")]
        public string Expansion { get; set; }

        [JsonPropertyName("age")]
        public string Age { get; set; }

        [JsonPropertyName("created_in")]
        public string CreatedIn { get; set; }

        [JsonPropertyName("cost")]
        public Cost Cost { get; set; }

        [JsonPropertyName("build_time")]
        public int BuildTime { get; set; }

        [JsonPropertyName("reload_time")]
        public double ReloadTime { get; set; }

        [JsonPropertyName("attack_delay")]
        public double AttackDelay { get; set; }

        [JsonPropertyName("movement_rate")]
        public double MovementRate { get; set; }

        [JsonPropertyName("line_of_sight")]
        public int LineOfSight { get; set; }

        [JsonPropertyName("hit_points")]
        public int HitPoints { get; set; }

        [JsonPropertyName("range")]
        public object Range { get; set; }

        [JsonPropertyName("attack")]
        public int Attack { get; set; }

        [JsonPropertyName("armor")]
        public string Armor { get; set; }

        [JsonPropertyName("accuracy")]
        public string Accuracy { get; set; }

        [JsonPropertyName("attack_bonus")]
        public List<string> AttackBonus { get; set; }

        [JsonPropertyName("search_radius")]
        public int? SearchRadius { get; set; }

        [JsonPropertyName("blast_radius")]
        public double? BlastRadius { get; set; }

        [JsonPropertyName("armor_bonus")]
        public List<string> ArmorBonus { get; set; }
    }

