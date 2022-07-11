using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Phone3G : AbstractPhone
    {
        public Phone3G(string imei, string number, List<Subscriber> subscriberList) :
            base(imei, number, subscriberList) {}

        public override void ConnectBaseStation()
        {
            Console.WriteLine("Phone3G.ConnectBaseStation()");
        }

        public override void Call(string number)
        {
            Console.WriteLine("Phone3G.Call(string number)");
        }
        
        public override void Call(Subscriber subscriber)
        {
            Console.WriteLine("Phone3G.Call(Subscriber subscriber)");
        }
    }
}