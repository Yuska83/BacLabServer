using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BacLabServer
{
    //[ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Reentrant)]
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession,IncludeExceptionDetailInFaults =true)]
    public class MessageService : IMessageService
    {
        private static List<CallbackChannel> subscribers = new List<CallbackChannel>();
         
        /// <summary>
        /// клиенты подписываются на получение сообщений
        /// </summary>
        /// <param name="adress"></param>
        /// <returns></returns>
        public bool Subscribe(string adress)
        {
            try
            {
                CallbackChannel newCallback = new CallbackChannel();
                newCallback.callback = OperationContext.Current.GetCallbackChannel<IMessageCallback>();
                newCallback.adress = adress;

                if (!subscribers.Contains(newCallback))
                    subscribers.Add(newCallback);

                Console.WriteLine(newCallback.adress);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message+" "+ex.StackTrace);
                return false;
            }
        }

        /// <summary>
        /// добавить общее сообщение
        /// </summary>
        /// <param name="senderId"></param>
        /// <param name="message"></param>
        public void AddMessage(int senderId, string message)
        {

            for (int i = 0; i < subscribers.Count; )
            {
                if(((ICommunicationObject)subscribers[i].callback).State == CommunicationState.Opened)
                {
                    Console.WriteLine(subscribers[i].adress+" "+message);
                    subscribers[i].callback.OnMessageAdded(message, DateTime.Now);
                    i++;
                }
                else
                {
                    Console.WriteLine(subscribers[i].adress + " " + "out");
                    subscribers.Remove(subscribers[i]);
                    
                }
            }

           
        }

       
    }
}
