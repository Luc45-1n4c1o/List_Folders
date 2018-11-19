using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_mao_na_massa
{
    public class Listagem
    {

        public void listarArquivos()
        {
            Console.Clear();
            Console.Write("\n [Utilize o nome completo. EX.: c:\\temp\\]");
            Console.Write("\n Digite o caminho: ");
            string nome = Console.ReadLine();

            if (Directory.Exists(nome))
            {
                string[] informacoes = Directory.GetFiles(nome);

                foreach (var info in informacoes)
                {
                    Console.WriteLine(info);
                }
            }
            else
            {
                Console.WriteLine("Diretório especificado não existe.");
            }
        }
    }
}
