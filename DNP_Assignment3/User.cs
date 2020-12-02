using System;
using System.Collections.Generic;

#nullable disable

namespace DNP_Assignment3
{
    public partial class User
    {
        public int? Id { get; set; }
        public string Username { get; set; }
        public string Domain { get; set; }
        public string City { get; set; }
        public int? BirthYear { get; set; }
        public string Role { get; set; }
        public int? SecurityLevel { get; set; }
        public string Password { get; set; }
        public int? Column9 { get; set; }
    }
}
