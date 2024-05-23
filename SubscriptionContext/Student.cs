using System.Collections.Generic;
using Projetinho.SharedContext;
namespace Projetinho.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            SubscriptionContext = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        
        public void CreateSubscription(SubscriptionContext subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification(("Premium", "O aluno já tem assinatura ativa"));
                return;
            }
            Subscriptions.Add(subscription);
        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}