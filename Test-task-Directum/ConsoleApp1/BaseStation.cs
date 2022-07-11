using System;

namespace ConsoleApp1
{
    public class BaseStation: IBaseStation
    {
        public void HandleOutgoingCall()
        {
            Console.WriteLine("BaseStation.HandleOutgoingCall()");
        }

        public void RegisterPhone()
        {
            Console.WriteLine("BaseStation.RegisterPhone()");
        }
    }
}