using Projetinho.ContentContext.Enums;

namespace.ContentContext
{
    public class Lecture
    {
        public int Order { get; set; }

        public string Title { get; set; }

        public int DurationInMinutes { get; set; }

        public EcontentLevel Level { get; set; }
    }
}