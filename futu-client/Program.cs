using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using cs_futu_api.common;
using cs_futu_api.trade;

namespace futu_client
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostName = "127.0.0.1";
            var portNum = 11111;

            var tradeHkCtx = new OpenHKTradeContext(hostName, portNum);

            LogHelper.Info(TrdEnv.SIMULATE.ToString());

            var accInfo = tradeHkCtx.AccinfoQuery(TrdEnv.SIMULATE);

            LogHelper.Info(accInfo.ToString());

            tradeHkCtx.Close();

            Console.ReadKey();
        }
    }
}
