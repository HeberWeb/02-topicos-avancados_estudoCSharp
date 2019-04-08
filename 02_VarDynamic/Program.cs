using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VarDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object o;
            o = new Usuario() { Nome = "Maria" };

            object o1 = "";
            object o2 = 123;
            o2 = ""; // Pode ser alterado o tipo declarado
            var teste = ((Usuario)o).Nome;
            o = "";

            var v1 = "";
            var v2 = 123;
            //Erro: var v3; Obrigatório passar um valor para assim saber o tipo
            //Erro: var v2 = "" // Não pode ser alterado seu tipo
            var v4 = new Usuario() { Nome = "Maria" };
            var teste2 = v4.Nome;

            dynamic d1 = new Usuario() { Nome = "Maria"};
            Console.WriteLine(d1.Nome);
            //Console.WriteLine(d1.Senha);, quando não existe, o erro será apenas em tempo de execução

            d1 = "";

            Console.ReadKey();
        }

        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}
