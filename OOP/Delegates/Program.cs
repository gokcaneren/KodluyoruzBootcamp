using System;

namespace Delegates
{
    class Program
    {
        public delegate void FirstDelegate();

        static void Main(string[] args)
        {
            Messages message = new Messages();

            FirstDelegate firstDelegate = message.HelloMessage;
            firstDelegate();

            firstDelegate += message.ByeByeMessage;

            firstDelegate();


        }
    }
}
