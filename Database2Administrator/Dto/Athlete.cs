using System;

namespace Database2Administrator.Dto
{
    class Athlete
    {
        public string Id { get; set; }
        public string TeamId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Image { get; set; }
        public int Gender { get; set; }
    }
}
