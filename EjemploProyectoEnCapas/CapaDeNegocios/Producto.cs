using System;

namespace CapaDeNegocios
{
    public class Producto
    {
        int id;
        int codigoBarra;
        String descripcion;

        public int Id { get => id; set => id = value; }
        public int CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
