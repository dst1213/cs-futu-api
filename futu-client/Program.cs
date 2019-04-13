using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using cs_futu_api.quote;

namespace futu_client
{
    class Program
    {
        static void Main(string[] args)
        {
            var hostName = "127.0.0.1";
            var portNum = 11111;

            var tradeHkCtx = new OpenHKTradeContext(hostName, portNum);



            tradeHkCtx.Close();

            Console.ReadKey();
        }
    }
}
