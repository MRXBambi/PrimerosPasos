using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    public class ClassProducto
    {
        public int Id_Producto;
        protected string Descripcion;
        protected int Costo;
        protected int Precio_Venta;
        public int Stock_Producto;
        protected int Id_De_Usuario;

        public ClassProducto()
        {

            this.Id_Producto = 0;
            this.Descripcion = string.Empty;
            this.Costo = 0;
            this.Precio_Venta = 0;
            this.Stock_Producto = 0;
            this.Id_De_Usuario = 0;
        }

        public ClassProducto(int Id_Producto, string Descripcion, int Costo, int Precio_Venta, int Stock_Producto, int Id_De_Usuario)
        {

            this.Id_Producto = Id_Producto;
            this.Descripcion = Descripcion;
            this.Costo = Costo;
            this.Precio_Venta = Precio_Venta;
            this.Stock_Producto = Stock_Producto;
            this.Id_De_Usuario = Id_De_Usuario;
        }

        public int id_producto
        {
            get
            {
                return this.Id_Producto;
            }
            set
            {
                this.Id_Producto = value;
            }
        }
        public string descripcion
        {
            get
            {
                return this.Descripcion;
            }
            set
            {
                this.Descripcion = value;
            }
        }
        public int precio_venta
        {
            get
            {
                return this.Precio_Venta;
            }
            set
            {
                this.Precio_Venta = value;
            }
        }
        public int stock
        {
            get
            {
                return this.Stock_Producto;
            }
            set
            {
                this.Stock_Producto = value;
            }
        }
        public int id_de_usuario
        {
            get
            {
                return this.Id_De_Usuario;
            }
            set
            {
                this.Id_De_Usuario = value;
            }
        }
    }
}
