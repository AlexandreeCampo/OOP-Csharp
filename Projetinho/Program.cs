using System;
using System.Collections.Generic;
using System.Linq;
using Projeitnho.ContentContext;
using Projeitnho.SubscriptionContext;


namespace Projeitnho
{
    public class Program 
    {
        static void Main (string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Article about OOP", "object-orientation"));
            articles.Add(new Article("Article about C#", "csharp"));
            articles.Add(new Article("Article about .NET", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }
}