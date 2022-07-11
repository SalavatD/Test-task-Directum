namespace ConsoleApp1
{
    public interface IPhone
    {
        public void ConnectBaseStation();

        public void Call(string number);
        
        public void Call(Subscriber subscriber);
    }
}