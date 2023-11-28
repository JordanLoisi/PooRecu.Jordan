using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Entidades
{
   public static class Billetera
    {
        private static List<Monedas> monedas = new List<Monedas>();

        public static void AgregarMoneda(Monedas moneda)
        {
            if (ObtenerTotalDolares() + moneda.ValorEnDolares > 200)
            {
                throw new InvalidOperationException("No puede comprar más de 200 dólares");
            }

            monedas.Add(moneda);
            MostrarMonedas(1.0);
        }

        private static double ObtenerTotalDolares()
        {
            double totalDolares = 0;
            foreach (var moneda in monedas)
            {
                totalDolares += moneda.ValorEnDolares;
            }
            return totalDolares;
        }
    

        public static void MostrarMonedas(double precioDolarOficial)
        {
            Console.WriteLine("Monedas en la billetera:");
            foreach (var moneda in monedas)
            {
                Console.WriteLine(moneda.MostrarMoneda(precioDolarOficial));
            }
        }

    }

}

