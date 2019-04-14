using cs_futu_api.common.constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_futu_api.common
{
    public class Utils
    {

        /// <summary>
        /// 在C#中可能不需要这个工具类
        /// </summary>
        /// <param name="pbReq"></param>
        /// <param name="protoId"></param>
        /// <param name="connId"></param>
        /// <param name="serialNo"></param>
        /// <returns></returns>
        static public RET_MSG_REQ PackPbReq(object pbReq, int protoId,int connId,int serialNo= 0)
        {
            /*
    proto_fmt = SysConfig.get_proto_fmt()
    serial_no = serial_no if serial_no else get_unique_id32()
    is_encrypt = FutuConnMng.is_conn_encrypt(conn_id)

    if proto_fmt == ProtoFMT.Json:
        req_json = MessageToJson(pb_req)
        ret, msg, req = _joint_head(proto_id, proto_fmt, len(req_json),
                          req_json.encode(), conn_id, serial_no, is_encrypt)
        return ret, msg, req

    elif proto_fmt == ProtoFMT.Protobuf:
        ret, msg, req = _joint_head(proto_id, proto_fmt, pb_req.ByteSize(), pb_req, conn_id, serial_no, is_encrypt)
        return ret, msg, req
    else:
        error_str = ERROR_STR_PREFIX + 'unknown protocol format, %d' % proto_fmt
        return RET_ERROR, error_str, None
             */

            RET_MSG_REQ ret = new RET_MSG_REQ();

            if (SysConfig.One.GetProtoFmt() == ProtoFMT.Json)
            {
                return ret;
            }
            else if (SysConfig.One.GetProtoFmt() == ProtoFMT.Protobuf)
            {


                return ret;
            }
            else
            {
                ret.RET = GlobleConst.RET_ERROR;
                return ret;
            }
        }

        static public void JointHead(int protoId, ProtoFMT protoFmtType,int bodyLen,string strBody,int connId,int serialNo,bool isEncrypt)
        {
              //Google.Protobuf.
        }
    }
}
