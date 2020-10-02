using System;

namespace Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.setColor("yellow");
            fan1.setRadius(10);
            fan1.setSpeed(1);
            fan1.turnOn();
            Fan fan2 = new Fan();
            fan2.setColor("blue");
            fan2.setRadius(5);
            fan2.setSpeed(2);
            fan2.turnOff();
            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
        }
    }
}
