using RickAndMorty.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Entities.Concretes
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string? Description { get; set; }

    }
}
