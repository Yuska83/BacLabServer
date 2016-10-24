using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BacLabServer
{
    
    [ServiceContract(CallbackContract = typeof(IMessageCallback))]
    public interface IMessageService
    {
        [OperationContract(IsOneWay = true)]
        void AddMessage(int senderId, string message);

        [OperationContract]
        bool Subscribe(string adress);

       
    }
}
