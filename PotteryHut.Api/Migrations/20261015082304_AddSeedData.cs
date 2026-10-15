using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PotteryHut.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, null, "Muggar", "muggar" },
                    { 2, null, "Skålar", "skalar" },
                    { 3, null, "Tallrikar", "tallrikar" },
                    { 4, null, "Vaser", "vaser" },
                    { 5, null, "Serveringsfat", "serveringsfat" },
                    { 6, null, "Serveringsskålar", "serveringsskalar" },
                    { 7, null, "Mud Collection", "mud-collection" },
                    { 8, null, "Sand Collection", "sand-collection" },
                    { 9, null, "Grass Collection", "grass-collection" },
                    { 10, null, "Ocean Collection", "ocean-collection" },
                    { 11, null, "Cloud Collection", "cloud-collection" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "Name", "Price", "UrlSlug" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord vas ur Mud Collection, en vacker detalj till hemmet.", "/products/mud-vase.png", "Mud Vas", 249m, "mud-vas" },
                    { 2, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord skål ur Mud Collection, mångsidig för både mat och dekor.", "/products/mud-bowl.png", "Mud Skål", 149m, "mud-skal" },
                    { 3, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord mugg ur Mud Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.", "/products/mud-mug.png", "Mud Mugg", 179m, "mud-mugg" },
                    { 4, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjort serveringsfat ur Mud Collection, perfekt för middagsbjudningar och dekor.", "/products/mud-serving-bowl-small.png", "Mud Serveringsfat Small", 299m, "mud-serveringsfat-small" },
                    { 5, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjort serveringsfat ur Mud Collection, perfekt för middagsbjudningar och dekor.", "/products/mud-serving-bowl-large.png", "Mud Serveringsfat Large", 499m, "mud-serveringsfat-large" },
                    { 6, new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord tallrik ur Mud Collection, med en unik yta där ingen är den andra lik.", "/products/mud-plate.png", "Mud Tallrik", 279m, "mud-tallrik" },
                    { 7, new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord mugg ur Sand Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.", "/products/sand-mug.png", "Sand Mugg", 259m, "sand-mugg" },
                    { 8, new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord skål ur Sand Collection, mångsidig för både mat och dekor.", "/products/sand-bowl.png", "Sand Skål", 329m, "sand-skal" },
                    { 9, new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord tallrik ur Sand Collection, med en unik yta där ingen är den andra lik.", "/products/sand-plate.png", "Sand Tallrik", 289m, "sand-tallrik" },
                    { 10, new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord vas ur Sand Collection, en vacker detalj till hemmet.", "/products/sand-vase.png", "Sand Vas", 249m, "sand-vas" },
                    { 11, new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjort serveringsfat ur Sand Collection, perfekt för middagsbjudningar och dekor.", "/products/sand-serving-plate.png", "Sand Serveringsfat", 479m, "sand-serveringsfat" },
                    { 12, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord mugg ur Grass Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.", "/products/grass-mug.png", "Grass Mugg", 179m, "grass-mugg" },
                    { 13, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord skål ur Grass Collection, mångsidig för både mat och dekor.", "/products/grass-bowl.png", "Grass Skål", 219m, "grass-skal" },
                    { 14, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord tallrik ur Grass Collection, med en unik yta där ingen är den andra lik.", "/products/grass-plate.png", "Grass Tallrik", 279m, "grass-tallrik" },
                    { 15, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord serveringsskål ur Grass Collection, perfekt för middagsbjudningar och dekor.", "/products/grass-serving-bowl.png", "Grass Serveringsskål", 459m, "grass-serveringsskal" },
                    { 16, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord vas ur Grass Collection, en vacker detalj till hemmet.", "/products/grass-vase.png", "Grass Vas", 279m, "grass-vas" },
                    { 17, new DateTime(2026, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord mugg ur Ocean Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.", "/products/ocean-mug.png", "Ocean Mugg Lång", 289m, "ocean-mugg-lang" },
                    { 18, new DateTime(2026, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord mugg ur Ocean Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.", "/products/ocean-mug-round.png", "Ocean Mugg Rund", 289m, "ocean-mugg-rund" },
                    { 19, new DateTime(2026, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord vas ur Ocean Collection, en vacker detalj till hemmet.", "/products/ocean-vase.png", "Ocean Vas", 649m, "ocean-vas" },
                    { 20, new DateTime(2026, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjort serveringsfat ur Ocean Collection, perfekt för middagsbjudningar och dekor.", "/products/ocean-serving-plate.png", "Ocean Serveringsfat", 549m, "ocean-serveringsfat" },
                    { 21, new DateTime(2026, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord skål ur Ocean Collection, mångsidig för både mat och dekor.", "/products/ocean-bowl.png", "Ocean Skål", 339m, "ocean-skal" },
                    { 22, new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord tallrik ur Ocean Collection, med en unik yta där ingen är den andra lik.", "/products/ocean-plate.png", "Ocean Tallrik", 279m, "ocean-tallrik" },
                    { 23, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord mugg ur Cloud Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.", "/products/cloud-mug.png", "Cloud Mugg", 269m, "cloud-mugg" },
                    { 24, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord skål ur Cloud Collection, mångsidig för både mat och dekor.", "/products/cloud-bowl.png", "Cloud Skål", 319m, "cloud-skal" },
                    { 25, new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord tallrik ur Cloud Collection, med en unik yta där ingen är den andra lik.", "/products/cloud-plate.png", "Cloud Tallrik", 289m, "cloud-tallrik" },
                    { 26, new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjort serveringsfat ur Cloud Collection, perfekt för middagsbjudningar och dekor.", "/products/cloud-serving-plate.png", "Cloud Serveringsfat", 459m, "cloud-serveringsfat" },
                    { 27, new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Handgjord vas ur Cloud Collection, en vacker detalj till hemmet.", "/products/cloud-vase.png", "Cloud Vas", 289m, "cloud-vas" }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 7 },
                    { 1, 12 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 23 },
                    { 2, 2 },
                    { 2, 8 },
                    { 2, 13 },
                    { 2, 21 },
                    { 2, 24 },
                    { 3, 6 },
                    { 3, 9 },
                    { 3, 14 },
                    { 3, 22 },
                    { 3, 25 },
                    { 4, 1 },
                    { 4, 10 },
                    { 4, 16 },
                    { 4, 19 },
                    { 4, 27 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 11 },
                    { 5, 20 },
                    { 5, 26 },
                    { 6, 15 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 9, 12 },
                    { 9, 13 },
                    { 9, 14 },
                    { 9, 15 },
                    { 9, 16 },
                    { 10, 17 },
                    { 10, 18 },
                    { 10, 19 },
                    { 10, 20 },
                    { 10, 21 },
                    { 10, 22 },
                    { 11, 23 },
                    { 11, 24 },
                    { 11, 25 },
                    { 11, 26 },
                    { 11, 27 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 23 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 20 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 10, 18 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 10, 19 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 10, 20 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 10, 21 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 10, 22 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 11, 23 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 11, 24 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 11, 25 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 11, 26 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 11, 27 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
