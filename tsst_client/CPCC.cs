using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomSocket;
using System.Net;
using System.Threading;

namespace tsst_client
{
    public class CPCC
    {
        private static MessageParameters messageParameters;
        private static CSocket csocket;
        public const String CALL_REQUEST="callRequest";         

        public static void Init()
        {
            string ipAdd = Config.getProperty("IPaddress");
            IPAddress ipAddress = IPAddress.Parse(ipAdd);            
            csocket = new CSocket(ipAddress, Config.getIntegerProperty("sendPort"), CSocket.CONNECT_FUNCTION);            
        }

        public static Thread InitSendingThread(string mName, string uName, string dName, int c)
        {
            var t = new Thread(() => SendMessage(mName, uName, dName, c));
            t.IsBackground = true;
            t.Start();
            return t;
        }

        public static void SendMessage(string messageName, string userName, string destinationUserName, int capacity)
        {
            messageParameters = new MessageParameters(userName, destinationUserName, capacity);              
            Init();            
            csocket.SendObject(messageName, messageParameters);
        }
        
    }
}
