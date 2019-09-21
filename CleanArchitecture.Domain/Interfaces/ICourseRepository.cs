using CleanArchitecture.Domain.Models;
using System.Linq;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        void Add(Course course);
    }
}
