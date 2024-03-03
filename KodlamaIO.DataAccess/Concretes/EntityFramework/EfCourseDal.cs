using KodlamaIO.Core.DataAccess.EntityFramework;
using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, KodlamaIOContext>, ICourseDal
    {
    }
}
