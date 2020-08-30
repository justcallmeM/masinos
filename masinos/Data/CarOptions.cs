using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace masinos.Data
{
    public class CarOptions
    {
        public Options Options { get; set; }
    }
    public class Options
    {
        public List<string> Size { get; set; }
        public List<string> Form { get; set; }
        public List<string> Usage { get; set; }
    }
}
