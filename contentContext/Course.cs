namespace Projetinho.ContentContext
{
    public class Course : Content
    {
        public Course() // List inicialization
        {
            Modules = new List<Module>();
        }
        
        public string Tag { get; set; }

        public IList<Module> Modules { get; set; }
    }

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

    public class Lecture
    {
        public int Order { get; set; }

        public string Title { get; set; }
    }
}