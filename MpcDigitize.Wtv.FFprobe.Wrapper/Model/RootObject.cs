﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpcDigitize.Wtv.FFprobe.Wrapper.Model
{
    public class RootObject
    {
        public Stream[] streams { get; set; }
        public Format format { get; set; }

    }
}
