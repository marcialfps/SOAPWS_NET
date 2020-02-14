using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WS.Unit05.Example2.Data.Model;

namespace WS.Unit05.Example2.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Statistics> Statistics { get; set; }
    }
}