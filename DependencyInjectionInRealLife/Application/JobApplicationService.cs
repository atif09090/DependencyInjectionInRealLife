using DependencyInjectionInRealLife.Services;

namespace DependencyInjectionInRealLife.Application
{
    public class JobApplicationService
    {
        private readonly EmailNotificationService _emailService = new EmailNotificationService();

        public void Apply(string applicantName)
        {
            Console.WriteLine($"Application received for {applicantName}");
            _emailService.Send("Application submitted successfully!");
        }
    }
}
