using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using clase_6._5_formularioCalculoIMC.CodigoGenerico;

namespace clase_6._5_formularioCalculoIMC
{
    public partial class Lista : System.Web.UI.Page
    {

        GestionPacientes OBJgestionpaciente = new GestionPacientes();// instancia necesaria *
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnListar(object sender, EventArgs e)
        {
            List<Pacientes> listacapturada = OBJgestionpaciente.metodoListarPacientes();

            gridviewlista.DataSource = listacapturada;
            gridviewlista.DataBind();



        }
    }
}