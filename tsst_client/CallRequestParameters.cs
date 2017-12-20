using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsst_client
{
    [Serializable]
    public class CallRequestParameters
    {
        private string userName;
        private string destinationUserName;

        public CallRequestParameters(string userName, string destinationUserName)
        {
            this.userName = userName;
            this.destinationUserName = destinationUserName;
        }

        public String getUserName()
        {
            return userName;
        }

        public String getDestinationUserName()
        {
            return destinationUserName;
        }
    }
}
