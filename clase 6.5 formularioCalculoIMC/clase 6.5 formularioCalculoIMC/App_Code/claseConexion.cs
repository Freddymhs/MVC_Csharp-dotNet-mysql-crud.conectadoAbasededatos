using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace clase_6._5_formularioCalculoIMC.CodigoGenerico
{

    public class claseConexion
    {

        private static string error;
        public static SqlConnection objConnexion;

        public static SqlConnection generaConexion()
        {
            if (objConnexion != null)
            {
                return objConnexion; // si ya existe
            }
            else
            {
                objConnexion = new SqlConnection();
                objConnexion.ConnectionString = (@"Data Source=DESKTOP-I6AE0TH\SQLEXPRESS;Initial Catalog=salud;User ID=sa;Password=1881;"); // @ nombre pc local ,  nombre base dato ,  seguridad
                //conectar
                objConnexion.Open();
                return objConnexion; // si no existe
            }//
        }//fin obten conexion
        public static void cerrarConexion()
        {
            if (objConnexion != null)
            {// si existe
                objConnexion.Close();//cierra
            }
        }//fin errar


    }/// fin .cs
}