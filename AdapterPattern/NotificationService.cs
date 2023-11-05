namespace AdapterPattern
{
    public class NotificationService
    {
        private readonly INotificationAdapter _notificationAdapter;

        public NotificationService (INotificationAdapter notificationAdapter)
        {
            _notificationAdapter = notificationAdapter;
        }

        public async void Notify(string user, string message)
        {
            _notificationAdapter.Notify(user, message);
        }
    }
}
