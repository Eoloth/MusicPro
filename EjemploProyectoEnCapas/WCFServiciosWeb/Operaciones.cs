using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Operaciones : IOperaciones // extends implements
    {
        public string Sumar(int nro1, int nro2)
        {
            int resultado = nro1 + nro2;
            return "Desde .net via SW ==> El resultado es: " + resultado;
        }
        public string Restar(int nr1, int nr2)
        {
            int resultado = nr1 - nr2;
            return "El resultado es " + resultado;
        }

        public string Multiplicar(int nr1, int nr2)
        {
            int resultado = nr1 * nr2;
            return "El resultado es " + resultado;
        }

        public string Dividir(int nr1, int nr2)
        {
            if (nr2 == 0)
                return "No se puede dividir por cero";

            int resultado = nr1 / nr2;
            return "El resultado es " + resultado;
        }

        public string Dividir2(int nr1, int nr2)
        {
            throw new NotImplementedException();
        }
        // ejercicios: Restar, Multiplicar y dividir ==> 15'
        // crear proyecto jframe
        // formulario solicitando 2 numeros 


    }
}
