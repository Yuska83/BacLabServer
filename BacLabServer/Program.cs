using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BacLabServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(Test));
            sh.Open();
            Console.WriteLine("Для завершения нажмите ENTER");
            Console.ReadLine();

            sh.Close();
        }
    }
}
