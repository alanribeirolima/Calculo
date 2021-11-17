using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_Area3
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }
        public override double CalcularArea => Math.Pow(this.Raio, 2) * Math.PI;
    }

}
