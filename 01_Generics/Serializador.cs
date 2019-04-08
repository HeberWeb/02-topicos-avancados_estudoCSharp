using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
namespace _01_Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            StreamWriter stream = new StreamWriter(@"C:\Users\hpietrafeza\Documents\ProjetosCursos\02-topicos-avancados\ArquivosTestes\generics_"+ obj.GetType().Name +".json");
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string serializado = serializador.Serialize(obj);
            stream.WriteLine(serializado);
            stream.Close();
        }

        public static T Deserializar <T>()
        {
            StreamReader stream = new StreamReader(@"C:\Users\hpietrafeza\Documents\ProjetosCursos\02-topicos-avancados\ArquivosTestes\generics_" + typeof(T).Name +".json");
            string conteudo = stream.ReadToEnd();

            JavaScriptSerializer deserializado = new JavaScriptSerializer();
            T retorno = (T) deserializado.Deserialize(conteudo, typeof(T));

            return retorno;
        }
    }
}
