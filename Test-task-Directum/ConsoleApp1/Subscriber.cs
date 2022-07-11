namespace ConsoleApp1
{
    public class Subscriber
    {
        public Subscriber(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public string Name { set; get; }
        public string Number { set; get; }
    }
}