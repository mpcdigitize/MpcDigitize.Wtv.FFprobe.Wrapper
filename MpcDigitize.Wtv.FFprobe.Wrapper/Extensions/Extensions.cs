
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpcdigitize.ffprobe.wtv.wrapper.Extensions
{
    public static class Extensions
    {
        public static RootObject GetMetadata(this string readerOutput)
        {
           RootObject metadata = JsonConvert.DeserializeObject<RootObject>(readerOutput);

            return metadata;
        }

      

    
    }
}
