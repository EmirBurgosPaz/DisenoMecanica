using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_diseño_Teoria_de_fallas
{
    class DataFailure
    {

        public Double ValorEsfuerzoX { get; set; }
        public Double ValorEsfuerzoY { get; set; }
        public Double ValorFluencia { get; set; }
        public Double ValorEsfuerzoCortante { get; set; }
        public Double ValorNFactor { get; set; }
        public Double ValorNFactorEc { get; set; }
        public Double ValorVonMienses { get; set; }
        public Double ValorEsfuerzoNX { get; set; }
        public Double ValorEsfuerzoNY { get; set; }

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

        public Double EsfuerzoVonMienses(double valorEsfuerzoX, double valorEsfuerzoY)
        {
            Double ParteA = Math.Pow(valorEsfuerzoX, 2);
            Double ParteB = Math.Pow(valorEsfuerzoY, 2);
            Double Partec = valorEsfuerzoX*valorEsfuerzoY;
            Double valor = Math.Round(Math.Sqrt(ParteA + ParteB - Partec), 3);
            return valor;
        }

        public Double NFactorVonED(double valorFluencia, double valorVonMienses)
        {
            Double valor = valorFluencia / valorVonMienses;
            return Math.Abs(Math.Round(valor,3));
        }

        public Double NFactorVonECM(double valorEsfuerzoX, double valorEsfuerzoY, double valorFluencia)
        {
            Double valor = valorFluencia /( valorEsfuerzoX - valorEsfuerzoY);
            return Math.Abs(Math.Round(valor, 3));
        }

        public Double NFactorVonECMCortante(double valorEsfuerzoX, double valorEsfuerzoY, double valorFluencia)
        {
            Double valor = valorFluencia / (valorEsfuerzoX - valorEsfuerzoY);
            return Math.Abs(Math.Round(valor, 3));
        }

    }

}
