using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Entidades
{
    public class Dolar : Monedas
    {
       

        public Dolar(double cantidad) : base(cantidad)
        {
            this.Cantidad=cantidad;
        }
        private double PrecioEnPesos(double precioDolar) => Cantidad * precioDolar * 1.30;
      
        
        public override string MostrarMoneda(double precioDolar)
        {
            double precioEnPesos = PrecioEnPesos(precioDolar);
            return $"Dolares - Cantidad: {Cantidad}, Cotización: {precioDolar}, Precio en pesos: {precioEnPesos}";
        }


        
    }
   
}
