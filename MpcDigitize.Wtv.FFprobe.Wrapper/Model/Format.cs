﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpcdigitize.ffprobe.wtv.wrapper
{
    public class Format
    {
        public string filename { get; set; }
        public int nb_streams { get; set; }
        public int nb_programs { get; set; }
        public string format_name { get; set; }
        public string format_long_name { get; set; }
        public string start_time { get; set; }
        public string duration { get; set; }
        public string size { get; set; }
        public string bit_rate { get; set; }
        public int probe_score { get; set; }
        public Tags tags { get; set; }
    }
}
