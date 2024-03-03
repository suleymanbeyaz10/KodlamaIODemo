using RickAndMorty.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Entities.Concretes
{
    public class Instructor : BaseEntity
    {

        public string FirstName { get; set; }
        public string? LastName { get; set; }
        //public Course[] Courses { get; set; }
    }
}
