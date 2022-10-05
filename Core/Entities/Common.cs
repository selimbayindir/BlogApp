using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Common :IEntity
    {

        //public Common()
        //{
        //    id = Guid.NewGuid();
        //    CreatedDate = DateTime.Now;
        //    IsActive = false;
        //}
        public virtual Guid id { get; set; } = Guid.NewGuid();
        public virtual String CreatedBy { get; set; }
        public virtual String? ModifiedBy { get; set; }
        public virtual String? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsActive { get; set; } = false;
    }
}
