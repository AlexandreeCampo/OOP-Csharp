namespace Projetinho.NotificationContext
{
    public abstract class Notifiable
    {
        public IList<Notification> Notifications { get; set;}
        
        public void Add(Notification notifications)
        {
            Notifications.Add(notification);
        }

        public void AddRange(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}