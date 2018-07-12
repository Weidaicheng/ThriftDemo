using LitJson;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServer.RPC
{
    public class PaymentServiceImpl : PaymentService.Iface
    {
        public TrxnResult Save(TrxnRecord trxn)
        {
            Console.WriteLine(JsonMapper.ToJson(trxn));

            return TrxnResult.SUCCESS;
        }
    }
}
