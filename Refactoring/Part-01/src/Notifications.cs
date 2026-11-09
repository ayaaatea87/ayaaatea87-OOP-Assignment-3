using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Part_01.src
{
    public interface INotificationChannel
    {
        string Name { get; }

        void Send(string to, string message);
    }

    public class EmailNotification : INotificationChannel
    {
        public string Name => "email";

        public void Send(string to, string message)
        {
            Console.WriteLine($"[email] {to}: {message}");
        }
    }

    public class SmsNotification : INotificationChannel
    {
        public string Name => "sms";

        public void Send(string to, string message)
        {
            Console.WriteLine($"[sms] {to}: {message}");
        }
    }

    public class Notification
    {
        private readonly INotificationChannel _channel;
        private readonly bool _urgent;
        private readonly DateTime? _sendAt;

        public Notification( INotificationChannel channel,bool urgent = false, DateTime? sendAt = null)
        {
            _channel = channel;
            _urgent = urgent;
            _sendAt = sendAt;
        }

        public void Send(string to, string message)
        {
            var finalMessage = _urgent
                ? $"[URGENT] {message}"
                : message;

            if (_sendAt.HasValue)
            {
                Console.WriteLine(
                    $"[{_channel.Name} scheduled {_sendAt.Value:g}] {to}: {finalMessage}");
            }
            else
            {
                _channel.Send(to, finalMessage);
            }
        }
    }
}
