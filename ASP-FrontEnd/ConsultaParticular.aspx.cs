using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_FrontEnd
{
    public partial class ConsultaParticular : System.Web.UI.Page
    {
        LogicaBI.Libro _context = new LogicaBI.Libro();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TraerAlgunos();
            }

        }

        public void TraerAlgunos()
        {
            gvLibrosParticular.DataSource = _context.TraerAlgunos();
            gvLibrosParticular.DataBind();
        }

        protected void gvLibrosParticular_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resolucio en el FrontEnd
            lbAutores.Items.Clear();//Lo lipiamos por las dudas
            GridViewRow filaSeleccionada = gvLibrosParticular.SelectedRow;//La fila donde se hizo Click
            string isbn = filaSeleccionada.Cells[1].Text;//Cells[Indicamos la Columna]

            foreach (var item in _context.TraerTodos())//Para traer todos los libros
            {
                if (isbn== item.ISBN) //Si la fila seleccionada del ISBN correspondes, que traiga todos los autores
                {
                    //Que me traiga todos los autores
                    foreach (var item2 in item.Autores)
                    {
                        lbAutores.Items.Add(item2.Apellido + " " + item2.Nombre + " "+ item2.Pais.Nombre);
                    }
                }
            }
            
        }
    }
}