using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_diseño_Teoria_de_fallas
{
    class DataFailureMohr
    {
        public Double ValorEsfuerzoX { get; set; }
        public Double ValorEsfuerzoY { get; set; } 
        public Double ValorEsfuerzoXCor { get; set; }
        public Double ValorEsfuerzoYCor { get; set; }
        public Double ValorEsfuerzoCortante { get; set; }
        public Double ValorResComp { get; set; }
        public Double ValorResTens { get; set; }

        public double FactorSeguridadN4(double valorEsfuerzoX, double valorEsfuerzoY, double valorResComp, double valorResTens)
        {
            Double parteA = valorEsfuerzoX / valorResTens;
            Double parteB = valorEsfuerzoY / valorResComp;
            Double valor = Math.Abs(Math.Round(1 / (parteA - parteB), 3));
            return valor;
        }

        public double FactorseguridadN1(double valorEsfuerzoX, double valorResTens)
        {
            double valor = Math.Abs(Math.Round(valorResTens / valorEsfuerzoX, 3));
            return valor;
        }
        public double FactorseguridadN3(double valorEsfuerzoy, double valorResComp)
        {
            double valor = Math.Abs(Math.Round(valorResComp / valorEsfuerzoy, 3));
            return valor;
        }

        public Double NuevoEsfuerzoPositivo(double valorEsfuerzoX, double valorEsfuerzoY, double valorEsfuerzoCortante)
        {
            Double ParteA = (valorEsfuerzoX + valorEsfuerzoY) / 2;
            Double ParteB = Math.Pow((valorEsfuerzoX - valorEsfuerzoY) / 2, 2);
            Double Partec = Math.Pow(valorEsfuerzoCortante, 2);
            Double valor = Math.Round(ParteA + Math.Sqrt(ParteB + Partec), 3);
            return valor;

        }

        public Double NuevoEsfuerzoNegativo(double valorEsfuerzoX, double valorEsfuerzoY, double valorEsfuerzoCortante)
        {
            Double ParteA = (valorEsfuerzoX + valorEsfuerzoY) / 2;
            Double ParteB = Math.Pow((valorEsfuerzoX - valorEsfuerzoY) / 2, 2);
            Double Partec = Math.Pow(valorEsfuerzoCortante, 2);
            Double valor = Math.Round(ParteA - Math.Sqrt(ParteB + Partec), 3);
            return valor;
        }
    }
}
