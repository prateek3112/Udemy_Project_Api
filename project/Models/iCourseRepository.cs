using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public interface iCourseRepository
    {
        IEnumerable<courses> Courses { get; }
        public courses GetCourseByCategory(int CategoryId);
        IEnumerable<courses> CourseOfTheWeek { get; }
    }
   
}
