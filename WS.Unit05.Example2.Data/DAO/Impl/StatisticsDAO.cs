using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WS.Unit05.Example2.Data.Model;

namespace WS.Unit05.Example2.Data.DAO.Impl
{
    public class StatisticsDAO : GenericDAO<Statistics>, IStatisticsDAO
    {
        public StatisticsDAO(DataContext context) : base(context) { }
    }
}