using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Messages
    {
        public void HelloMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ByeByeMessage()
        {
            Console.WriteLine("GoodBye!");
        }
    }



    public class MessagesToPerson
    {

        public void MessageToWorker(string name)
        {
            Console.WriteLine($"{name} lead to all operations!");
        }

        public void TradePackage(int numOfPackage)
        {
            Console.WriteLine($"{numOfPackage} will arrive today!");
        }


    }



}
