using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BacLabServer
{
    interface ITestCallback
    {
        [OperationContract(IsOneWay = true)]
        void ShowMessage(string message);

    }
}
