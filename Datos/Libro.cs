using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public object TraerAlgunos()            //Traer ALGUNOS CAMPOS de Libros
        {
            var libros = (from x in _context.Libros
                          select new
                          {
                              x.ISBN,
                              x.Titulo,
                              x.Edicion,
                             ID_Genero=x.Genero.ID,
          /*Alias = linq*/   Genero=x.Genero.Descripcion

                          }).ToList() ;
            return libros;
        }
    }
}
