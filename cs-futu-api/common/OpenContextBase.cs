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
        private TcpClient client;

        public OpenContextBase(string host,int port,bool isAsyncConnect=true,bool isEncrypt= false)
        {
            client = new TcpClient();

            LogHelper.Debug("准备建立连接");

            client.Connect(host, port);

            LogHelper.Debug("连接建立");
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
            client.Close();
        }
    }
}
