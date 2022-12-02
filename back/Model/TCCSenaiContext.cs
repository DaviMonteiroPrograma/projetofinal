using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace back.Model
{
    public partial class TCCSenaiContext : DbContext
    {
        public TCCSenaiContext()
        {
        }

        public TCCSenaiContext(DbContextOptions<TCCSenaiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Compativel> Compativels { get; set; }
        public virtual DbSet<Peca> Pecas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SNCCH03LABF341\\TEW_SQLEXPRESS;Initial Catalog=TCCSenai;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Compativel>(entity =>
            {
                entity.ToTable("Compativel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Peca1Id).HasColumnName("Peca1ID");

                entity.Property(e => e.Peca2Id).HasColumnName("Peca2ID");

                entity.HasOne(d => d.Peca1)
                    .WithMany(p => p.CompativelPeca1s)
                    .HasForeignKey(d => d.Peca1Id)
                    .HasConstraintName("FK__Compative__Peca1__145C0A3F");

                entity.HasOne(d => d.Peca2)
                    .WithMany(p => p.CompativelPeca2s)
                    .HasForeignKey(d => d.Peca2Id)
                    .HasConstraintName("FK__Compative__Peca2__15502E78");
            });

            modelBuilder.Entity<Peca>(entity =>
            {
                entity.ToTable("Peca");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Userpass)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
