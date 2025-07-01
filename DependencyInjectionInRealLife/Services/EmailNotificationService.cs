using DependencyInjectionInRealLife.Interfaces;

namespace DependencyInjectionInRealLife.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"[EMAIL] {message}");
        }
    }
}
