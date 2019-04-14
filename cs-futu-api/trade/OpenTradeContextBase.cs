using cs_futu_api.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_futu_api.trade
{
    public class OpenTradeContextBase : OpenContextBase
    {
        public OpenTradeContextBase(string host, int port, bool isAsyncConnect = true, bool isEncrypt = false) : base(host, port, isAsyncConnect, isEncrypt)
        {
        }
    }
}
