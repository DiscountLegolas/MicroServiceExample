﻿// <auto-generated />
using Blazor.Data.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blazor.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Blazor.Data.EFCore.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductCode = "A1",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/1/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 2,
                            ProductCode = "A2",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/2/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 3,
                            ProductCode = "A3",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/3/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 4,
                            ProductCode = "A4",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/4/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 5,
                            ProductCode = "A5",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/5/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 6,
                            ProductCode = "A6",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/6/thumbnail.png"
                        },
                        new
                        {
                            ProductId = 7,
                            ProductCode = "A7",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/7/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 8,
                            ProductCode = "A8",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/8/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 9,
                            ProductCode = "A9",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/9/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 10,
                            ProductCode = "A10",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/10/thumbnail.jpeg"
                        },
                        new
                        {
                            ProductId = 11,
                            ProductCode = "A11",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/11/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 12,
                            ProductCode = "A12",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/12/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 13,
                            ProductCode = "A13",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/13/thumbnail.webp"
                        },
                        new
                        {
                            ProductId = 14,
                            ProductCode = "A14",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/14/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 15,
                            ProductCode = "A15",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/15/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 16,
                            ProductCode = "A16",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/16/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 17,
                            ProductCode = "A17",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/17/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 18,
                            ProductCode = "A18",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/18/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 19,
                            ProductCode = "A19",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/19/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 20,
                            ProductCode = "A20",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/20/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 21,
                            ProductCode = "A21",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/21/thumbnail.png"
                        },
                        new
                        {
                            ProductId = 22,
                            ProductCode = "A22",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/22/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 23,
                            ProductCode = "A23",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/23/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 24,
                            ProductCode = "A24",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/24/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 25,
                            ProductCode = "A25",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/25/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 26,
                            ProductCode = "A26",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/26/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 27,
                            ProductCode = "A27",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/27/thumbnail.webp"
                        },
                        new
                        {
                            ProductId = 28,
                            ProductCode = "A28",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/28/thumbnail.jpg"
                        },
                        new
                        {
                            ProductId = 29,
                            ProductCode = "A29",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/29/thumbnail.webp"
                        },
                        new
                        {
                            ProductId = 30,
                            ProductCode = "A30",
                            ProductImageUrl = "https://dummyjson.com/image/i/products/30/thumbnail.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
