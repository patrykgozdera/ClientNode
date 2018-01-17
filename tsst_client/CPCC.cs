using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomSocket;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace tsst_client
{
    public class CPCC
    {
        private static MessageParameters messageParameters;
        private static CSocket csocket;
        public const String CALL_REQUEST = "callRequest";
        public const String CALL_TEARDOWN = "callTeardown";

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

        public static void PrintLogs(String function)
        {
            if (function.Equals(CALL_REQUEST))
                Print(Form1.sendRefer, "Sent CALL REQUEST to NCC");
            else if (function.Equals(CalledPartyCC.CALL_INDICATION))
            {
                Print(Form1.receiveRefer, "Received CALL INDICATION from NCC");
                Print(Form1.sendRefer, "Sent CALL CONFIRMED to NCC");
            }    
        }

        private static void Print(ListBox listBox, String log)
        {
            listBox.Invoke(new Action(delegate ()
            {
                listBox.Items.Add(GetCurrentTimeStamp() + " | " + log);
                listBox.SelectedIndex = listBox.Items.Count - 1;
            }));
        }

        private static String GetCurrentTimeStamp()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString("HH:mm:ss.ff");
        }
    }
}
