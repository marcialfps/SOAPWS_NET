using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using WS.Unit05.Example2.Data.Model;

namespace WS.Unit05.Example2.Data
{
    /// <summary>
    /// Descripción breve de DataService
    /// </summary>
    [WebService(Namespace = "http://ws.unit05.example2-data/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class DataService : System.Web.Services.WebService
    {

        [WebMethod]
        public Statistics[] GetStatistics()
        {
            using (DAOFactory factory = new DAOFactory())
            {
                return factory.StatisticsDAO.All().ToArray();
            }
        }

        [WebMethod]
        public long GetProductStatistics(String name)
        {
            using (DAOFactory factory = new DAOFactory())
            {
                var statistics = factory.StatisticsDAO.All()
                .FirstOrDefault(p => p.ProductName == name);
                return statistics != null ? statistics.Visits : 0;
            }
        }

        [WebMethod]
        public void CreateProductStatistics(String name)
        {
            using (DAOFactory factory = new DAOFactory())
            {
                var statistics = factory.StatisticsDAO.All().
               FirstOrDefault(p => p.ProductName == name);
                if (statistics != null)
                    throw new SoapException("Product already exists!!!",
                   SoapException.ClientFaultCode);
                factory.StatisticsDAO.Add(
               new Statistics() { ProductName = name, Visits = 1 });
            }
        }

        [WebMethod]
        public void UpdateProductStatistics(String name)
        {
            using (DAOFactory factory = new DAOFactory())
            {
                var statistics = factory.StatisticsDAO.All().
               FirstOrDefault(p => p.ProductName == name);
                if (statistics == null)
                    throw new SoapException("Product not found!!!",
                    SoapException.ClientFaultCode);
                statistics.Visits += 1;
                factory.StatisticsDAO.Update(statistics);
            }
        }
    }
}
