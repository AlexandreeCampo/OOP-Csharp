using System.Collections.Generic;
using Projetinho.SharedContext;

namespace Projetinho.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lecture { get; set; }
    }
}