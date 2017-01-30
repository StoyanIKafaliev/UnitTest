using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_And_Courses.Contracts
{
    public interface ICourse : ICourseFunction
    {
        ICollection<IStudent> Students { get; }
    }
}
