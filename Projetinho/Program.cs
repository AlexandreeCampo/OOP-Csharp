using System;
using System.Net.Mime;
using System.Runtime.InteropServices;

namespace Projeitnho
{
    public class Program 
    {
        static void Main (string[] args)
        {
            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Beginner
            foreach (var item in course.Modules)
            {
                
            }
            var career = new Career();
            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);
        }
    }
}