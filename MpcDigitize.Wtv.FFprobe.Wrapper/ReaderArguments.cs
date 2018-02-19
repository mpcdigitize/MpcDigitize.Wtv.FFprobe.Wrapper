using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpcdigitize.ffprobe.wtv.wrapper
{
    public class ReaderArguments
    {

        private Dictionary<string, string> _arguments;

        public ReaderArguments()
        {
            _arguments = new Dictionary<string, string>();


            _arguments.Add("Json", " -v quiet -print_format json -show_format -show_streams ");
            _arguments.Add("Xml", " -v quiet -print_format xml -show_format -show_streams ");



        }



        public string GetValue(string argument)
        {

            string value = "";

            _arguments.TryGetValue(argument, out value);

            return value;
        }

    }
}
