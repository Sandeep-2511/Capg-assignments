using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPIProddet.Models
{
    public partial class db1Context : DbContext
    {
        public db1Context()
        {
        }

        public db1Context(DbContextOptions<db1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorynew> Categorynew { get; set; }
        public virtual DbSet<Coursedet> Coursedet { get; set; }
        public virtual DbSet<CustDet> CustDet { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Staffdet> Staffdet { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Studentdet> Studentdet { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SANDEEP-POTDUKH\\SQLEXPRESS;Initial Catalog=db1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorynew>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__category__D837D05F612782E8");

                entity.ToTable("categorynew");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Coursedet>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__coursede__D837D05F899442DD");

                entity.ToTable("coursedet");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Cduration)
                    .HasColumnName("cduration")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cfee)
                    .HasColumnName("cfee")
                    .HasColumnType("money");

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustDet>(entity =>
            {
                entity.HasKey(e => e.Pcode)
                    .HasName("PK__CustDet__9F96D7D99EE853C4");

                entity.Property(e => e.Pcode).ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pdesc)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Unitprice).HasColumnType("money");
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__dept__D877D2161626AF6E");

                entity.ToTable("dept");

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Dloc)
                    .HasColumnName("dloc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dname)
                    .HasColumnName("dname")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__employee__D9509F6D02DDBBEC");

                entity.ToTable("employee");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Edesig)
                    .HasColumnName("edesig")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Esal)
                    .HasColumnName("esal")
                    .HasColumnType("money");

                entity.Property(e => e.ReportingTo).HasColumnName("reporting_to");

                entity.HasOne(d => d.D)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Did)
                    .HasConstraintName("FK__employee__did__29572725");
            });

            modelBuilder.Entity<Marks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("marks");

                entity.Property(e => e.Marks1).HasColumnName("marks");

                entity.Property(e => e.Strollno).HasColumnName("strollno");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__product__DD37D91AB4C54C2C");

                entity.ToTable("product");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Pdesc)
                    .HasColumnName("pdesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Pprice)
                    .HasColumnName("pprice")
                    .HasColumnType("money");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("FK__product__cid__398D8EEE");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Productname)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Staffdet>(entity =>
            {
                entity.HasKey(e => e.Regno);

                entity.ToTable("staffdet");

                entity.Property(e => e.Regno).HasColumnName("regno");

                entity.Property(e => e.Smailid).HasColumnName("smailid");

                entity.Property(e => e.Sname).HasColumnName("sname");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Regno);

                entity.ToTable("student");

                entity.Property(e => e.Regno).HasColumnName("regno");

                entity.Property(e => e.Smailid).HasColumnName("smailid");

                entity.Property(e => e.Sname).HasColumnName("sname");
            });

            modelBuilder.Entity<Studentdet>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__studentd__DDDFDD36448C19A8");

                entity.ToTable("studentdet");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Saddr)
                    .HasColumnName("saddr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Semailid)
                    .HasColumnName("semailid")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Studentdet)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("FK__studentdet__cid__2E1BDC42");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("students");

                entity.Property(e => e.Stname).HasColumnName("stname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
