namespace Projetinho.ContentContext
{
    public class Article
    {
        public class Article : Content
        {
            public Article(string title, string url)
                :base(title, url)
            {

            }
        }
    }
}