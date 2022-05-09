using System;
using RabbitMQ.Client;

namespace DemoExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = "guest";
            string Password = "guest";
            string HostName = "localhost";

            var connectionFactory = new ConnectionFactory()
            {
                UserName = UserName,
                Password = Password,
                HostName = HostName

            };

            var connection = connectionFactory.CreateConnection();
            var model = connection.CreateModel();

            //Criação Exchange
            model.ExchangeDeclare("demoExchange", ExchangeType.Direct);
            Console.WriteLine("Criado Exchange");
            Console.ReadKey();
        }
    }
}
