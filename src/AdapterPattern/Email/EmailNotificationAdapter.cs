namespace AdapterPattern.Email
{
    public class EmailNotificationAdapter : INotificationAdapter
    {
        private readonly IEmailSender _emailSender;
        private readonly EmailSettings _settings;

        public EmailNotificationAdapter(IEmailSender emailSender, EmailSettings settings)
        {
            _emailSender = emailSender;
            _settings = settings;
        }

        public async void Notify(string user, string message)
        {
            // do something
        }
    }
}
