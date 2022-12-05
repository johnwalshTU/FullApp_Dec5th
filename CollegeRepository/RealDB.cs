using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRepository
{
    public class RealDB : ICollegeRepo
    {
        CollegeDBContext _db = default!;

        public RealDB()
        {
            //_db = new CollegeDBContext()
        }



        // ToDo Methods Interface methods
    }
}
