using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShareImageSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareImageSolution.Data
{
    public class ShareImageDbContext :DbContext
    {
        public ShareImageDbContext(DbContextOptions<ShareImageDbContext> options)
                : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //RelationShips
            modelBuilder.Entity<Image>()
                .HasOne(p => p.Category)
                .WithMany(p => p.Images)
                .HasForeignKey(p => p.CategoryId);

            //Data Seeding
            modelBuilder.Entity<Category>().HasData(
                  new Category
                  {
                      CategoryId = 1,
                      NameCategory = "Thiên Nhiên",
                      Suggesstion = "Nhiều hơn về thiên nhiên"
                  },
                  new Category
                  {
                      CategoryId = 2,
                      NameCategory = "Động vật",
                      Suggesstion = "Nhiều hơn về động vật"
                  },
                  new Category
                  {
                      CategoryId = 3,
                      NameCategory = "Phong Cảnh",
                      Suggesstion = "Nhiều hơn về phong cảnh"
                  },
                  new Category
                  {
                      CategoryId = 4,
                      NameCategory = "Vũ Trụ",
                      Suggesstion = "Nhiều hơn về vũ trụ"
                  }
                );
            modelBuilder.Entity<Image>().HasData(
                 new Image
                 {
                     ImageId = 1,
                     Alt = "Ảnh Cáo Tuyết Trắng",
                     DateCreated = DateTime.Now,
                     Size = "400x300",
                     Path = "/Images/ImageForDetail/CaoTuyet.jpg",
                     Type = "jpg",
                     Description = "Con cáo tuyết đang nằm trên tuyết",
                     DownLoad = 50,
                     View = 100,
                     CategoryId = 2
                 },
                 new Image
                 {
                     ImageId = 2,
                     Alt = "Ảnh Con Bướm Xuân",
                     DateCreated = DateTime.Now,
                     Size = "400x300",
                     Path = "/Images/ImageForDetail/butterfly.jpg",
                     Type = "jpg",
                     Description = "Con bướm vơn vởn cảnh hoa",
                     DownLoad = 50,
                     View = 100,
                    CategoryId = 2
                 },
                  new Image
                  {
                      ImageId = 3,
                      Alt = "Ảnh Con Chim Đậu Cành Hoa ",
                      DateCreated = DateTime.Now,
                      Size = "400x300",
                      Path = "/Images/ImageForDetail/ConChim.jpg",
                      Type = "jpg",
                      Description = "Con đang đậu trên cành hoa vào mùa xuân",
                      DownLoad = 50,
                      View = 100,
                      CategoryId =2
                  },
                    new Image
                    {
                      ImageId = 4,
                      Alt = "Ảnh Đỉnh Núi Thiên Nhiên",
                      DateCreated = DateTime.Now,
                      Size = "400x300",
                      Path = "/Images/ImageForDetail/DinhNui.png",
                      Type = "jpg",
                      Description = "Đỉnh núi cao thật đẹp, sự sáng tạo của tự nhiên",
                      DownLoad = 50,
                      View = 100,
                      CategoryId = 3
                    },
                 new Image
                 {
                     ImageId = 5,
                     Alt = "Ảnh Phong Cảnh Thiên Nhiên",
                     DateCreated = DateTime.Now,
                     Size = "400x300",
                     Path = "/Images/ImageForDetail/landscape.jpg",
                     Type = "jpg",
                     Description = "Phong cảnh thiên nhiên vào ban đêm, cây khô dưới ánh trăng",
                     DownLoad = 50,
                     View = 100,
                     CategoryId = 3
                 },
                  new Image
                  {
                      ImageId = 6,
                      Alt = "Ảnh Thiên Hà",
                      DateCreated = DateTime.Now,
                      Size = "400x300",
                      Path = "/Images/ImageForDetail/galaxy.jpg",
                      Type = "jpg",
                      Description = "Sự vẻ đẹp của vụ trụ thật là kỳ diệu",
                      DownLoad = 50,
                      View = 100,
                      CategoryId = 4
                  },
                  new Image
                  {
                      ImageId = 7,
                      Alt = "Ảnh Rừng Cây Âm U",
                      DateCreated = DateTime.Now,
                      Size = "400x300",
                      Path = "/Images/ImageForDetail/RungCayAmU.jpg",
                      Type = "jpg",
                      Description = "Rừng cây âm u thiếu ánh sáng",
                      DownLoad = 50,
                      View = 100,
                      CategoryId = 1
                  },
                   new Image
                   {
                       ImageId = 8,
                       Alt = "Ảnh Rừng Cây Màu Vàng",
                       DateCreated = DateTime.Now,
                       Size = "400x300",
                       Path = "/Images/ImageForDetail/RungCayMauVang.jpg",
                       Type = "jpg",
                       Description = "Rừng cây vào mua thu",
                       DownLoad = 50,
                       View = 100,
                       CategoryId = 1
                   },
                    new Image
                    {
                        ImageId = 9,
                        Alt = "Ảnh Rừng Cây Đầy Sức Sống",
                        DateCreated = DateTime.Now,
                        Size = "400x300",
                        Path = "/Images/ImageForDetail/RungCaySucSong.jpg",
                        Type = "jpg",
                        Description = "Lối đi vào rừng cây đầy sức sống",
                        DownLoad = 50,
                        View = 100,
                        CategoryId = 1
                    },
                     new Image
                     {
                         ImageId = 10,
                         Alt = "Ảnh Hoàng Hôn",
                         DateCreated = DateTime.Now,
                         Size = "400x300",
                         Path = "/Images/ImageForDetail/sunset.jpg",
                         Type = "jpg",
                         Description = "Hoàng hôn trên đồi núi",
                         DownLoad = 50,
                         View = 100,
                         CategoryId = 1
                     },
                      new Image
                      {
                          ImageId = 11,
                          Alt = "Ảnh Tảng Băng",
                          DateCreated = DateTime.Now,
                          Size = "400x300",
                          Path = "/Images/ImageForDetail/tangbang.jpg",
                          Type = "jpg",
                          Description = "Tảng băng nổi trên biển",
                          DownLoad = 50,
                          View = 100,
                          CategoryId = 1
                      },
                       new Image
                       {
                           ImageId = 12,
                           Alt = "Ảnh Phong Cảnh Cổ Xưa",
                           DateCreated = DateTime.Now,
                           Size = "400x300",
                           Path = "/Images/ImageForDetail/MayMu.jpg",
                           Type = "jpg",
                           Description = "Bức tranh phong cảnh sơn mài thật đẹp",
                           DownLoad = 50,
                           View = 100,
                           CategoryId = 2
                       }
                );
        }

        public DbSet<Image> Image { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
