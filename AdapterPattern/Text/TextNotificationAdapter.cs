namespace AdapterPattern.Text
{
    public class TextNotificationAdapter : INotificationAdapter
    {
        private readonly ITextSender _smsSender;
        private readonly SmsSettings _settings;

        public TextNotificationAdapter(ITextSender smsSender, SmsSettings settings)
        {
            _smsSender = smsSender;
            _settings = settings;
        }

        public async void Notify(string user, string message)
        {
            // do something
        }
    }
}
