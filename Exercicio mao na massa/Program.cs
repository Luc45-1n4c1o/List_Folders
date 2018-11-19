using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_mao_na_massa
{
    class Program
    {
        static void Main(string[] args)
        {
            Listagem lista = new Listagem();

            lista.listarArquivos();

            Console.ReadKey();
        }
    }

}
