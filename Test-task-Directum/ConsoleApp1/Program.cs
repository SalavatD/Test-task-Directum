using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Phone phone = new Phone("0", "+79991234567", new List<Subscriber>());
            Phone3G phone3G = new Phone3G("1", "+79991234568", new List<Subscriber>());
            BaseStation baseStation = new BaseStation();
            BaseStation3G baseStation3G = new BaseStation3G();

            Console.WriteLine(phone.Imei);
            Console.WriteLine(phone.Number);
            Console.WriteLine(phone.SubscriberList);
            
            phone.ConnectBaseStation();
            phone.Call("+79990000000");
            phone.Call(new Subscriber("John Doe", "+79990000000"));
            
            Console.WriteLine(phone3G.Imei);
            Console.WriteLine(phone3G.Number);
            Console.WriteLine(phone3G.SubscriberList);
            
            phone3G.ConnectBaseStation();
            phone3G.Call("+79990000000");
            phone3G.Call(new Subscriber("John Doe", "+79990000000"));
            
            baseStation.RegisterPhone();
            baseStation.HandleOutgoingCall();
            
            baseStation3G.RegisterPhone();
            baseStation3G.HandleOutgoingCall();
        }
    }
}