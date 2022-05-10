using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace RabbitMQConsumer
{
        public class MessageReceiver : DefaultBasicConsumer
        {
            private readonly IModel _channel;
            public MessageReceiver(IModel channel)
            {
                _channel = channel;
            }
        public void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, IBasicProperties properties, byte[] body)
            {
                Console.WriteLine($" ===== Consumindo Menssagem ====");
                Console.WriteLine(string.Concat("Menssagem recebida do exchange ", exchange));
                Console.WriteLine(string.Concat("Consumidor tag: ", consumerTag));
                Console.WriteLine(string.Concat("Entregue tag: ", deliveryTag));
                Console.WriteLine(string.Concat("Roteamento tag: ", routingKey));
                Console.WriteLine(string.Concat("Menssagem: ", Encoding.UTF8.GetString(body)));
                _channel.BasicAck(deliveryTag, false);
            }
        }
    }
