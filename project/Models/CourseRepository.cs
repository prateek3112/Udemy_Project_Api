using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class CourseRepository : iCourseRepository
    {
        private readonly AppDbContext _appDbContext;
        public CourseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<courses> Courses
        {
            get
            {
                return _appDbContext.Course.Include(c => c.Category);
            }
        }
        public courses GetCourseByCategory(int Categoryid)
        {
            return _appDbContext.Courses.FirstOrDefault(p => p.CourseId == Categoryid);
        }
        public IEnumerable<courses> CourseOfTheWeek
        {
            get
            {
                return _appDbContext.Courses.Include(c => c.Category).Where(p => p.IsCourseOfTheWeek);
            }
        }
    }
}
