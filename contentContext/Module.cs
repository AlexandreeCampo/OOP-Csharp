using System.Collections.Generic;

namespace Projetinho.ContentContext
{
    public class Module //List
    {
        public Course ()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }

        public string Title { get; set; }

        public IList<Lecture> Lecture { get; set; }

    }
}