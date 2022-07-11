using System.Collections.Generic;

namespace ConsoleApp1
{
    public abstract class AbstractPhone : IPhone
    {
        public string Imei { get; }
        public string Number { set; get; }
        public List<Subscriber> SubscriberList { set; get; }
        
        public AbstractPhone(string imei, string number, List<Subscriber> subscriberList)
        {
            Imei = imei;
            Number = number;
            SubscriberList = subscriberList;
        }

        public abstract void ConnectBaseStation();
        
        public abstract void Call(string number);
        
        public abstract void Call(Subscriber subscriber);
    }
}