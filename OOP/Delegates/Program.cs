using System;

namespace Delegates
{
    class Program
    {
        public delegate void FirstDelegate();
        public delegate void MessageCarrier(string name);
        public delegate void NumCarrier(int num);

        static void Main(string[] args)
        {
            //Main way of using Delegates
            Messages message = new Messages();
            FirstDelegate firstDelegate = message.HelloMessage;
            firstDelegate();
            firstDelegate += message.ByeByeMessage;
            firstDelegate();


            MessagesToPerson toPerson = new MessagesToPerson();
            MessageCarrier carrier = toPerson.MessageToWorker;

            carrier("Gokcan");

            NumCarrier numCarrier = toPerson.TradePackage;

            numCarrier(1000);
          



        }
    }
}
