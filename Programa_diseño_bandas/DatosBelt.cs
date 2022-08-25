using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_diseño_bandas
{
    class DatosBelt
    {
 
        public Double Valor_inputRpm { get; set; }
        public Double Valor_OutputRpm { get; set; }

        public Double Valor_Power { get; set; }
        public Double ValorServiceFactor { get; set; }
        public Double ValorD1Iter { get; set; }
        public Double ValorD2Iter { get; set; }
        public Double ValorDiametrosRelation { get; set; }
        public Double ValorTablePower { get; set; }
        public Double ValorTablePowerAdded { get; set; }
        public Double ValorCentro { get; set; }
        public Double ValorLongitud { get; set; }
        public Double ValorTetha1 { get; set; }
        public Double ValorTheta2 { get; set; }
        public Double ValorCorrecionTheta { get; set; }
        public Double ValorCorrecionLong { get; set; }
        public Double ValorRealPower { get; set; }
        public Double ValorPotenciaCorregida { get; set; }
        public Double ValorNumeroBanda { get; set; }
        public Double ValorDesignPower { get; set; }

        public Double DesignPower(double valor_Power, double valorServiceFactor)
        {
            Double valor = valor_Power * valorServiceFactor;
            return valor;
        }

        public Double SpeedRelation(double valor_inputRpm, double valor_OutputRpm)
        {
            double value = valor_inputRpm / valor_OutputRpm;
            return value;
        }

        public Double smallBeltDiameter(double valor_inputRpm)
        {
            Double value = (12 * 4000) / (Math.PI * valor_inputRpm);
            return value;
        }

        public Double RealPower(double valorTablePower, double valorTablePowerAdded)
        {
            Double valor = valorTablePower + valorTablePowerAdded;
            return valor;
        }

        public Double LimiteSuperior3(double valorD1Iter, double valorD2Iter)
        {
            Double valor =  (3 * (valorD1Iter + valorD2Iter));
            return valor;
        }

        public Double LimiteSuperior(double valorD1Iter, double valorD2Iter)
        {
            Double valor =  (valorD2Iter - valorD1Iter)* (valorD2Iter - valorD1Iter);
            return valor;
        }

        public Double CalcularTheta1(double valorD1Iter, double valorD2Iter, double valorCentro)
        {
            Double valor =Math.Asin((valorD2Iter - valorD1Iter) / (2 * (valorCentro)));
            Double valorReturn = 180 - 2 * (valor * 180) / Math.PI;
            return valorReturn;
        }
        public Double CalcularTheta2(double valorD1Iter, double valorD2Iter, double valorCentro)
        {
            Double valor = Math.Asin((valorD2Iter - valorD1Iter) / (2 * (valorCentro)));
            Double valorReturn = 180 + 2 * (valor * 180) / Math.PI;
            return valorReturn;
        }

        public Double CalCularpotenciaCorregida(double valorCorrecionTheta, double valorCorrecionLong, double valorRealPower)
        {
            Double Valor = valorRealPower * valorCorrecionLong * valorCorrecionTheta;
            return Math.Round(Valor, 3);
        }

        public Double CalcularNumeroBanda(double valorDesignPower, double valorPotenciaCorregida)
        {
            Double valor = valorDesignPower / valorPotenciaCorregida;

            return Math.Ceiling(valor);
        }
    }
}
