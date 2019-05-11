using CleanArchitecture.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
