using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace BacLabServer
{
    [DataContract]
    public class CallbackChannel
    {
  
        [DataMember]
        public string adress;
        [DataMember]
        public IMessageCallback callback;

    }
}
