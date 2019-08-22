using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando as variaveis
            int idade = 25;
            string nome = "Sérgio";
            bool temFilho = false;
            double altura = 1.79;


            //Criando arquivo
            FileStream stream = new FileStream(@"C:\Teste\Exemplo4.bin", FileMode.Create);

            //instanciando a variavel do tipo BinaryWriter
            BinaryWriter writer = new BinaryWriter(stream);

            //Usando o método Write para escrever no arquivo.
            writer.Write(idade);
            writer.Write(nome);
            writer.Write(temFilho);
            writer.Write(altura);

            writer.Flush();
            writer.Close();
        }
    }
}
