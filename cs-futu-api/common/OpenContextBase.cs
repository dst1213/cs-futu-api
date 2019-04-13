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
            client.Connect(host, port);
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public void Close()
        {
            client.Close();
        }
    }
}
