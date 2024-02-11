using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace scientific_work
{
    public partial class scientificworkContext : DbContext
    {
        public scientificworkContext()
        {
        }

        public scientificworkContext(DbContextOptions<scientificworkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Conference> Conference { get; set; }
        public virtual DbSet<Publication> Publication { get; set; }
        public virtual DbSet<Sgroup> Sgroup { get; set; }
        public virtual DbSet<StudCnf> StudCnf { get; set; }
        public virtual DbSet<StudPb> StudPb { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<TchrCnf> TchrCnf { get; set; }
        public virtual DbSet<TchrPb> TchrPb { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=scientific work;Username=postgres;Password=belka02");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("category_pkey");

                entity.ToTable("category");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(8);

                entity.Property(e => e.Duration).HasColumnName("duration");
            });

            modelBuilder.Entity<Conference>(entity =>
            {
                entity.HasKey(e => e.IdCnf)
                    .HasName("conference_pkey");

                entity.ToTable("conference");

                entity.Property(e => e.IdCnf)
                    .HasColumnName("id_cnf")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateCnf)
                    .HasColumnName("date_cnf")
                    .HasColumnType("date");

                entity.Property(e => e.NameCnf)
                    .IsRequired()
                    .HasColumnName("name_cnf")
                    .HasMaxLength(256);

                entity.Property(e => e.ThemeCnf)
                    .IsRequired()
                    .HasColumnName("theme_cnf")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Publication>(entity =>
            {
                entity.HasKey(e => e.IdPb)
                    .HasName("publication_pkey");

                entity.ToTable("publication");

                entity.Property(e => e.IdPb)
                    .HasColumnName("id_pb")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DatePb)
                    .HasColumnName("date_pb")
                    .HasColumnType("date");

                entity.Property(e => e.NamePb)
                    .IsRequired()
                    .HasColumnName("name_pb")
                    .HasMaxLength(256);

                entity.Property(e => e.ThemePb)
                    .IsRequired()
                    .HasColumnName("theme_pb")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Sgroup>(entity =>
            {
                entity.HasKey(e => e.IdGroup)
                    .HasName("sgroup_pkey");

                entity.ToTable("sgroup");

                entity.Property(e => e.IdGroup)
                    .HasColumnName("id_group")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.NameMngr)
                    .IsRequired()
                    .HasColumnName("name_mngr")
                    .HasMaxLength(40);

                entity.Property(e => e.Thematics)
                    .IsRequired()
                    .HasColumnName("thematics")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<StudCnf>(entity =>
            {
                entity.HasKey(e => new { e.IdStud, e.IdCnf })
                    .HasName("stud_cnf_pkey");

                entity.ToTable("stud_cnf");

                entity.Property(e => e.IdStud).HasColumnName("id_stud");

                entity.Property(e => e.IdCnf).HasColumnName("id_cnf");

                entity.HasOne(d => d.IdCnfNavigation)
                    .WithMany(p => p.StudCnf)
                    .HasForeignKey(d => d.IdCnf)
                    .HasConstraintName("stud_cnf_id_cnf_fkey");

                entity.HasOne(d => d.IdStudNavigation)
                    .WithMany(p => p.StudCnf)
                    .HasForeignKey(d => d.IdStud)
                    .HasConstraintName("stud_cnf_id_stud_fkey");
            });

            modelBuilder.Entity<StudPb>(entity =>
            {
                entity.HasKey(e => new { e.IdStud, e.IdPb })
                    .HasName("stud_pb_pkey");

                entity.ToTable("stud_pb");

                entity.Property(e => e.IdStud).HasColumnName("id_stud");

                entity.Property(e => e.IdPb).HasColumnName("id_pb");

                entity.HasOne(d => d.IdPbNavigation)
                    .WithMany(p => p.StudPb)
                    .HasForeignKey(d => d.IdPb)
                    .HasConstraintName("stud_pb_id_pb_fkey");

                entity.HasOne(d => d.IdStudNavigation)
                    .WithMany(p => p.StudPb)
                    .HasForeignKey(d => d.IdStud)
                    .HasConstraintName("stud_pb_id_stud_fkey");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IdStud)
                    .HasName("student_pkey");

                entity.ToTable("student");

                entity.Property(e => e.IdStud)
                    .HasColumnName("id_stud")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(8);

                entity.Property(e => e.Course).HasColumnName("course");

                entity.Property(e => e.IdTchr).HasColumnName("id_tchr");

                entity.Property(e => e.NameStud)
                    .IsRequired()
                    .HasColumnName("name_stud")
                    .HasMaxLength(40);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.Yr).HasColumnName("yr");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("student_category_fkey");

                entity.HasOne(d => d.IdTchrNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.IdTchr)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("student_id_tchr_fkey");
            });

            modelBuilder.Entity<TchrCnf>(entity =>
            {
                entity.HasKey(e => new { e.IdTchr, e.IdCnf })
                    .HasName("tchr_cnf_pkey");

                entity.ToTable("tchr_cnf");

                entity.Property(e => e.IdTchr).HasColumnName("id_tchr");

                entity.Property(e => e.IdCnf).HasColumnName("id_cnf");

                entity.HasOne(d => d.IdCnfNavigation)
                    .WithMany(p => p.TchrCnf)
                    .HasForeignKey(d => d.IdCnf)
                    .HasConstraintName("tchr_cnf_id_cnf_fkey");

                entity.HasOne(d => d.IdTchrNavigation)
                    .WithMany(p => p.TchrCnf)
                    .HasForeignKey(d => d.IdTchr)
                    .HasConstraintName("tchr_cnf_id_tchr_fkey");
            });

            modelBuilder.Entity<TchrPb>(entity =>
            {
                entity.HasKey(e => new { e.IdTchr, e.IdPb })
                    .HasName("tchr_pb_pkey");

                entity.ToTable("tchr_pb");

                entity.Property(e => e.IdTchr).HasColumnName("id_tchr");

                entity.Property(e => e.IdPb).HasColumnName("id_pb");

                entity.HasOne(d => d.IdPbNavigation)
                    .WithMany(p => p.TchrPb)
                    .HasForeignKey(d => d.IdPb)
                    .HasConstraintName("tchr_pb_id_pb_fkey");

                entity.HasOne(d => d.IdTchrNavigation)
                    .WithMany(p => p.TchrPb)
                    .HasForeignKey(d => d.IdTchr)
                    .HasConstraintName("tchr_pb_id_tchr_fkey");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.IdTchr)
                    .HasName("teacher_pkey");

                entity.ToTable("teacher");

                entity.Property(e => e.IdTchr)
                    .HasColumnName("id_tchr")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.IdGroup).HasColumnName("id_group");

                entity.Property(e => e.NameTchr)
                    .IsRequired()
                    .HasColumnName("name_tchr")
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.IdGroup)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("teacher_id_group_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
