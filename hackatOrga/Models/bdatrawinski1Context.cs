using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace hackatOrga.Models
{
    public partial class bdatrawinski1Context : DbContext
    {
        public bdatrawinski1Context()
        {
        }

        public bdatrawinski1Context(DbContextOptions<bdatrawinski1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Evenement> Evenements { get; set; }
        public virtual DbSet<Hackathon> Hackathons { get; set; }
        public virtual DbSet<InscriptionHackathon> InscriptionHackathons { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=192.168.2.4;port=3306;user=sqlatrawinski;password=savary;database=bdatrawinski1;sslmode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evenement>(entity =>
            {
                entity.ToTable("evenement");

                entity.HasIndex(e => e.IdHackathon, "idHackathon");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Duree).HasColumnName("duree");

                entity.Property(e => e.HeureDebut).HasColumnName("heureDebut");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHackathon");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("image");

                entity.Property(e => e.Intervenant)
                    .HasMaxLength(200)
                    .HasColumnName("intervenant")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("libelle");

                entity.Property(e => e.NbParticipants)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbParticipants")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Salle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("salle");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("type");

                entity.HasOne(d => d.IdHackathonNavigation)
                    .WithMany(p => p.Evenements)
                    .HasForeignKey(d => d.IdHackathon)
                    .HasConstraintName("evenement_ibfk_1");
            });

            modelBuilder.Entity<Hackathon>(entity =>
            {
                entity.HasKey(e => e.IdHackathon)
                    .HasName("PRIMARY");

                entity.ToTable("hackathon");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHackathon");

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(5)
                    .HasColumnName("codePostal")
                    .HasDefaultValueSql("'NULL'")
                    .IsFixedLength(true);

                entity.Property(e => e.DateDebut)
                    .HasColumnType("date")
                    .HasColumnName("dateDebut");

                entity.Property(e => e.DateFin)
                    .HasColumnType("date")
                    .HasColumnName("dateFin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateLimite)
                    .HasColumnType("date")
                    .HasColumnName("dateLimite")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureDebut)
                    .HasColumnName("heureDebut")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HeureFin)
                    .HasColumnName("heureFin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Lieu)
                    .HasMaxLength(255)
                    .HasColumnName("lieu")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NbPlaces)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbPlaces")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Rue)
                    .HasMaxLength(255)
                    .HasColumnName("rue")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("theme");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .HasColumnName("ville")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<InscriptionHackathon>(entity =>
            {
                entity.HasKey(e => e.IdInscription)
                    .HasName("PRIMARY");

                entity.ToTable("InscriptionHackathon");

                entity.HasIndex(e => e.IdHackathon, "idHackathon");

                entity.HasIndex(e => e.IdParticipant, "idParticipant");

                entity.Property(e => e.IdInscription)
                    .HasColumnType("int(11)")
                    .HasColumnName("idInscription");

                entity.Property(e => e.Competence)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("competence");

                entity.Property(e => e.DateInscription)
                    .HasColumnType("date")
                    .HasColumnName("dateInscription");

                entity.Property(e => e.IdHackathon)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHackathon");

                entity.Property(e => e.IdParticipant)
                    .HasColumnType("int(11)")
                    .HasColumnName("idParticipant");

                entity.HasOne(d => d.IdHackathonNavigation)
                    .WithMany(p => p.InscriptionHackathons)
                    .HasForeignKey(d => d.IdHackathon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("InscriptionHackathon_ibfk_2");

                entity.HasOne(d => d.IdParticipantNavigation)
                    .WithMany(p => p.InscriptionHackathons)
                    .HasForeignKey(d => d.IdParticipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("InscriptionHackathon_ibfk_1");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => e.IdParticipant)
                    .HasName("PRIMARY");

                entity.ToTable("participant");

                entity.HasIndex(e => e.Mail, "mail")
                    .IsUnique();

                entity.Property(e => e.IdParticipant)
                    .HasColumnType("int(11)")
                    .HasColumnName("idParticipant");

                entity.Property(e => e.CodePostal)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("codePostal")
                    .IsFixedLength(true);

                entity.Property(e => e.DateNaissance)
                    .HasColumnType("date")
                    .HasColumnName("dateNaissance");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("mail");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Portfolio)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("portfolio");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prenom");

                entity.Property(e => e.Rue)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("rue");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("tel");

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ville");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
