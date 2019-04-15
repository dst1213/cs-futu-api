using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace cs_futu_api.common
{
    public class OpenContextBase
    {
        private TcpClient netMgr;

        public OpenContextBase(string host, int port, bool isAsyncConnect = true, bool isEncrypt = false)
        {
            netMgr = new TcpClient();

            LogHelper.Debug("准备建立连接");

            netMgr.Connect(host, port);

            LogHelper.Debug("连接建立");

        }

        public delegate void DgPack(params object[] args);
        public delegate void DgUnpack(params object[] args);


        public RET_MSG_OBJ GetSyncQueryProcessor(DgPack dgPack, DgUnpack dgUnpack)
        {
            //NetMgr.SyncQuery(connId, reqStr)
            return null;
        }

        public bool CheckTrdEnv()
        {
            return true;
        }

        public bool CheckAccIdAndAccIndex()
        {
            return true;
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public void Close()
        {
            LogHelper.Info("关闭连接");
            netMgr.Close();
        }
    }
}
