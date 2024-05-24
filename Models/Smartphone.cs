using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _modelo { get; set; }
        private string _IMEI { get; set; }
        private int _memoria { get; set; }

        public string Modelo()
        {
            return _modelo;
        }

        public string IMEI()
        {
            return _IMEI;
        }

        public int Memoria()
        {
            return _memoria;
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _IMEI = imei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");

            for (int contador = 0; contador < 3; contador++)
            {
                Console.WriteLine("tuuuu tuuuu");
            }

            Console.WriteLine("Ligação Encerrada");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");

            for (int contador = 0; contador < 3; contador++)
            {
                Console.WriteLine("tuuuu tuuuu");
            }

            Console.WriteLine("Ligação Encerrada");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
