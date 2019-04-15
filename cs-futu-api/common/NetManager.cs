using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace cs_futu_api.common
{
    public class NetManager
    {
        static private TcpClient netMgr = new TcpClient();
        static private readonly NetManager netManager = new NetManager();

        public void SyncQuery()
        {
            
        }

        public void DoSend(int connId, object protoInfo,byte[] data)
        {
            netMgr.GetStream().Write(data,0,data.Length);
        }

        public void Connect()
        {

        }

        public void Start()
        {

        }

        public void Stop()
        {
            this.Close();
        }

        public void Close()
        {
            netMgr.Close();
        }
    }
}
