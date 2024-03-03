using KodlamaIO.Business.Abstracts;
using KodlamaIO.Business.Concretes;
using KodlamaIO.DataAccess.Concretes.EntityFramework;

Console.WriteLine("hello");

ICourseService courseService = new CourseManager(new EfCourseDal());

var result = courseService.GetAll();

foreach (var course in result)
{
    Console.WriteLine(course.Name);
}