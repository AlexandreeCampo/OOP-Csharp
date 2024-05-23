using Projetinho.NotificationContext;

namespace Projetinho.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; } // Guid is a abreviation for Global Unique Identify
    }
}