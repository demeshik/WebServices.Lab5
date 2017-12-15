using Lab5.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.HTTPClient
{
    class Program
    {
        public static IService1 service1;
        static void Main(string[] args)
        {
            BasicHttpBinding httpBinding = new BasicHttpBinding();
            EndpointAddress addr = new EndpointAddress("http://localhost/WCFSimplexHost");
            ChannelFactory<IService1> channelFactory = new ChannelFactory<IService1>(httpBinding, addr);
            service1 = channelFactory.CreateChannel();

            int result = service1.Add(5, 10);

            string y = service1.Concat("hello ", 4.5);

            A resultA = service1.Sum(new A { k = 5, s = "hello", f = 0.5f }, new A { k = 10, s = ", world", f = 0.7f });

            Console.WriteLine($"Result of addition of 2 numbers - {result}");
            Console.WriteLine($"Result of addition of string and double value - {y}");
            Console.WriteLine($"Result of addition of two A - k: {resultA.k}, s: {resultA.s}, f: {resultA.f}");
        }
    }
}
