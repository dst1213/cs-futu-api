using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrdGetFunds;

namespace cs_futu_api.trade.trade_query
{
    public class AccInfoQuery
    {
        public void PackReq(ulong accId, int trdMarket, int trdEnv, object connId)
        {
            /*
        from futu.common.pb.Trd_GetFunds_pb2 import Request
        req = Request()
        req.c2s.header.trdEnv = TRD_ENV_MAP[trd_env]
        req.c2s.header.accID = acc_id
        req.c2s.header.trdMarket = TRD_MKT_MAP[trd_market]

        return pack_pb_req(req, ProtoId.Trd_GetFunds, conn_id)
             */

            TrdGetFunds.Request request = new TrdGetFunds.Request();
            request.C2S.Header.AccID = accId;
            request.C2S.Header.TrdEnv = trdEnv;
            request.C2S.Header.TrdMarket = trdMarket;
        }

        public void UnpackRsp(object rspPb)
        {

        }
    }
}
