using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entities.Concrete
{
    public class Article:Common
    {
        public Article()
        {

        }
        public Article(string title, string content, int viewCount, Guid categoryId, Category category, Guid ımageId, Image ımage)
        {
            Title = title;
            Content = content;
            ViewCount = viewCount;
            CategoryId = categoryId;
            Category = category;
            ImageId = ımageId;
            Image = ımage;
        }

        public String Title { get; set; }
        public String Content { get; set; }
        public int ViewCount { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}
