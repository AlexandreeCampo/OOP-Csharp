namespace Projetinho.ContentContext
{
    public abstract class Content
    {
        public Content()
        [
            Id = Guid.NewGuid();
        ]

        public int Guid Id { get; set; } // Guid is a abreviation for Global Unique Identify

        public string Title { get; set;}

        public string Url { get; set; }
    }
}