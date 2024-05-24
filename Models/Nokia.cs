using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
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
                Console.WriteLine($"Você deseja instalar o aplicativo {nomeApp} em seu Nokia? (Y/n)");
                string ouSimNao = Console.ReadLine().Trim().ToLower();

                if (respostasSim.Contains(ouSimNao))
                {
                    Console.WriteLine($"Instalando {nomeApp}");
                    Console.WriteLine("...");
                    Console.WriteLine("Instalação Concluída com Êxito!");

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
