using DependencyInjectionInRealLife.Interfaces;

namespace DependencyInjectionInRealLife.Services
{
    public class SmsNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"[SMS] {message}");
        }
    }
}
