using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Phone : AbstractPhone
    {
        public Phone(string imei, string number, List<Subscriber> subscriberList) :
            base(imei, number, subscriberList) {}

        public override void ConnectBaseStation()
        {
            Console.WriteLine("Phone.ConnectBaseStation()");
        }

        public override void Call(string number)
        {
            Console.WriteLine("Phone.Call(string number)");
        }
        
        public override void Call(Subscriber subscriber)
        {
            Console.WriteLine("Phone.Call(Subscriber subscriber)");
        }
    }
}