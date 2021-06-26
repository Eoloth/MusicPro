using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICategoria" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICategoria
    {
        [OperationContract]
        int Create(String Nombre, int Activo);
        [OperationContract]
        CapaDeNegocio.Categoria Read(int Id);
        [OperationContract]
        int Update(int Id, String Nombre, int Activo);
        [OperationContract]
        int Delete(int Id);

        [OperationContract]
        List<CapaDeNegocio.Categoria> Listar();
    }
}
