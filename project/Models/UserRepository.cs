//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace project.Models
//{
//    public class UserRepository : IUser
//    {
//        public UserRepository(AppDbContext appDbContext)
//        {
//            _appDbContext = appDbContext;
//        }
//        public IEnumerable<courses> courses
//        {
//            get
//            {
//                return _appDbContext.Pies.Include(c => c.Category);
//            }
//        }
//    }
//}
