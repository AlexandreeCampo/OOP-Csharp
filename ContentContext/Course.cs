using System.Collections.Generic;
using Projetinho.ContentContext.Enums;
namespace Projetinho.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url) // List inicialization
            :base(title, url)
        {
            Modules = new List<Module>();
        }
        
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }

}