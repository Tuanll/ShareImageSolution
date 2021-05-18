using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareImageSolution.Migrations
{
    public partial class CreateCategoryAndUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Image");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Image",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "ImageId");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(nullable: true),
                    Suggesstion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ImageInCategory",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageInCategory", x => new { x.ImageId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ImageInCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageInCategory_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "NameCategory", "Suggesstion" },
                values: new object[,]
                {
                    { 1, "Thiên Nhiên", "Nhiều hơn về thiên nhiên" },
                    { 2, "Động vật", "Nhiều hơn về động vật" },
                    { 3, "Phong Cảnh", "Nhiều hơn về phong cảnh" },
                    { 4, "Vũ Trụ", "Nhiều hơn về vũ trụ" }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "ImageId", "Alt", "DateCreated", "Description", "DownLoad", "Path", "Size", "Type", "View" },
                values: new object[,]
                {
                    { 1, "Ảnh Cáo Tuyết Trắng", new DateTime(2021, 5, 15, 14, 42, 41, 450, DateTimeKind.Local).AddTicks(1613), "Con cáo tuyết đang nằm trên tuyết", 50, "/Images/ImageForDetail/CaoTuyet.jpg", "400x300", "jpg", 100 },
                    { 2, "Ảnh Con Bướm Xuân", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9466), "Con bướm vơn vởn cảnh hoa", 50, "/Images/ImageForDetail/butterfly.jpg", "400x300", "jpg", 100 },
                    { 3, "Ảnh Con Chim Đậu Cành Hoa ", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9565), "Con đang đậu trên cành hoa vào mùa xuân", 50, "/Images/ImageForDetail/ConChim.jpg", "400x300", "jpg", 100 },
                    { 4, "Ảnh Đỉnh Núi Thiên Nhiên", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9571), "Đỉnh núi cao thật đẹp, sự sáng tạo của tự nhiên", 50, "/Images/ImageForDetail/DinhNui.png", "400x300", "jpg", 100 },
                    { 5, "Ảnh Phong Cảnh Thiên Nhiên", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9574), "Phong cảnh thiên nhiên vào ban đêm, cây khô dưới ánh trăng", 50, "/Images/ImageForDetail/landscape.jpg", "400x300", "jpg", 100 },
                    { 6, "Ảnh Thiên Hà", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9577), "Sự vẻ đẹp của vụ trụ thật là kỳ diệu", 50, "/Images/ImageForDetail/galaxy.jpg", "400x300", "jpg", 100 },
                    { 7, "Ảnh Rừng Cây Âm U", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9579), "Rừng cây âm u thiếu ánh sáng", 50, "/Images/ImageForDetail/RungCayAmU.jpg", "400x300", "jpg", 100 },
                    { 8, "Ảnh Rừng Cây Màu Vàng", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9582), "Rừng cây vào mua thu", 50, "/Images/ImageForDetail/RungCayMauVang.jpg", "400x300", "jpg", 100 },
                    { 9, "Ảnh Rừng Cây Đầy Sức Sống", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9584), "Lối đi vào rừng cây đầy sức sống", 50, "/Images/ImageForDetail/RungCaySucSong.jpg", "400x300", "jpg", 100 },
                    { 10, "Ảnh Hoàng Hôn", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9587), "Hoàng hôn trên đồi núi", 50, "/Images/ImageForDetail/sunset.jpg", "400x300", "jpg", 100 },
                    { 11, "Ảnh Tảng Băng", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9590), "Tảng băng nổi trên biển", 50, "/Images/ImageForDetail/tangbang.jpg", "400x300", "jpg", 100 },
                    { 12, "Ảnh Phong Cảnh Cổ Xưa", new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9593), "Bức tranh phong cảnh sơn mài thật đẹp", 50, "/Images/ImageForDetail/MayMu.jpg", "400x300", "jpg", 100 }
                });

            migrationBuilder.InsertData(
                table: "ImageInCategory",
                columns: new[] { "ImageId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 2 },
                    { 7, 4 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageInCategory_CategoryId",
                table: "ImageInCategory",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageInCategory");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Image");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "Alt", "DateCreated", "Description", "DownLoad", "Path", "Size", "Type", "View" },
                values: new object[,]
                {
                    { 1, "Ảnh Cáo Tuyết Trắng", new DateTime(2021, 5, 14, 18, 15, 8, 292, DateTimeKind.Local).AddTicks(5651), "Con cáo tuyết đang nằm trên tuyết", 50, "/Images/ImageForDetail/CaoTuyet.jpg", "400x300", "jpg", 100 },
                    { 2, "Ảnh Con Bướm Xuân", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3853), "Con bướm vơn vởn cảnh hoa", 50, "/Images/ImageForDetail/butterfly.jpg", "400x300", "jpg", 100 },
                    { 3, "Ảnh Con Chim Đậu Cành Hoa ", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3957), "Con đang đậu trên cành hoa vào mùa xuân", 50, "/Images/ImageForDetail/ConChim.jpg", "400x300", "jpg", 100 },
                    { 4, "Ảnh Đỉnh Núi Thiên Nhiên", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3962), "Đỉnh núi cao thật đẹp, sự sáng tạo của tự nhiên", 50, "/Images/ImageForDetail/DinhNui.png", "400x300", "jpg", 100 },
                    { 5, "Ảnh Phong Cảnh Thiên Nhiên", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3967), "Phong cảnh thiên nhiên vào ban đêm, cây khô dưới ánh trăng", 50, "/Images/ImageForDetail/landscape.jpg", "400x300", "jpg", 100 },
                    { 6, "Ảnh Thiên Hà", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3969), "Sự vẻ đẹp của vụ trụ thật là kỳ diệu", 50, "/Images/ImageForDetail/galaxy.jpg", "400x300", "jpg", 100 },
                    { 7, "Ảnh Rừng Cây Âm U", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3973), "Rừng cây âm u thiếu ánh sáng", 50, "/Images/ImageForDetail/RungCayAmU.jpg", "400x300", "jpg", 100 },
                    { 8, "Ảnh Rừng Cây Màu Vàng", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3976), "Rừng cây vào mua thu", 50, "/Images/ImageForDetail/RungCayMauVang.jpg", "400x300", "jpg", 100 },
                    { 9, "Ảnh Rừng Cây Đầy Sức Sống", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3978), "Lối đi vào rừng cây đầy sức sống", 50, "/Images/ImageForDetail/RungCaySucSong.jpg", "400x300", "jpg", 100 },
                    { 10, "Ảnh Hoàng Hôn", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3981), "Hoàng hôn trên đồi núi", 50, "/Images/ImageForDetail/sunset.jpg", "400x300", "jpg", 100 },
                    { 11, "Ảnh Tảng Băng", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3983), "Tảng băng nổi trên biển", 50, "/Images/ImageForDetail/tangbang.jpg", "400x300", "jpg", 100 },
                    { 12, "Ảnh Phong Cảnh Cổ Xưa", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3986), "Bức tranh phong cảnh sơn mài thật đẹp", 50, "/Images/ImageForDetail/MayMu.jpg", "400x300", "jpg", 100 }
                });
        }
    }
}
