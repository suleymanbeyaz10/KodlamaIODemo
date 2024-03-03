using KodlamaIO.Core.DataAccess;
using KodlamaIO.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstracts
{
    public interface IInstructorDal : IEntityRepository<Instructor>
    {
    }
}
