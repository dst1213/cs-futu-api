using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cs_futu_api.common;

namespace cs_futu_api.quote
{
    public class OpenQuoteContext : OpenContextBase
    {
        public OpenQuoteContext(string host, int port, bool isAsyncConnect = true, bool isEncrypt = false) : base(host, port, isAsyncConnect, isEncrypt)
        {
        }

        public void GetTradingDays(string trdEnv, int accId,int accIndex)
        {

        }
    }
}
