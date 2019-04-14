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
    public struct RET_MSG
    {
        int RET;
        string MSG;
    }

    public struct RET_MSG_REQ
    {
        int RET;
        string MSG;
        object REQ;
    }
}
