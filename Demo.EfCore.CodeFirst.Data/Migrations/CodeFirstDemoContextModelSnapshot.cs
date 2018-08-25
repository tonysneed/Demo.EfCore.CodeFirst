﻿// <auto-generated />
using Demo.EfCore.CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.EfCore.CodeFirst.Data.Migrations
{
    [DbContext(typeof(CodeFirstDemoContext))]
    partial class CodeFirstDemoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.EfCore.CodeFirst.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, ProductName = "Chai", UnitPrice = 1m },
                        new { Id = 2, ProductName = "Chang", UnitPrice = 2m },
                        new { Id = 3, ProductName = "Cappuccino", UnitPrice = 3m }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
