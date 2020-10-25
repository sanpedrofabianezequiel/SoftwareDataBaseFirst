using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Datos
{
    public class Libro
    {
        //Utilizamos el DbContex Creado por ADO.NET
        Entidades.Mapping _context = new Entidades.Mapping();
        public void Agregar(Entidades.Libro libro)
        {
            _context.Libros.Add(libro);
            _context.SaveChanges();
        }
        public List<Entidades.Libro> TraerTodos()
        {
            //Utilizamos Linqu
            var libros = from x in _context.Libros
                         select x;

            return libros.ToList();
        }

        public List<Entidades.ViewModels.ViewModelLibro> TraerAlgunos()            //Traer ALGUNOS CAMPOS de Libros
        {
            var libros = (from x in _context.Libros
                          select new Entidades.ViewModels.ViewModelLibro
                          {
                              ISBN= x.ISBN,
                              Titulo = x.Titulo,
                              Edicion =x.Edicion,
                              CodigoGenero=x.Genero.ID,
                              Genero =x.Genero.Descripcion,
                              CodigoEditorial=x.Editoriale.ID,
                              Editorial= x.Editoriale.Descripcion
                          }).ToList() ;
            return libros;
        }
    }
}
