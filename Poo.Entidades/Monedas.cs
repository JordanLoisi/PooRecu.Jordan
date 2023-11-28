using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Entidades
{
    public abstract class Monedas
    {
        protected double Cantidad { get; set; }

        protected Monedas(double cantidad)
        {
            this.Cantidad = cantidad;
        }
        public double ValorEnDolares => Cantidad;


        public virtual string MostrarMoneda(double precioDolar)
        {
            return $"Cantidad: {Cantidad} {GetType().Name}, Valor en Dólares: {ValorEnDolares * precioDolar}";
        }
     
    }
}
