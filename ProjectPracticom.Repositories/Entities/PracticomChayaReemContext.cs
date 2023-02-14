using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
//using ProjectPracticom.Repositories.Interfaces;

//namespace ProjectPracticom.Repositories.Entities;

//public partial class PracticomChayaReemContext : DbContext,IContext
//{
//    public PracticomChayaReemContext()
//    {
//    }

//    public PracticomChayaReemContext(DbContextOptions<PracticomChayaReemContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<Child> Children { get; set; }

//    public virtual DbSet<User> Users { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=sqlsrv;Initial Catalog=_Practicom_ChayaReem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Child>(entity =>
//        {
//            entity.HasKey(e => e.NumChild).HasName("PK_Children");

//            entity.ToTable("Child");

//            entity.Property(e => e.DateOfBirth).HasColumnType("date");
//            entity.Property(e => e.FullName).HasMaxLength(50);

//            entity.HasOne(d => d.NunParentNavigation).WithMany(p => p.Children)
//                .HasForeignKey(d => d.NunParent)
//                .HasConstraintName("FK_Child_User");
//        });

//        modelBuilder.Entity<User>(entity =>
//        {
//            entity.HasKey(e => e.NumUser).HasName("PK_Users");

//            entity.ToTable("User");

//            entity.Property(e => e.DateOfBirth).HasColumnType("date");
//            entity.Property(e => e.FirstName).HasMaxLength(50);
//            entity.Property(e => e.Hmo)
//                .HasMaxLength(50)
//                .HasColumnName("HMO");
//            entity.Property(e => e.IdUser).HasMaxLength(50);
//            entity.Property(e => e.LastName).HasMaxLength(50);
//            entity.Property(e => e.MaleOrFamle).HasMaxLength(50);
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
