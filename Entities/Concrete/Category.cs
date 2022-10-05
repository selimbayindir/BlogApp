using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category:Common
    {
        public String Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
