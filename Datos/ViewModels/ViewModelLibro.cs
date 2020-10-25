using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ViewModels
{
    public class ViewModelLibro
    {

        //Defino aca Propiedades para el FrontEnd
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int? Edicion { get; set; }
        public int CodigoGenero { get; set; }
        public string Genero { get; set; }

        public int CodigoEditorial { get; set; }
        public string Editorial { get; set; }
    }
}
