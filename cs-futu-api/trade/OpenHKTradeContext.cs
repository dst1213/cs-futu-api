using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cs_futu_api.common;

namespace cs_futu_api.trade
{
    public class OpenHKTradeContext : OpenTradeContextBase
    {
        public OpenHKTradeContext(string host, int port) : base(host, port)
        {

        }

        public object AccinfoQuery(TrdEnv trdEnv)
        {
            
            return "";
        }

        public RET_MSG UnlockTrade(string password, string passwordMd5, bool isUnlock = true)
        {
            return new RET_MSG();
        }
    }
}
