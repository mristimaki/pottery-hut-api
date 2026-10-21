using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PotteryHut.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddTropicalCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name", "UrlSlug" },
                values: new object[] { 12, null, "Tropical Collection", "tropical-collection" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "Name", "Price", "UrlSlug" },
                values: new object[,]
                {
                    { 28, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord mugg ur Tropical Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.", "/products/tropical-mug.png", "Tropical Mugg", 279m, "tropical-mugg" },
                    { 29, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord skål ur Tropical Collection, mångsidig för både mat och dekor.", "/products/tropical-bowl.png", "Tropical Skål", 339m, "tropical-skal" },
                    { 30, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjort serveringsfat ur Tropical Collection, perfekt för middagsbjudningar och dekor.", "/products/tropical-serving-plate.png", "Tropical Serveringsfat", 579m, "tropical-serveringsfat" },
                    { 31, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord serveringsskål ur Tropical Collection, perfekt för middagsbjudningar och dekor.", "/products/tropical-serving-bowl.png", "Tropical Serveringsskål", 459m, "tropical-serveringsskal" },
                    { 32, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord tallrik ur Tropical Collection, med en unik yta där ingen är den andra lik.", "/products/tropical-plate.png", "Tropical Tallrik", 299m, "tropical-tallrik" }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 28 },
                    { 2, 29 },
                    { 3, 32 },
                    { 5, 30 },
                    { 6, 31 },
                    { 12, 28 },
                    { 12, 29 },
                    { 12, 30 },
                    { 12, 31 },
                    { 12, 32 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 28 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 32 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 30 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 6, 31 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 12, 28 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 12, 29 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 12, 30 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 12, 31 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 12, 32 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);
        }
    }
}
