using cs_futu_api.common.constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_futu_api.common
{
    /// <summary>
    /// 返回信息
    /// </summary>
    public class RET_MSG
    {
        public int RET;
        public string MSG;
    }

    public class RET_MSG_REQ
    {
        public int RET = GlobleConst.RET_OK;
        public string MSG;
        public object REQ;
    }
}
