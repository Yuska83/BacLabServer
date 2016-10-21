using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BacLabServer
{
    [ServiceContract (CallbackContract = typeof(ITestCallback))]
    interface ITest
    {
        [OperationContract(IsOneWay =true)]
        void testMetod(string str);
    }
}
