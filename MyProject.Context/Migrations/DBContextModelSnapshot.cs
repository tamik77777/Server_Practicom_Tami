// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyProject.Context;

#nullable disable

namespace MyProject.Context.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyProject.Repositories.Entities.Children", b =>
                {
                    b.Property<int>("IdChild")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdChild"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdParent")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TzChild")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdChild");

                    b.HasIndex("IdParent");

                    b.ToTable("Childrens");
                });

            modelBuilder.Entity("MyProject.Repositories.Entities.Parent", b =>
                {
                    b.Property<int>("IdParent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdParent"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hospital")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.Property<string>("Tz")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdParent");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("MyProject.Repositories.Entities.Children", b =>
                {
                    b.HasOne("MyProject.Repositories.Entities.Parent", "Parent")
                        .WithMany()
                        .HasForeignKey("IdParent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });
#pragma warning restore 612, 618
        }
    }
}
