using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace clase_6._5_formularioCalculoIMC.CodigoGenerico
{
    

    public class GestionPacientes
    {

        public SqlConnection Conexion;
        

        public string error;//

        public GestionPacientes() // construct
        { this.Conexion = claseConexion.generaConexion(); }


        public List<Pacientes> metodoListarPacientes()
        {
            List<Pacientes> mylistaPacientes = new List<Pacientes>();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexion;
            Comando.CommandText = "SELECT * from dbo.Pacientes";
            SqlDataReader registroBD = Comando.ExecuteReader();

            while (registroBD.Read())
            {
                Pacientes objpaciente = new Pacientes();
                objpaciente.id = registroBD.GetString(0); // varchar?
                objpaciente.nombre = registroBD.GetString(1);
                objpaciente.apellidos = registroBD.GetString(2);
                objpaciente.direccion = registroBD.GetString(3);
                objpaciente.telefono = registroBD.GetString(4);
                objpaciente.correo = registroBD.GetString(5);

                mylistaPacientes.Add(objpaciente);
            }

            registroBD.Close();
            return mylistaPacientes;



        }//fin m list


















    }//fin clase
}