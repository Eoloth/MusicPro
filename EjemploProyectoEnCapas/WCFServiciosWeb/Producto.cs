using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CapaDeNegocio;

namespace WCFServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Producto" en el código y en el archivo de configuración a la vez.
    public class Producto : IProducto
    {
        public int Create(int codigoBarra, string descripcion, int precioCosto, int precioVenta, int stock)
        {
            CapaDeNegocio.Producto prod = new CapaDeNegocio.Producto();
            prod.CodigoBarra = codigoBarra;
            prod.Descripcion = descripcion;
            prod.PrecioCosto = precioCosto;
            prod.PrecioVenta = precioVenta;
            prod.Stock = stock;
            return prod.Create();
        }

        public int Delete(int id)
        {
            CapaDeNegocio.Producto prod = new CapaDeNegocio.Producto();
            prod.Id = id;
            return prod.Delete();
        }

        public CapaDeNegocio.Producto Read(int id)
        {
            CapaDeNegocio.Producto prod = new CapaDeNegocio.Producto();
            prod.Id = id;

            if (prod.Read() == 1)
                return prod;
            return null;
        }

        public int Update(int id, int codigoBarra, string descripcion, int precioCosto, int precioVenta, int stock)
        {
            CapaDeNegocio.Producto prod = new CapaDeNegocio.Producto();
            prod.Id = id;
            prod.CodigoBarra = codigoBarra;
            prod.Descripcion = descripcion;
            prod.PrecioCosto = precioCosto;
            prod.PrecioVenta = precioVenta;
            prod.Stock = stock;
            return prod.Update();
        }

        // Crear el metodo leer para que Java pueda obtener info del id a buscar
    }
}
