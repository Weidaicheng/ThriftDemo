using System;
using Thrift.Server;
using Thrift.Transport;

namespace PaymentServer.RPC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PaymentService RPC Server is lunched");

            var transport = new TServerSocket(8885);
            var processor = new PaymentService.Processor(new PaymentServiceImpl());

            var server = new TThreadedServer(processor, transport);
            server.Serve();
        }
    }
}
