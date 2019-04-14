using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cs_futu_api.common.constant;

namespace cs_futu_api.common
{
    public class SysConfig
    {
        static private readonly SysConfig _Instance = new SysConfig();
        static private readonly ProtoFMT _PROTO_FMT = ProtoFMT.Protobuf;

        static public SysConfig One
        {
            get
            {
                return _Instance;
            }
        }

        public ProtoFMT GetProtoFmt()
        {
            return _PROTO_FMT;
        }
    }
}
