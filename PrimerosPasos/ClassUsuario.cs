using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    public class ClassUsuario
    {
        private int Id_Usuario;
        private string Nombre;
        private string Apellido;
        private string Nombre_Usuario;
        private string Clave;
        private string Mail;

        public ClassUsuario()
        {

            this.Id_Usuario = 0;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.Nombre_Usuario = string.Empty;
            this.Clave = string.Empty;
            this.Mail = string.Empty;
        }

        public ClassUsuario(int Id_Usuario, string Nombre, string Apellido, string Nombre_Usuario, string Clave, string Mail)
        {

            this.Id_Usuario = Id_Usuario;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Nombre_Usuario = Nombre_Usuario;
            this.Clave = Clave;
            this.Mail = Mail;
        }

        public int id_usuario
        {
            get
            {
                return this.Id_Usuario;
            }
            set
            {
                this.Id_Usuario = value;
            }
        }
        public string nombre
        {
            get
            {
                return this.Nombre;
            }
            set
            {
                this.Nombre= value;
            }
        }
        public string apellido
        {
            get
            {
                return this.Apellido;
            }
            set
            {
                this.Apellido = value;
            }
        }
        public string nombre_usuario
        {
            get
            {
                return this.Nombre_Usuario;
            }
            set
            {
                this.Nombre_Usuario = value;
            }
        }
        public string clave
        {
            get
            {
                return this.Clave;
            }
            set
            {
                this.Clave = value;
            }
        }
        public string mail
        {
            get
            {
                return this.Mail;
            }
            set
            {
                this.Mail = value;
            }
        }
    }
}
