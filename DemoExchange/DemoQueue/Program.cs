using System;
using RabbitMQ.Client;

namespace DemoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = "guest";
            string Password = "guest";
            string HostName = "localhost";

            //Ponto de entrada para o RabbitMQ
            var connectionFactory = new RabbitMQ.Client.ConnectionFactory()
            {
                UserName = UserName,
                Password = Password,
                HostName = HostName
            };

            var connection = connectionFactory.CreateConnection();
            var model = connection.CreateModel();

            //Criando Queue
            model.QueueDeclare("demoqueue", true, false, false, null);
            Console.WriteLine("Criando Queue");
            Console.ReadLine();
        }
    }
}
