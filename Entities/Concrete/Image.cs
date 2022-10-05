using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Image:Common
    {
        public String FileName { get; set; }
        public String FileType { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
