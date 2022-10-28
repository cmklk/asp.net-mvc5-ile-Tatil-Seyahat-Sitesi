using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace seyahatSitesiMVC.Models.siniflar
{
    public class context:DbContext
    {
        public DbSet<admin> admins { get; set; }
        public DbSet<adresBlog> adresBlogs { get; set; }
        public DbSet<blog> blogs { get; set; }
        public DbSet <hakkimizda> hakkimizdas { get; set; }
        public DbSet <iletisim> iletisims { get; set; }
        public DbSet <yorumlar> yorumlars { get; set; }
    }
}