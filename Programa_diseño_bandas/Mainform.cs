using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_diseño_bandas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.AutoScroll = true;
            
        }

        DatosBelt data = new DatosBelt();

        public string keepServiceFactor;
        public Double keepTypeBelt = 0;

        private void bttService_Click(object sender, EventArgs e)
        {
           
            using (FormService form2 = new FormService())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    TxtService.Text ="Tu valor es: "+ form2.ServiceFactor;
                    keepServiceFactor = form2.ServiceFactor;
                }
            }
        }

        private void bttReset_Click(object sender, EventArgs e)
        {
            paso1.Enabled = false;
            paso2.Enabled = false;
            txtInputRpm.Enabled = true;
            txtOutputRpm.Enabled = true;
            txtPower.Enabled = true;
            bttService.Enabled = true;
            txtInputRpm.Clear();
            txtOutputRpm.Clear();
            txtPower.Clear();
        }

        private void bttFormBelts_Click(object sender, EventArgs e)
        {
            using (tiposBandas form2 = new tiposBandas(txtInputRpm.Text, AnsDesignpower.Text))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    ansBeltType.Text = "Tu banda  es: " + form2.BeltType +"V";
                    keepTypeBelt = Convert.ToDouble(form2.BeltType);
                }
            }
        }

        private void bttSet_Click(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtInputRpm.Text, out parsedValue) || !double.TryParse(txtOutputRpm.Text, out parsedValue) ||
                !double.TryParse(txtPower.Text, out parsedValue) || !double.TryParse(keepServiceFactor, out parsedValue))
            {
                MessageBox.Show("Solo puedes colocar numeros");
                return;
            }
            else
            {
                data.Valor_inputRpm = Convert.ToDouble(txtInputRpm.Text);
                data.Valor_OutputRpm = Convert.ToDouble(txtOutputRpm.Text);
                data.Valor_Power = Convert.ToDouble(txtPower.Text);
                data.ValorServiceFactor = Convert.ToDouble(keepServiceFactor);
                txtInputRpm.Text = txtInputRpm.Text;
                txtOutputRpm.Text = txtOutputRpm.Text;
                txtPower.Text = txtPower.Text;
                txtInputRpm.Enabled = false;
                txtOutputRpm.Enabled = false;
                bttService.Enabled = false;
                txtPower.Enabled = false;
                paso1.Enabled = true;
                paso2.Enabled = true;
                data.ValorDesignPower = data.DesignPower(data.Valor_Power, data.ValorServiceFactor);
                AnsDesignpower.Text = "La potencia de diseño es: " + data.ValorDesignPower;
                   ;

            }
            
        }

        private void bttSecondContinue_Click(object sender, EventArgs e)
        {
            if(keepTypeBelt != 0)
            {
                ansSpeedRelation.Text = "es: " + Math.Round(data.SpeedRelation(data.Valor_inputRpm, data.Valor_OutputRpm), 3);
                ansDiameter.Text = "D1 es: " + Math.Round(data.smallBeltDiameter(data.Valor_inputRpm), 2);
                
                switch (keepTypeBelt)
                {
                    case 3:
                        if(new double[] { 2.60, 2.75, 2.95,3.10, 3.30,3.60 ,4.07, 4.45
                        ,4.70, 4.95, 5.25, 5.55, 5.95, 6.45, 6.85, 7.95, 10.55}.Contains(Math.Round(data.smallBeltDiameter(data.Valor_inputRpm), 2)))
                        {
                            standar_diameter.Text = "Es estandar";
                        }
                    else
                        {
                            standar_diameter.Text = "No es estandar";
                            paso5.Enabled = true;
                            btt3VDiameter.Enabled = true;

                        }
                        break;
                    case 5:
                        if (new double[] { 7.00, 7.40, 7.90,8.40, 8.90,9.15 ,9.65, 10.20
                        ,10.80, 11.70, 12.40, 13.10, 13.90, 14.90, 15.90}.Contains(Math.Round(data.smallBeltDiameter(data.Valor_inputRpm), 2)))
                        {
                            standar_diameter.Text = "Es estandar";
                        }
                        else
                        {
                            standar_diameter.Text = "No es estandar";
                            paso5.Enabled = true;
                            btt5VDiameter.Enabled = true;
                            btt5vPower.Enabled = true;
                        }
                        break;
                    case 8:
                        if (new double[] { 13.00, 13.80, 14.80,15.80, 16.80,17.80 ,18.80, 19.80
                        ,21.00, 22.20, 22.80, 23.80, 24.80}.Contains(Math.Round(data.smallBeltDiameter(data.Valor_inputRpm), 2)))
                        {
                            standar_diameter.Text = "Es estandar";
                        }
                        else
                        {
                            standar_diameter.Text = "No es estandar";
                            paso5.Enabled = true;
                            btt8VDiameter.Enabled = true;

                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Escoge tu factor de servicio");
            }
           
        }

        private void btt5VDiameter_Click(object sender, EventArgs e)
        {
            using (_5vDiameter form2 = new _5vDiameter(data.Valor_OutputRpm, data.Valor_inputRpm,
                data.SpeedRelation(data.Valor_inputRpm, data.Valor_OutputRpm)))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    ansIterD1.Text = form2.ChooseD1Iter + "";
                    data.ValorD1Iter = form2.ChooseD1Iter;
                    ansIterD2.Text = form2.ChooseD2Iter + "";
                    data.ValorD2Iter = form2.ChooseD2Iter;
                    ansPowerTable.Text = form2.ChoosePower + "";
                    data.ValorTablePower = form2.ChoosePower;
                    ansIterDiameterRelation.Text = Math.Round(form2.FinalDiameterRelation, 3) + "";
                    data.ValorDiametrosRelation = Math.Round(form2.FinalDiameterRelation, 3);

                    
                }
            }    
        }

        private void btt3VDiameter_Click(object sender, EventArgs e)
        {
            using (_3VDiameter form2 = new _3VDiameter(data.Valor_OutputRpm, data.Valor_inputRpm,
               data.SpeedRelation(data.Valor_inputRpm, data.Valor_OutputRpm)))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    ansIterD1.Text = form2.ChooseD1Iter + "";
                    data.ValorD1Iter = form2.ChooseD1Iter;
                    ansIterD2.Text = form2.ChooseD2Iter + "";
                    data.ValorD2Iter = form2.ChooseD2Iter;
                    ansPowerTable.Text = form2.ChoosePower + "";
                    data.ValorTablePower = form2.ChoosePower;
                    ansIterDiameterRelation.Text = Math.Round(form2.FinalDiameterRelation, 3) + "";
                    data.ValorDiametrosRelation = Math.Round(form2.FinalDiameterRelation, 3);

                    data.ValorRealPower = data.RealPower(data.ValorTablePower, data.ValorTablePowerAdded);
                    RealPower.Text = data.ValorRealPower + "";
                    if (data.ValorRealPower == 0)
                    {
                        bttNextContinue.Enabled = false;
                    }
                    else
                    {
                        bttNextContinue.Enabled = true;
                    }
                }
            }
        }

        private void btt8VDiameter_Click(object sender, EventArgs e)
        {
            using (_8vDiameter form2 = new _8vDiameter(data.Valor_OutputRpm, data.Valor_inputRpm,
               data.SpeedRelation(data.Valor_inputRpm, data.Valor_OutputRpm)))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    ansIterD1.Text = form2.ChooseD1Iter + "";
                    data.ValorD1Iter = form2.ChooseD1Iter;
                    ansIterD2.Text = form2.ChooseD2Iter + "";
                    data.ValorD2Iter = form2.ChooseD2Iter;
                    ansPowerTable.Text = form2.ChoosePower + "";
                    data.ValorTablePower = form2.ChoosePower;
                    ansIterDiameterRelation.Text = Math.Round(form2.FinalDiameterRelation, 3) + "";
                    data.ValorDiametrosRelation = Math.Round(form2.FinalDiameterRelation, 3);

                    data.ValorRealPower = data.RealPower(data.ValorTablePower, data.ValorTablePowerAdded);
                    RealPower.Text = data.ValorRealPower + "";
                    if (data.ValorRealPower == 0)
                    {
                        bttNextContinue.Enabled = false;
                    }
                    else
                    {
                        bttNextContinue.Enabled = true;
                    }
                }
            }
        }

        private void btt5vPower_Click(object sender, EventArgs e)
        {
            using (PowerAdded5VCase form2 = new PowerAdded5VCase(data.ValorDiametrosRelation))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    data.ValorTablePowerAdded = form2.ChooseAddedPower;
                    data.ValorRealPower = data.RealPower(data.ValorTablePower, data.ValorTablePowerAdded);
                    RealPower.Text = data.ValorRealPower  + "";
                    if (data.ValorRealPower == 0)
                    {
                        bttNextContinue.Enabled = false;
                    }
                    else
                    {
                        bttNextContinue.Enabled = true;
                    }
                }
            }
        }

      
        public double[] IteracionLongitudes3v = { 25,26.5,28,30,31.5,33.5,35.5,37.5,40,42.5,
                                                45,47.5,50,53,56,60,63,57,71,75,80,85,90,95,
                                                100,106,112,118,125,132,140};

        public double[] IteracionLongitudes5v = { 50,53,56,60,63,57,71,75,80,85,90,95,100,
                                                106,112,118,125,132,140,150,160,170,180,190,
                                                200,212,224,236,250,265,280,300,315,335,355};

        public double[] IteracionLongitudes8v = {150,160,170,180,190,200,212,224,236,250,265
                                                ,280,300,315,335,355,375,400,425,450,472,500};

        public Double[] LongitudesCentroIter = new double[35];
        public Double[] LongitudesIter = new double[35];


        public Double RealCenterIter;
        public Double RealLongitudIter;
        private void bttNextContinue_Click(object sender, EventArgs e)
        {
            paso7.Enabled = true;
            bttContinuepaso8.Enabled = true;
            txtLimitInferior.Text = "" + data.ValorD1Iter;
            txtLimitSuperior.Text = "" + data.LimiteSuperior3(data.ValorD1Iter, data.ValorD2Iter);


        }

        private void bttContinuepaso8_Click(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(InputCenterLength.Text, out parsedValue))
            {
                MessageBox.Show("Solo puedes colocar numeros");
                return;
            }
            else
            {
                data.ValorCentro = Convert.ToDouble(InputCenterLength.Text);
                switch (keepTypeBelt)
                {
                    case 3:
                        for (int i = 0; i < IteracionLongitudes3v.Length; i++)
                        {
                            LongitudesIter[i] = (4 * IteracionLongitudes3v[i]) - 6.28 * (data.ValorD1Iter + data.ValorD2Iter);
                            LongitudesCentroIter[i] = (LongitudesIter[i] + Math.Sqrt((LongitudesIter[i] * LongitudesIter[i]) -
                                32 * data.LimiteSuperior(data.ValorD1Iter, data.ValorD2Iter))) / 16;
                        }
                        //Hola Emir.
                        for (int i = 0; i < LongitudesCentroIter.Length; i++)
                        {
                            if (LongitudesCentroIter[i] > data.ValorCentro)
                            {
                                RealCenterIter = LongitudesCentroIter[i];
                                RealLongitudIter = IteracionLongitudes3v[i];
                                break;
                            }

                        }

                        realCenter.Text = "" + RealCenterIter;
                        data.ValorCentro = RealCenterIter;
                        data.ValorLongitud = RealLongitudIter;
                        realLength.Text = "" + RealLongitudIter;

                        data.ValorTetha1 = data.CalcularTheta1(data.ValorD1Iter, data.ValorD2Iter, data.ValorCentro);
                        data.ValorTheta2 = data.CalcularTheta2(data.ValorD1Iter, data.ValorD2Iter, data.ValorCentro);

                        ansTheta1.Text = "" + data.ValorTetha1;
                        ansTheta2.Text = "" + data.ValorTheta2;


                        paso8.Enabled = true;
                        bttNextForm.Enabled = true;
                        break;
                    case 5:
                        for (int i = 0; i < IteracionLongitudes5v.Length; i++)
                        {
                            LongitudesIter[i] = (4 * IteracionLongitudes5v[i]) - 6.28 * (data.ValorD1Iter + data.ValorD2Iter);
                            LongitudesCentroIter[i] = (LongitudesIter[i] + Math.Sqrt((LongitudesIter[i] * LongitudesIter[i]) - 
                                32 * data.LimiteSuperior(data.ValorD1Iter, data.ValorD2Iter)))/16;
                        }
                        //Hola Emir.
                        for(int i = 0; i < LongitudesCentroIter.Length; i++)
                        {
                            if (LongitudesCentroIter[i] > data.ValorCentro) 
                            {
                                RealCenterIter = LongitudesCentroIter[i];
                                RealLongitudIter = IteracionLongitudes5v[i];
                                break;
                            }
                            
                        }

                        realCenter.Text = "" + RealCenterIter;
                        data.ValorCentro = RealCenterIter;
                        data.ValorLongitud = RealLongitudIter;
                        realLength.Text = "" + RealLongitudIter;

                        data.ValorTetha1 = data.CalcularTheta1(data.ValorD1Iter, data.ValorD2Iter, data.ValorCentro);
                        data.ValorTheta2 = data.CalcularTheta2(data.ValorD1Iter, data.ValorD2Iter, data.ValorCentro);

                        ansTheta1.Text = "" + data.ValorTetha1;
                        ansTheta2.Text = "" + data.ValorTheta2;
                        

                        paso8.Enabled = true;
                        bttNextForm.Enabled = true;
                        break;
                    case 8:
                        for (int i = 0; i < IteracionLongitudes8v.Length; i++)
                        {
                            LongitudesIter[i] = (4 * IteracionLongitudes8v[i]) - 6.28 * (data.ValorD1Iter + data.ValorD2Iter);
                            LongitudesCentroIter[i] = (LongitudesIter[i] + Math.Sqrt((LongitudesIter[i] * LongitudesIter[i]) -
                                32 * data.LimiteSuperior(data.ValorD1Iter, data.ValorD2Iter))) / 16;
                        }
                        //Hola Emir.
                        for (int i = 0; i < LongitudesCentroIter.Length; i++)
                        {
                            if (LongitudesCentroIter[i] > data.ValorCentro)
                            {
                                RealCenterIter = LongitudesCentroIter[i];
                                RealLongitudIter = IteracionLongitudes8v[i];
                                break;
                            }

                        }

                        realCenter.Text = "" + RealCenterIter;
                        data.ValorCentro = RealCenterIter;
                        data.ValorLongitud = RealLongitudIter;
                        realLength.Text = "" + RealLongitudIter;

                        data.ValorTetha1 = data.CalcularTheta1(data.ValorD1Iter, data.ValorD2Iter, data.ValorCentro);
                        data.ValorTheta2 = data.CalcularTheta2(data.ValorD1Iter, data.ValorD2Iter, data.ValorCentro);

                        ansTheta1.Text = "" + data.ValorTetha1;
                        ansTheta2.Text = "" + data.ValorTheta2;


                        paso8.Enabled = true;
                        bttNextForm.Enabled = true;
                        break;
                }
            }
            
        }

        private void bttNextForm_Click(object sender, EventArgs e)
        {
            paso9.Enabled = true;
            bttLongitud.Enabled = true;
            bttTheta.Enabled = true;
        }

        private void bttTheta_Click(object sender, EventArgs e)
        {
            using (FactorCorrecionTheta form2 = new FactorCorrecionTheta(data.ValorTetha1))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    data.ValorCorrecionTheta = form2.parsedValue;

                }
            }
        }

        private void bttLongitud_Click(object sender, EventArgs e)
        {
            using (FactorCorrecionLongitud form2 = new FactorCorrecionLongitud(data.ValorLongitud))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    data.ValorCorrecionLong = form2.parsedValue;

                    ansCorrectTheta.Text = data.ValorCorrecionTheta + "";
                    ansCorrectLong.Text = data.ValorCorrecionLong + "";

                    data.ValorPotenciaCorregida = data.CalCularpotenciaCorregida(data.ValorCorrecionTheta, data.ValorCorrecionLong, data.ValorRealPower);
                    ansPowerCorrected.Text = "" + data.ValorPotenciaCorregida;

                    data.ValorNumeroBanda = data.CalcularNumeroBanda(data.ValorDesignPower, data.ValorPotenciaCorregida);
                    ansNumberBelt.Text = data.ValorNumeroBanda + "";
                    paso10.Enabled = true;
                    paso11.Enabled = true;

                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (Metodology form2 = new Metodology())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                  

                }
            }
        }
    }
}
