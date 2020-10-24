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

    }
}