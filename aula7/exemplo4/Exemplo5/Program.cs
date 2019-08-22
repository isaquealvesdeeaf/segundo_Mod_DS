using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a variavel Stream
            FileStream stream = new FileStream(@"Exemplo4.bin", FileMode.Open);

            //instanciando a variavel do tipo BinaryReader
            BinaryReader reader = new BinaryReader(stream);

            //variaveis recebendo os valores lidos pelo arquivo binario
            int idade = reader.ReadInt32();
            string nome = reader.ReadString();
            bool temFilhos = reader.ReadBoolean();
            double altura = reader.ReadDouble();

            //Fecha o acesso com o arquivo
            reader.Close();
        }
    }
}
