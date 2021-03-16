using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clase_6._5_formularioCalculoIMC
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void metodoIMC(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            txtResultado.Text= Nombre;
        }
    }
}