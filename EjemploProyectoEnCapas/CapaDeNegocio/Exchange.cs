using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDeNegocio
{
    public class Exchange
    {
        public static void Sincronizar(object origen, object destino)
        {
            /* Auxiliares para Reflection del Tipo de Dato Origen */
            Type tipo = null;
            PropertyInfo[] propiedades = null;

            /* Obtiene información del Tipo Origen y sus Propiedades */
            tipo = origen.GetType();
            propiedades = tipo.GetProperties();

            /* Recorre las propiedades del Origen para asignar los valores al destino */
            foreach (PropertyInfo propiedad in propiedades)
            {
                try
                {
                    /* Recupera propiedad destino por su nombre */
                    PropertyInfo propInfo = destino.GetType().GetProperty(propiedad.Name[0].ToString().ToUpper() + propiedad.Name.Substring(1));

  			        if(propInfo == null)
				        propInfo = destino.GetType().GetProperty(propiedad.Name[0].ToString().ToLower() + propiedad.Name.Substring(1));

                    /* Asigna valor destino desde el origen */
                    propInfo.SetValue(destino, propiedad.GetValue(origen, null));
                }
                catch {/* Los valores que no se pueden asignar son ignorados */}
            }
        }
    }
}
