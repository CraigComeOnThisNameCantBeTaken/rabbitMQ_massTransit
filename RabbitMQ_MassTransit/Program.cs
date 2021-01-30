using System;

using RabbitMQ.Client;

namespace RabbitMQ_MassTransit
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver.Listen();
            Sender.Send();

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
