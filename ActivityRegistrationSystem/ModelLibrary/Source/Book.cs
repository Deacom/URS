using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Source
{
    public class Book : Source
    {
        public int? Chapter { get; set; }
        public int? StartPage { get; set; }
        public int? EndPage { get; set; }
    }
}
