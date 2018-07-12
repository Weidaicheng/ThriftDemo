using System;
using Thrift.Protocol;
using Thrift.Transport;

namespace PaymentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入发送订单：");
            Console.ReadLine();

            using (var transport = new TSocket("localhost", 8885))
            {
                using(var protocol = new TBinaryProtocol(transport))
                {
                    using(var client = new PaymentService.Client(protocol))
                    {
                        transport.Open();

                        var record = new TrxnRecord()
                        {
                            TrxnId = 10000,
                            TrxnName = "Premium payment",
                            TrxnAmount = 5000,
                            TrxnType = "1",
                            Remark = "remark"
                        };

                        var result = client.Save(record);
                        Console.WriteLine(result);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
