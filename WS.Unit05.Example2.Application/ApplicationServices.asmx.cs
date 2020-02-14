using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WS.Unit05.Example2.Application.Model;
using WS.Unit05.Example2.Application.WSClient.DataWS;
using WS.Unit05.Example2.Application.WSClient.FedexWS;
using WS.Unit05.Example2.Application.WSClient.IkeaWS;

namespace WS.Unit05.Example2.Application
{
    /// <summary>
    /// Descripción breve de ApplicationServices
    /// </summary>
    [WebService(Namespace = "http://ws.unit05.example2/application/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ApplicationServices : System.Web.Services.WebService
    {

        [WebMethod]
        public Product GetProduct(string name, Zone zone)
        {
            Product product = new Product();
            IkeaWSClient ikeaws = new IkeaWSClient();
            double ikeaPrice = ikeaws.search(name);
            if (ikeaPrice == 0) return null;
            product.Name = name;
            product.ProductPrice = ikeaPrice;
            double volume = 0;
            double weight = 0;

            foreach (var piece in ikeaws.pieces(name))
            {
                volume += piece.volume * piece.amount;
                weight += piece.weight * piece.amount;
            }

            double distance = 0;
            if (zone == Zone.CENTER)
                distance = 50;
            if (zone == Zone.EAST)
                distance = 75;
            else
                distance = 100;

            FedexWSClient fedexws = new FedexWSClient();
            var shipping = fedexws.shipping(volume, weight, distance);
            product.ShippingPrice = shipping.price;

            //Update statistics
            DataServiceSoapClient dataws = new DataServiceSoapClient();
            product.Visits = dataws.GetProductStatistics(name);
            if (product.Visits == 0)
                dataws.CreateProductStatistics(name);
            else
                dataws.UpdateProductStatistics(name);

            return product;
        }

        [WebMethod]
        public string[] GetProducts()
        {
            IkeaWSClient ikeaws = new IkeaWSClient();
            return ikeaws.list();
        }
    }
}
