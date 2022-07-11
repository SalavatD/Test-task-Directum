using System;

namespace ConsoleApp1
{
    public class BaseStation3G: IBaseStation
    {
        public void HandleOutgoingCall()
        {
            Console.WriteLine("BaseStation3G.HandleOutgoingCall()");
        }

        public void RegisterPhone()
        {
            Console.WriteLine("BaseStation3G.RegisterPhone()");
        }
    }
}