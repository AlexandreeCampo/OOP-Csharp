namespace Projetinho.NotificationContext
{
    public sealed class Notification
    {
        public Notification()
        {

        }

        public Notification(string message, string message)
        {
            Property = Property;
            Message = message;
        }

        public string Property { get; set; }

        public string Message { get; set; }
    }
}