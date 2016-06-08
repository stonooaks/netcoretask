using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using netcoretask;

namespace netcoretask.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20160608143740_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20896")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("netcoretask.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contact");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("netcoretask.Task", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CompletedDate");

                    b.Property<int?>("CustomerID");

                    b.Property<string>("Description");

                    b.Property<int?>("TypeID");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TypeID");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("netcoretask.TaskType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("TaskType");
                });

            modelBuilder.Entity("netcoretask.Task", b =>
                {
                    b.HasOne("netcoretask.Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.HasOne("netcoretask.TaskType")
                        .WithMany()
                        .HasForeignKey("TypeID");
                });
        }
    }
}
