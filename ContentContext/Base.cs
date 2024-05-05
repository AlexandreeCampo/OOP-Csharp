using Projetinho.NotificationContext;

namespace Projetinho.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public int Guid Id { get; set; } // Guid is a abreviation for Global Unique Identify
    }
}