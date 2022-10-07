using Core.DataAccess.Repositories.Concrete;
using DataAccess.Abstract;
using DataAccess.ConfigurationsJson;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal:BaseRepository<Article,BlogContext>,IArticleDal
    {
    }
}
