using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    public class ClassProducto_Vendido
    {
        private int Id_Producto_Vendido;
        private int Stock;
        private int Id_Venta;
        private int Id_De_Producto;

        public ClassProducto_Vendido(int Id_Producto_Vendido, int Stock, int Id_Venta, int Id_De_Producto)
        {

            this.Id_Producto_Vendido = Id_Producto_Vendido;
            this.Stock = Stock;
            this.Id_Venta = Id_Venta;
            this.Id_De_Producto = Id_De_Producto;
        }

        public int id_producto_vendido
        {
            get
            {
                return this.Id_Producto_Vendido;
            }
            set
            {
                this.Id_Producto_Vendido = value;
            }
        }

        public int stock
        {
            get
            {
                return this.Stock;
            }
            set
            {
                this.Stock = value;
            }
        }

        public int id_venta
        {
            get
            {
                return this.Id_Venta;
            }
            set
            {
                this.Id_Venta = value;
            }
        }
        public int id_de_producto
        {
            get
            {
                return this.Id_De_Producto;
            }
        }
    }
}
