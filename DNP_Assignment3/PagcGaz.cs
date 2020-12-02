using System;
using System.Collections.Generic;

#nullable disable

namespace DNP_Assignment3
{
    public partial class PagcGaz
    {
        public int Id { get; set; }
        public int? Seq { get; set; }
        public string Word { get; set; }
        public string Stdword { get; set; }
        public int? Token { get; set; }
        public bool? IsCustom { get; set; }
    }
}
