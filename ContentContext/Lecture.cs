using Projetinho.ContentContext.Enums;
using Projetinho.SharedContext;

namespace Projetinho.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EcontentLevel Level { get; set; }
    }
}