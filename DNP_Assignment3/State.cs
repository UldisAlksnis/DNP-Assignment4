﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DNP_Assignment3
{
    public partial class State
    {
        public int Gid { get; set; }
        public string Region { get; set; }
        public string Division { get; set; }
        public string Statefp { get; set; }
        public string Statens { get; set; }
        public string Stusps { get; set; }
        public string Name { get; set; }
        public string Lsad { get; set; }
        public string Mtfcc { get; set; }
        public string Funcstat { get; set; }
        public long? Aland { get; set; }
        public long? Awater { get; set; }
        public string Intptlat { get; set; }
        public string Intptlon { get; set; }
    }
}
