using System;
using System.Collections.Generic;

#nullable disable

namespace DNP_Assignment3
{
    public partial class PagcRule
    {
        public int Id { get; set; }
        public string Rule { get; set; }
        public bool? IsCustom { get; set; }
    }
}
