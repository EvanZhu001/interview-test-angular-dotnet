using System;

namespace CowApi.Models.Cows
{
    public class Cow
    {
        public string ID { get; set; }

        public DateOnly BirthDate { get; set; }

        public string Breed { get; set; }

        public double MatureBodyWeight { get; set; }
    }
}
