namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Libros")]
    public partial class Libro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Libro()
        {
            Autores = new HashSet<Autore>();
        }

        [Key]
        [StringLength(17)]
        public string ISBN { get; set; }

        [StringLength(50)]
        public string Titulo { get; set; }

        public int? Edicion { get; set; }

        public int? IdGenero { get; set; }

        public int? IdEditorial { get; set; }

        public int? Paginas { get; set; }

        public virtual Editoriale Editoriale { get; set; }

        public virtual Genero Genero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autore> Autores { get; set; }
    }
}
