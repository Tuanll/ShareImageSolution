using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareImageSolution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alt = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    View = table.Column<int>(nullable: false),
                    DownLoad = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "Alt", "DateCreated", "Description", "DownLoad", "Path", "Size", "Type", "View" },
                values: new object[,]
                {
                    { 1, "Ảnh Cáo Tuyết Trắng", new DateTime(2021, 5, 13, 21, 39, 46, 527, DateTimeKind.Local).AddTicks(8203), "Con cái tuyết đang nằm trên tuyết", 50, "/Images/ImageForDetail/CaoTuyet.jpg", "400x300", "jpg", 100 },
                    { 2, "Ảnh Cáo Tuyết Trắng", new DateTime(2021, 5, 13, 21, 39, 46, 529, DateTimeKind.Local).AddTicks(5233), "Con cái tuyết đang nằm trên tuyết", 50, "/Images/ImageForDetail/CaoTuyet.jpg", "400x300", "jpg", 100 },
                    { 3, "Ảnh Cực Quang ở Nam Cực", new DateTime(2021, 5, 13, 21, 39, 46, 529, DateTimeKind.Local).AddTicks(5336), "Cực quang ở nam bán cầu, màu sắc trên bầu trời", 50, "/Images/ImageForDetail/cucquang.jpg", "400x300", "jpg", 100 },
                    { 4, "Ảnh Chim Đậu Cành Hoa", new DateTime(2021, 5, 13, 21, 39, 46, 529, DateTimeKind.Local).AddTicks(5342), "Con chim đang đậu trên cành hoa vào mùa xuân", 50, "/Images/ImageForDetail/CaoTuyet.jpg", "400x300", "jpg", 100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}
