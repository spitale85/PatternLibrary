using AdapterPattern.Email;
using AdapterPattern.Sms;
using Xunit.Abstractions;

namespace AdapterPattern.Tests
{
    public class EmailNotificationNotify
    {
        private readonly ITestOutputHelper _output;

        public EmailNotificationNotify(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task UseSender1()
        {
            var emailSender = new EmailSender1();
            var settings = new EmailSettings();
            var emailNotification = new EmailNotificationAdapter(emailSender, settings);
            var notificationService = new NotificationService(emailNotification);
            notificationService.Notify("Pippo", "Ti vuole bene");
        }

        //[Fact]
        //public async Task UseSender2()
        //{

        //}

    }
}