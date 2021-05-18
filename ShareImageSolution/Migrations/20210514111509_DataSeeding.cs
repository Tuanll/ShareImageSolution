using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareImageSolution.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Description" },
                values: new object[] { new DateTime(2021, 5, 14, 18, 15, 8, 292, DateTimeKind.Local).AddTicks(5651), "Con cáo tuyết đang nằm trên tuyết" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Alt", "DateCreated", "Description", "Path" },
                values: new object[] { "Ảnh Con Bướm Xuân", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3853), "Con bướm vơn vởn cảnh hoa", "/Images/ImageForDetail/butterfly.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Alt", "DateCreated", "Description", "Path" },
                values: new object[] { "Ảnh Con Chim Đậu Cành Hoa ", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3957), "Con đang đậu trên cành hoa vào mùa xuân", "/Images/ImageForDetail/ConChim.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Alt", "DateCreated", "Description", "Path" },
                values: new object[] { "Ảnh Đỉnh Núi Thiên Nhiên", new DateTime(2021, 5, 14, 18, 15, 8, 294, DateTimeKind.Local).AddTicks(3962), "Đỉnh núi cao thật đẹp, sự sáng tạo của tự nhiên", "/Images/ImageForDetail/DinhNui.png" });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "Alt", "DateCreated", "Description", "DownLoad", "Path", "Size", "Type", "View" },
                values: new object[,]
                {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Description" },
                values: new object[] { new DateTime(2021, 5, 13, 21, 39, 46, 527, DateTimeKind.Local).AddTicks(8203), "Con cái tuyết đang nằm trên tuyết" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Alt", "DateCreated", "Description", "Path" },
                values: new object[] { "Ảnh Cáo Tuyết Trắng", new DateTime(2021, 5, 13, 21, 39, 46, 529, DateTimeKind.Local).AddTicks(5233), "Con cái tuyết đang nằm trên tuyết", "/Images/ImageForDetail/CaoTuyet.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Alt", "DateCreated", "Description", "Path" },
                values: new object[] { "Ảnh Cực Quang ở Nam Cực", new DateTime(2021, 5, 13, 21, 39, 46, 529, DateTimeKind.Local).AddTicks(5336), "Cực quang ở nam bán cầu, màu sắc trên bầu trời", "/Images/ImageForDetail/cucquang.jpg" });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Alt", "DateCreated", "Description", "Path" },
                values: new object[] { "Ảnh Chim Đậu Cành Hoa", new DateTime(2021, 5, 13, 21, 39, 46, 529, DateTimeKind.Local).AddTicks(5342), "Con chim đang đậu trên cành hoa vào mùa xuân", "/Images/ImageForDetail/CaoTuyet.jpg" });
        }
    }
}
