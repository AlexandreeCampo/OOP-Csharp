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

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }

}