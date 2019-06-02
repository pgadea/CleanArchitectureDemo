using CleanArchitecture.Domain.Core.Commands;

namespace CleanArchitecture.Domain.Commands
{
    public abstract class CourseCommand : Command
    {
        public string Name { get; protected set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }    
    }
}
