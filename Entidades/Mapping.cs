namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Mapping : DbContext
    {
        public Mapping()
            : base("name=Mapping")
        {
        }

        public virtual DbSet<Autore> Autores { get; set; }
        public virtual DbSet<Editoriale> Editoriales { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autore>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Autore>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Autore>()
                .HasMany(e => e.Libros)
                .WithMany(e => e.Autores)
                .Map(m => m.ToTable("LibrosAutores").MapLeftKey("IdAutor").MapRightKey("ISBN"));

            modelBuilder.Entity<Editoriale>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Editoriale>()
                .HasMany(e => e.Libros)
                .WithOptional(e => e.Editoriale)
                .HasForeignKey(e => e.IdEditorial);

            modelBuilder.Entity<Genero>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Genero>()
                .HasMany(e => e.Libros)
                .WithOptional(e => e.Genero)
                .HasForeignKey(e => e.IdGenero);

            modelBuilder.Entity<Libro>()
                .Property(e => e.ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Autores)
                .WithRequired(e => e.Pais)
                .HasForeignKey(e => e.IdPais)
                .WillCascadeOnDelete(false);
        }
    }
}
