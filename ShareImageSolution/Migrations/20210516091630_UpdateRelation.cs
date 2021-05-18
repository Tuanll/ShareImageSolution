using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareImageSolution.Migrations
{
    public partial class UpdateRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageInCategory");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Image",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 1,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 2, new DateTime(2021, 5, 16, 16, 16, 29, 711, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 2, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 3,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 2, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 4,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 3, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 5,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 3, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 6,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 4, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 7,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 1, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 8,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 1, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 9,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 1, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 10,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 1, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 11,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 1, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 12,
                columns: new[] { "CategoryId", "DateCreated" },
                values: new object[] { 2, new DateTime(2021, 5, 16, 16, 16, 29, 713, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.CreateIndex(
                name: "IX_Image_CategoryId",
                table: "Image",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Category_CategoryId",
                table: "Image",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Category_CategoryId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_CategoryId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Image");

            migrationBuilder.CreateTable(
                name: "ImageInCategory",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 450, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "ImageId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 5, 15, 14, 42, 41, 451, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.InsertData(
                table: "ImageInCategory",
                columns: new[] { "ImageId", "CategoryId" },
                values: new object[,]
                {
                    { 12, 1 },
                    { 10, 1 },
                    { 9, 1 },
                    { 8, 1 },
                    { 7, 4 },
                    { 6, 2 },
                    { 5, 3 },
                    { 4, 3 },
                    { 3, 2 },
                    { 2, 2 },
                    { 11, 1 },
                    { 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageInCategory_CategoryId",
                table: "ImageInCategory",
                column: "CategoryId");
        }
    }
}
