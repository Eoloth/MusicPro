using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOperaciones
    {
        [OperationContract]
        string Sumar(int nro1, int nro2);

        [OperationContract]
        string Restar(int nr1, int nr2);

        [OperationContract]
        string Multiplicar(int nr1, int nr2);
               
        [OperationContract]
        string Dividir(int nr1, int nr2);

        string Dividir2(int nr1, int nr2);

    }

}
