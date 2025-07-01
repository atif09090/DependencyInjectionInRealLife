using DependencyInjectionInRealLife.Interfaces;

namespace DependencyInjectionInRealLife.Application
{
    public class EfficientJobApplicationService
    {
        private readonly INotificationService _notificationService;

        public EfficientJobApplicationService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Apply(string applicantName)
        {
            Console.WriteLine($"Application received for {applicantName}");
            _notificationService.Send($"Hello {applicantName}, your job application was submitted!");
        }
    }
}
