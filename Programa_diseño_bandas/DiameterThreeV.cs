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
    public partial class _3VDiameter : Form
    {
        public Double InitialRPM;
        public Double FinalRPM;
        public Double RelationDiameter;
        public _3VDiameter(Double valorFinalRPM, Double valorInicialRPM, Double valorDimaterRelations)
        {
            InitializeComponent();
            InitialRPM = valorInicialRPM;
            FinalRPM = valorFinalRPM;
            RelationDiameter = valorDimaterRelations;
            txtFinalRPM.Text = "Velocidad a buscar: " + valorFinalRPM;
            txtDiameterRelation.Text = "Relacion de radios: " + Math.Round(valorDimaterRelations, 3);
        }

        public Double D1Iterada;
        public Double D2Elegida;

        public int index;

        public double[] DiameterStandar = { 2.60, 2.75, 2.95,3.10, 3.30,3.6 ,4.07, 4.45
                        ,4.70, 4.95, 5.25, 5.55, 5.95, 6.45, 6.85,7.95, 10.55 };

        public double[] DiameterStandar2 = { 13.95, 18.95, 24.95, 33.45 };

        public double[] RDIterada = new double[17];
        public double[] VelIterada = new double[4];
        public double[] Dtervals = new double[4];
        public double[] D1Select = new double[4];
        public double[] ErrorVel = new double[4];
        public double[] ErrorRD = new double[4];
        public double[] SaveValuesD1 = new double[4];
        public double[] SaveValuesD2 = new double[4];
        public double ChooseD1Iter;
        public double ChooseD2Iter;
        public double LimiteSuperior;
        public double LimiteInferior;

        public double ChoosePower;
        public double FinalDiameterRelation;





        private void button1_Click(object sender, EventArgs e)
        {

            if (cbMaxMin.Checked)
            {
                for (int i = 0; i < DiameterStandar2.Length; i++)
                {
                    for (int v = 0; v < DiameterStandar.Length; v++)
                    {
                        RDIterada[v] = DiameterStandar2[i] / DiameterStandar[v];
                        VelIterada[i] = InitialRPM / RDIterada[v];
                        if (VelIterada[i] > FinalRPM)
                        {
                            Dtervals[i] = RDIterada[v];
                            D1Select[i] = DiameterStandar[v];
                            if (RDIterada[i] == 0)
                            {
                                Dtervals[i] = DiameterStandar[16] / DiameterStandar2[4];
                                D1Select[i] = DiameterStandar[16];

                            }
                            break;
                        }

                    }
                }
            }
            else
            {

                for (int i = 0; i < DiameterStandar2.Length; i++)
                {
                    for (int v = 0; v < DiameterStandar.Length; v++)
                    {
                        RDIterada[v] = DiameterStandar2[i] / DiameterStandar[v];
                        if (RDIterada[v] > RelationDiameter)
                        {
                            Dtervals[i] = RDIterada[v];
                            D1Select[i] = DiameterStandar[v];

                        }

                    }
                }


                for (int i = 0; i < Dtervals.Length; i++)
                {
                    VelIterada[i] = InitialRPM / Dtervals[i];

                }
            }

            for (int i = 0; i < DiameterStandar2.Length; i++)
            {
                ErrorVel[i] = ((FinalRPM - VelIterada[i]) / FinalRPM) * 100;
            }

            for (int i = 0; i < DiameterStandar2.Length; i++)
            {
                ErrorRD[i] = Math.Abs((RelationDiameter - Dtervals[i]) / RelationDiameter) * 100;
            }
            ansRDIter1.Text = "" + Math.Round(Dtervals[0], 3);
            ansRDIter2.Text = "" + Math.Round(Dtervals[1], 3);
            ansRDIter3.Text = "" + Math.Round(Dtervals[2], 3);
            ansRDIter4.Text = "" + Math.Round(Dtervals[3], 3);

            ansVeliter1.Text = "" + Math.Round(VelIterada[0], 3);
            ansVeliter2.Text = "" + Math.Round(VelIterada[1], 3);
            ansVeliter3.Text = "" + Math.Round(VelIterada[2], 3);
            ansVeliter4.Text = "" + Math.Round(VelIterada[3], 3);

            ansD1Iter1.Text = "" + Math.Round(D1Select[0], 3);
            ansD1Iter2.Text = "" + Math.Round(D1Select[1], 3);
            ansD1Iter3.Text = "" + Math.Round(D1Select[2], 3);
            ansD1Iter4.Text = "" + Math.Round(D1Select[3], 3);

            ansD2Iter1.Text = "" + Math.Round(DiameterStandar2[0], 3);
            ansD2Iter2.Text = "" + Math.Round(DiameterStandar2[1], 3);
            ansD2Iter3.Text = "" + Math.Round(DiameterStandar2[2], 3);
            ansD2Iter4.Text = "" + Math.Round(DiameterStandar2[3], 3);

            ansIterError1.Text = "" + Math.Round(ErrorVel[0], 3);
            ansIterError2.Text = "" + Math.Round(ErrorVel[1], 3);
            ansIterError3.Text = "" + Math.Round(ErrorVel[2], 3);
            ansIterError4.Text = "" + Math.Round(ErrorVel[3], 3);

            ansErrorRD1.Text = "" + Math.Round(ErrorRD[0], 3);
            ansErrorRD2.Text = "" + Math.Round(ErrorRD[1], 3);
            ansErrorRD3.Text = "" + Math.Round(ErrorRD[2], 3);
            ansErrorRD4.Text = "" + Math.Round(ErrorRD[3], 3);
            LimiteInferior = FinalRPM - (FinalRPM * 0.02);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbSelect1.Checked)
            {
                ChooseD1Iter = D1Select[0];
                ChooseD2Iter = DiameterStandar2[0];
                FinalDiameterRelation = Dtervals[0];
            }
            if (rbSelect2.Checked)
            {
                ChooseD1Iter = D1Select[1];
                ChooseD2Iter = DiameterStandar2[1];
                FinalDiameterRelation = Dtervals[1];
            }
            if (rbSelect3.Checked)
            {
                ChooseD1Iter = D1Select[2];
                ChooseD2Iter = DiameterStandar2[2];
                FinalDiameterRelation = Dtervals[2];
            }
            if (rbSelect4.Checked)
            {
                ChooseD1Iter = D1Select[3];
                ChooseD2Iter = DiameterStandar2[3];
                FinalDiameterRelation = Dtervals[3];
            }

            double parsedValue;
            if (!double.TryParse(InputPower.Text, out parsedValue))
            {
                MessageBox.Show("Solo puedes colocar numeros");
                return;
            }
            else
            {
                ChoosePower = Convert.ToDouble(InputPower.Text);

                if (ChooseD1Iter == 0 || ChooseD2Iter == 0)
                {
                    MessageBox.Show("No has escogido tus valores");
                }
                else if (ChoosePower > 40)
                {
                    MessageBox.Show("la potencia no existe");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                    ChoosePower = Convert.ToDouble(InputPower.Text);
                }
            }



        }

        private Point p1, p2;
        List<Point> p1List = new List<Point>();
        List<Point> p2List = new List<Point>();

        bool paint = true;

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            paint = true;
            if (p1.X == 0)
            {
                p1.X = e.X;
                p1.Y = e.Y;
            }
            else
            {
                p2.X = e.X;
                p2.Y = e.Y;

                p1List.Add(p1);
                p2List.Add(p2);

                Invalidate();
                p1.X = 0;
            }
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            paint = false;
            this.Invalidate();
            p1List.Clear();
            p2List.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            using (var p = new Pen(Color.Blue, 2))
            {
                if (paint)
                {
                    for (int x = 0; x < p1List.Count; x++)
                    {
                        e.Graphics.DrawLine(p, p1List[x], p2List[x]);
                    }
                }

            }
        }
    }
}

