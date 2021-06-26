using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Categoria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Activo { get; set; }

        public Categoria()
        {
            Id = 0;
            Nombre = "";
            Activo = 0;
        }

        public int Create()
        {
            try
            {
                CapaDeDatos.Categoria obj = new CapaDeDatos.Categoria();
                Exchange.Sincronizar(this, obj);// traspasa los valores de cada propiedad que coincida con obj (capa de datos)
                CommonBC.ModeloVentas.Categoria.Add(obj);
                CommonBC.ModeloVentas.SaveChanges();
                return 1;
            }
            catch (Exception ex)
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
                CapaDeDatos.Categoria obj = CommonBC.ModeloVentas.
                                            Categoria.First(x => x.idCategoria == this.Id);
                Exchange.Sincronizar(obj, this);
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
                CapaDeDatos.Categoria obj = CommonBC.ModeloVentas.
                                            Categoria.First(x => x.idCategoria == this.Id);

                Exchange.Sincronizar(this, obj);
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
                CapaDeDatos.Categoria obj = CommonBC.ModeloVentas.Categoria.
                                First(x => x.idCategoria == Id);

                CommonBC.ModeloVentas.Categoria.Remove(obj);
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
