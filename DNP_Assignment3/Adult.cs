using System;
using System.Collections.Generic;

#nullable disable

namespace DNP_Assignment3
{
    public partial class Adult
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int? Height { get; set; }
        public string Sex { get; set; }
        public string JobTitle { get; set; }
    }
}
