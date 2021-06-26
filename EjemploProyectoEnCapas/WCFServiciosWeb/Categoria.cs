using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CapaDeNegocio;

namespace WCFServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Categoria" en el código y en el archivo de configuración a la vez.
    public class Categoria : ICategoria
    {
        public int Create(string Nombre, int Activo)
        {
            CapaDeNegocio.Categoria obj = new CapaDeNegocio.Categoria();
            obj.Nombre = Nombre;
            obj.Activo = Activo;
            return obj.Create();
        }

        public int Delete(int Id)
        {
            CapaDeNegocio.Categoria obj = new CapaDeNegocio.Categoria();
            obj.Id = Id;
            return obj.Delete();
        }

        public List<CapaDeNegocio.Categoria> Listar()
        {
            CapaDeNegocio.VentasColecciones vc = new VentasColecciones();
            return vc.ReadAllCategoria();
        }

        public CapaDeNegocio.Categoria Read(int Id)
        {
            CapaDeNegocio.Categoria obj = new CapaDeNegocio.Categoria();
            obj.Id = Id;
            if (obj.Read() == 1)
                return obj;
            return null;
        }

        public int Update(int Id, string Nombre, int Activo)
        {
            CapaDeNegocio.Categoria obj = new CapaDeNegocio.Categoria();
            obj.Id = Id;
            obj.Nombre = Nombre;
            obj.Activo = Activo;
            return obj.Update();
        }
    }
}
