using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BacLabServer
{
    
    class Test : ITest
    {
        //свойство для дуплекса
        ITestCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<ITestCallback>();
            }
        }



        public void testMetod(string str)
        {
            try
            {
                
                Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Callback.ShowMessage(str);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
