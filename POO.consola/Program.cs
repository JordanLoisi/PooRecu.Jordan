using Poo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, Billetera!");

                var bitCoin = new Crypto(5, Crypto.TipoCripto.Bitcoin);
                var ethereum = new Crypto(10, Crypto.TipoCripto.Ethereum);
                var dolares100 = new Dolar(100);
                var dolares50 = new Dolar(50);

                Billetera.AgregarMoneda(bitCoin);

                Billetera.AgregarMoneda(ethereum);

                Billetera.AgregarMoneda(dolares100);

                Billetera.AgregarMoneda(dolares50);

                Console.WriteLine("Estado actual de la billetera:");
                Billetera.MostrarMonedas(300);

                var dolares1000 = new Dolar(1000);
                Billetera.AgregarMoneda(dolares1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
