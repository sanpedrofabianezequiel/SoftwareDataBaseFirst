
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloLibro = Entidades.ViewModels;
//Alias en los Using
namespace LogicaBI
{
    public class Libro
    {
        Datos.Libro _context = new Datos.Libro();

        public void Agregar(Entidades.Libro libro) 
        {
            _context.Agregar(libro);
        }
        public List<Entidades.Libro> TraerTodos() 
        {
              List<Entidades.Libro> libros =_context.TraerTodos();

            return libros;
        }
        public List<ModeloLibro.ViewModelLibro> TraerAlgunos() 
        {

            return _context.TraerAlgunos();
        }
    }
}
