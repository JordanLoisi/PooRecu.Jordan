using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Poo.Entidades.Crypto;

namespace Poo.Entidades
{
    public class Crypto : Monedas
    {
        public enum TipoCripto  { Ethereum,Bitcoin }
        private TipoCripto Tipo;

        public Crypto(double cantidad, TipoCripto tipo) : base(cantidad)
        {
            this.Cantidad=cantidad;
            Tipo = tipo;
        }

       
        public double ValorEnDolares
        {
            get
            {
                if (Tipo == TipoCripto.Ethereum)
                    return Cantidad * 1200;
                else
                    return Cantidad * 17000;
            }
        }

        public override string MostrarMoneda(double precioDolar)
        {
            double precioPesos = Cantidad * precioDolar * 1.30;
            return $"{Tipo} - Cantidad: {Cantidad}, Precio en pesos: {precioPesos}";
        }

    }
}
