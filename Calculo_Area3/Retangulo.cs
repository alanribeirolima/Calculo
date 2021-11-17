using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_Area3
{
    public class Retangulo : Forma
    {
        public double Lado { get; set; }
        public override double CalcularArea => this.Lado * this.Lado;
    }

}
