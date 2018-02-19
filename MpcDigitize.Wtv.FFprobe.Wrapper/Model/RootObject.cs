using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpcdigitize.ffprobe.wtv.wrapper
{
    public class RootObject
    {
        public Stream[] streams { get; set; }
        public Format format { get; set; }

    }
}
