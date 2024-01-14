using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    public class ClassVenta
    {
        private int Id_Venta;
        private string Comentarios;
        private int Id_Usuario;

        public ClassVenta(int Id_Venta, string Comentarios, int Id_Usuario)
        {
            this.Id_Venta = Id_Venta;
            this.Comentarios = Comentarios;
            this.Id_Usuario = Id_Usuario;
        }

        public int id_venta{

            get
            {
                return this.Id_Venta;
            }

            set
            {
                this.id_venta = value;
            }
        }
        public string comentarios
        {

            get
            {
                return this.Comentarios;
            }

            set
            {
                this.Comentarios = value;
            }
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
    }
}