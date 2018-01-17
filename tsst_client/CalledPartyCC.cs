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
    class CalledPartyCC
    {
        public const string CALL_REQUEST = "callRequest";
        public const string CONNECTION_REQUEST = "connectionRequest";
        public const string CALL_TEARDOWN = "callTerdown";
        public const string CALL_COORDINATION = "callCoordination";
        public const string CALL_INDICATION = "callIndication";
        public const string CALL_CONFIRMED_CPCC = "callConfirmedCPCC";

        private static string userAddress_1;
        private static string userAddress_2;
        private static int capacity;

        private static CSocket csocket;
        private static MessageParameters messageParameters;       

      

        public static void Init()
        {
            InitListeningCustomSocket();
            ListenForConnections();
        }

        public static void InitListeningCustomSocket()
        {
            string ipAdd = Config.getProperty("IPaddress");
            IPAddress ipAddress = IPAddress.Parse(ipAdd);
            int port = Config.getIntegerProperty("listenPort");
            csocket = new CSocket(ipAddress, port, CSocket.LISTENING_FUNCTION);
        }

        public static void ListenForConnections()
        {
            InitListenThread();
        }

        private static Thread InitListenThread()
        {
            var t = new Thread(() => RealStart());
            t.IsBackground = true;
            t.Start();
            return t;
        }

        private static void RealStart()
        {
            csocket.Listen();
            while (true)
            {
                CSocket connected = csocket.Accept();
                WaitForInputFromSocketInAnotherThread(connected);
            }

        }

        private static void WaitForInputFromSocketInAnotherThread(CSocket connected)
        {
            var t = new Thread(() => WaitForInput(connected));
            t.Start();
        }

        private static void WaitForInput(CSocket socket)
        {
            Tuple<String, Object> received = socket.ReceiveObject();
            String parameter = received.Item1;
            messageParameters = (MessageParameters)received.Item2;

            if (parameter.Equals(CALL_INDICATION))
            {
                CPCC.PrintLogs(CALL_INDICATION);
                CPCC.SendMessage(CALL_CONFIRMED_CPCC, messageParameters.getFirstParameter(), messageParameters.getSecondParameter(), messageParameters.getCapacity());
            }
            else if (parameter.Equals(CALL_COORDINATION))
            {              
                CPCC.SendMessage(CALL_CONFIRMED_CPCC, messageParameters.getFirstParameter(), messageParameters.getSecondParameter(), messageParameters.getCapacity());
            }
        }
    }
}
