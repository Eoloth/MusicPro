using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Producto
    {
        public int Id { get; set; }
        public int CodigoBarra { get; set; }
        public String Descripcion { get; set; }
        public int PrecioCosto { get; set; }
        public int PrecioVenta { get; set; }
        public int Stock { get; set; }

        public Producto()
        {
            Id = 0;
            CodigoBarra = 0;
            Descripcion = "";
            PrecioCosto = 0;
            PrecioVenta = 0;
            Stock = 0;
        }

        // crud
        public int Create()
        {
            try
            {
                CapaDeDatos.Producto p = new CapaDeDatos.Producto();
                p.codigoBarra = this.CodigoBarra;
                p.descripcion = this.Descripcion;
                p.precioCosto = this.PrecioCosto;
                p.precioVenta = this.PrecioVenta;
                p.stock = this.Stock;

                Exchange.
                CommonBC.ModeloVentas.Producto.Add(p);
                return CommonBC.ModeloVentas.SaveChanges();                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);                
                return -1;
            }
        }
        public int Read()
        {
            try
            {
                CommonBC.ModeloVentas = null;
                CapaDeDatos.Producto p = CommonBC.ModeloVentas.
                                            Producto.First(x => x.idProducto == this.Id);
                this.CodigoBarra = p.codigoBarra;
                this.Descripcion = p.descripcion;
                this.PrecioCosto = p.precioCosto;
                this.PrecioVenta = p.precioVenta;
                this.Stock = p.stock;
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int Update()
        {
            try
            {
                CapaDeDatos.Producto p = CommonBC.ModeloVentas.
                                            Producto.First(x => x.idProducto == this.Id);
                p.codigoBarra = this.CodigoBarra;
                p.descripcion = this.Descripcion;
                p.precioCosto = this.PrecioCosto;
                p.precioVenta = this.PrecioVenta;
                p.stock = this.Stock;

                CommonBC.ModeloVentas.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public int Delete()
        {
            try
            {
                CapaDeDatos.Producto p = CommonBC.ModeloVentas.Producto.
                                First(x => x.idProducto == Id);

                CommonBC.ModeloVentas.Producto.Remove(p);
                return CommonBC.ModeloVentas.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // negativo error
            }
        }
    }
}
