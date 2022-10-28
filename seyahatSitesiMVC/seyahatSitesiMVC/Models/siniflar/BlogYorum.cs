using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace seyahatSitesiMVC.Models.siniflar
{
    public class BlogYorum
    {
        public IEnumerable<blog> Deger1 { get; set; }
        public IEnumerable<yorumlar> Deger2 { get; set; }
        public IEnumerable<blog> Deger3 { get; set; }
        public IEnumerable<yorumlar> Deger4 { get; set; }
    }
}