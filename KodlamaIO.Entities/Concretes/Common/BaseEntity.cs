using KodlamaIO.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Domain.Entities.Common;

public class BaseEntity : IEntity
{
    public int Id { get; set; }
}
