using System;
using RabbitMQ.Client;

namespace DemoQueueBinding
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

            model.QueueBind("demoqueue", "demoExchange", "directexchange_key");
            Console.WriteLine("Criando Binding");
            Console.ReadLine();
        }
    }
}
