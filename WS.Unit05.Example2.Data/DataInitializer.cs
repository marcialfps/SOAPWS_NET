using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WS.Unit05.Example2.Data.Model;

namespace WS.Unit05.Example2.Data
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);
            context.Statistics.Add(new Statistics() { ProductName = "MALM", Visits = 10 });
            context.Statistics.Add(new Statistics() { ProductName = "BEKANT", Visits = 5 });
            context.SaveChanges();
        }
    }
}