using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_FrontEnd
{
    public partial class ConsultaLibrosGeneral : System.Web.UI.Page
    {
        LogicaBI.Libro _context = new LogicaBI.Libro();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TraerTodos();
            }
            
        }

        public void Agregar(Entidades.Libro libro)
        {
            _context.Agregar(libro);
        }
        public void TraerTodos()
        {
            //En este caso ya que estamos en el FrontEnd Podemos usar el
            //DataBind
            gvLibros.DataSource = _context.TraerTodos();
            gvLibros.DataBind();
        }
        public object TraerAlgunos()
        {
            List<Entidades.Libro> librosCampos = _context.TraerAlgunos() as List<Entidades.Libro>;
            return librosCampos;
        }
    }
}