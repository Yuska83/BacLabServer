using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BacLabClient.ServiceReference1;
using System.ServiceModel;


namespace BacLabClient
{
    [CallbackBehavior(UseSynchronizationContext =false)]
    public class CallbackHandler : ITestCallback
    {
        public IAsyncResult BeginShowMessage(string message, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public void EndShowMessage(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string message)
        {


           Window1 newW = new Window1(message);
        }
    }
}
