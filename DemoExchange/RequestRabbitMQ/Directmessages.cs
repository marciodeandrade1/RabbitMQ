using RabbitMQ.Client;
using System;
using System.Text;

namespace RequestRabbitMQ
{
    public class Directmessages
    {
        private const string UserName = "guest";
        private const string Password = "guest";
        private const string HostName = "localhost";
        public void SendMessage()
        {
            //Principal ponto de entrada do RabbitMQ .NET AMQP client
            var connectionFactory = new ConnectionFactory()
            {
                UserName = UserName,
                Password = Password,
                HostName = HostName
            };
            var connection = connectionFactory.CreateConnection();
            var model = connection.CreateModel();
            var properties = model.CreateBasicProperties();
            properties.Persistent = false;
            byte[] messagebuffer = Encoding.Default.GetBytes("Direct Message");
            model.BasicPublish("request.exchange", "directexchange_key", properties, messagebuffer);
            Console.WriteLine("Message Sent");
        }
    }
}
