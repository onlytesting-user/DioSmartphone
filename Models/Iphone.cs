using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Construtor Padrão
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            bool encerrarInstalacao = true;
            List<string> respostasSim = new List<string>() { "y", "yes" };
            List<string> respostasNao = new List<string>() { "n", "no" };

            while (encerrarInstalacao)
            {
                Console.WriteLine($"Você deseja que o aplicativo {nomeApp} seja instalado em seu Iphone? (Y/n)");
                string ouSimNao = Console.ReadLine().Trim().ToLower();

                if (respostasSim.Contains(ouSimNao))
                {
                    Console.WriteLine($"Instalando {nomeApp}. Por favor, aguarde!");
                    Console.WriteLine("Instalando...");
                    Console.WriteLine("...");
                    Console.WriteLine("Instalação Concluída com Sucesso!");

                    encerrarInstalacao = false;
                }
                else if (respostasNao.Contains(ouSimNao))
                {
                    encerrarInstalacao = false;
                }
                else
                {
                    Console.WriteLine("Por favor, inserir um comando válido!");
                }
            }
        }
    }
}
