namespace clase_6._5_formularioCalculoIMC.CodigoGenerico
{
    using System;
    public class Pacientes
    {
        

        public Pacientes(string id, string nombre, string apellidos, string direccion, string telefono, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }

        public Pacientes()
        {
        }

        public string id { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String correo { get; set; }
    }






}