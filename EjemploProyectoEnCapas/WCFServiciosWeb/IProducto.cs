using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProducto" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProducto
    {
        [OperationContract]
        int Create(int codigoBarra, String descripcion, int precioCosto, int precioVenta, int stock);
        [OperationContract]
        CapaDeNegocio.Producto Read(int id);
        [OperationContract]
        int Update(int id, int codigoBarra, String descripcion, int precioCosto, int precioVenta, int stock);
        [OperationContract]
        int Delete(int id);
    }
}
