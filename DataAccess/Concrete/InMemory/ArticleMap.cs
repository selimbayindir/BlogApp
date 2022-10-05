using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.InMemory
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            //builder.Property(x=>x.Title).HasMaxLength(150); 
            //builder.Property(x=>x.Title).IsRequired(false);
            builder.HasData(
                new Article
                {
                    id = Guid.NewGuid(),
                    Title = "ASP.Net Core",
                    Content = "Programlama, bilgisayar sistemlerini kontrol etmemiz için süper güçler sağlayan bir alandır. Uçaklarda, trafik kontrolünde, robotlarda, sürücüsüz arabalarda, web sitelerinde, mobil uygulamalarda ve birçok alanda kullanılabilir.\r\n\r\nHer gün değişen yeni teknolojilerden ve güncel bilgilerden haberdar olmak oldukça zor. Yazılım blogları, son yenilikleri takip etmek, diğer geliştiricilerle iletişim kurmak ve farklı bakış açıları kazanmak için değerli bir kaynaktır.\r\n\r\nİçeriğin aşırı fazla olduğu bir dönemdeyken, en güvenilir ve kaliteli içerik paylaşımı yapan geliştirici bloglarına denk gelmeniz biraz araştırma gerektiriyor.",
                    ViewCount = 1,
                    CategoryId = Guid.Parse("AE308698-B82B-4587-8B9F-BA4D084FF0D0"),
                    ImageId = Guid.Parse("5F57C751-F9E7-4F13-93FF-FF436061268D"),
                    Category = new Category
                    {
                        id = Guid.Parse("AE308698-B82B-4587-8B9F-BA4D084FF0D0"),
                        Name = "Asp.Net Core",
                        CreatedBy = "AdminTest",
                        CreatedDate = DateTime.Now,
                        IsActive = false
                    },
                    Image = new Image
                    {
                        id = Guid.Parse("5F57C751-F9E7-4F13-93FF-FF436061268D"),
                        FileName = "images/testimage",
                        FileType = "jpg",
                        CreatedBy = "AdminTest",
                        CreatedDate = DateTime.Now,
                        IsActive = false
                    },
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now
                },/*2.Makale*/
                                new Article
                                {
                                    id = Guid.NewGuid(),
                                    Title = "ASP.Net Core",
                                    Content = "Programlama, bilgisayar sistemlerini kontrol etmemiz için süper güçler sağlayan bir alandır. Uçaklarda, trafik kontrolünde, robotlarda, sürücüsüz arabalarda, web sitelerinde, mobil uygulamalarda ve birçok alanda kullanılabilir.\r\n\r\nHer gün değişen yeni teknolojilerden ve güncel bilgilerden haberdar olmak oldukça zor. Yazılım blogları, son yenilikleri takip etmek, diğer geliştiricilerle iletişim kurmak ve farklı bakış açıları kazanmak için değerli bir kaynaktır.İçeriğin aşırı fazla olduğu bir dönemdeyken, en güvenilir ve kaliteli içerik paylaşımı yapan geliştirici bloglarına denk gelmeniz biraz araştırma gerektiriyor.",
                                    ViewCount = 1,
                                    CategoryId = Guid.Parse("5325FAD6-36AC-4E47-99E1-89AC5A1F6A3B"),
                                    ImageId = Guid.Parse("5739DE3E-56B6-450E-A031-54672B449D08"),
                                    Category = new Category
                                    {
                                        id = Guid.Parse("5325FAD6-36AC-4E47-99E1-89AC5A1F6A3B"),
                                        Name = "Asp.Net Core",
                                        CreatedBy = "AdminTest",
                                        CreatedDate = DateTime.Now,
                                        IsActive = false
                                    },
                                    Image = new Image
                                    {
                                        id = Guid.Parse("5739DE3E-56B6-450E-A031-54672B449D08"),
                                        FileName = "images/testimage",
                                        FileType = "jpg",
                                        CreatedBy = "AdminTest",
                                        CreatedDate = DateTime.Now,
                                        IsActive = false
                                    },
                                    CreatedBy = "Admin Test",
                                    CreatedDate = DateTime.Now
                                }
                        );
        }
    }
}
