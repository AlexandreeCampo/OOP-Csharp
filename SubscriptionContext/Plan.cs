namespace Projetinho.Subscription
{
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Days { get; set; }
    }
}