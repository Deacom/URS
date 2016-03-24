using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Source
{
    public class WebPage : Source
    {
        private string _url;
        private PageType _pagetype;

        public string Url
        {
            get
            {
                return _url;
            }

            set
            {
                _url = value;
            }
        }
        public virtual PageType PageType { get; set; }
    }
}
