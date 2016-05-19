using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary;
using Entity;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ChannelFactory<IService> cf = new ChannelFactory<IService>(
                    new WebHttpBinding(), "http://192.168.0.13:666/test"))
                {
                    cf.Endpoint.Behaviors.Add(new WebHttpBehavior());
                    IService channel = cf.CreateChannel();
                    var v = channel.GetStoresList();
                    foreach (var r in v)
                        Console.WriteLine(r.OidStore.ToString());
                }
                Console.ReadLine();
            }
            catch (Exception x)
            {
                Console.WriteLine("An exception occurred: {0}", x.Message);
                Console.ReadLine();
            }
        }
    }
}
