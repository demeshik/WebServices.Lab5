using Lab5.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                NetTcpBinding binding = new NetTcpBinding();

                host.AddServiceEndpoint(typeof(IService1), binding, new Uri("net.tcp://localhost/WCFSimplexHost"));
                host.Open();

                Console.WriteLine("Service up and running at:");
                foreach (var ea in host.Description.Endpoints)
                {
                    Console.WriteLine(ea.Address);
                }
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
