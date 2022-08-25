using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_diseño_Teoria_de_fallas
{
    public partial class MohrFragil : Form
    {
        DataFailureMohrFragil data = new DataFailureMohrFragil();
        Graphics graphics;
        Pen Axis;

        private Point p2, PuntoZero;
        ListViewGroup Mostrar = new ListViewGroup("Coordenadas", HorizontalAlignment.Right);



        public MohrFragil()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            EsfuerzosXY.View = View.List;

        }


        private void bttClean_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            EsfuerzosXY.Clear();
        }
        private String todos;



        private void bttCompute_Click(object sender, EventArgs e)
        {
            double parsedValue;
            Axis = new Pen(Color.Black, 1);

            Pen lapiz = new Pen(Color.Black);

            PuntoZero.X = pictureBox1.Width / 2;
            PuntoZero.Y = pictureBox1.Height / 2;

            for (int i = 0; i < pictureBox1.Width; i = i + 10)
            {
                graphics.DrawLine(lapiz, i, PuntoZero.Y + 3, i, PuntoZero.Y - 3);

            }

            for (int i = PuntoZero.Y; i > 0; i = i - 10)
            {
                graphics.DrawLine(lapiz, PuntoZero.X + 3, i, PuntoZero.X - 3, i);

            }

            for (int i = PuntoZero.Y; i < pictureBox1.Height; i = i + 10)
            {
                graphics.DrawLine(lapiz, PuntoZero.X + 3, i, PuntoZero.X - 3, i);

            }



            int Alto = pictureBox1.Height;
            int Ancho = pictureBox1.Width;
            int AltoZero = pictureBox1.Height / 2;
            int AnchoZero = pictureBox1.Width / 2;

            graphics.DrawLine(Axis, AnchoZero, 0, AnchoZero, Alto);
            graphics.DrawLine(Axis, 0, AltoZero, Ancho, AltoZero);

            if (!double.TryParse(txtEsfuerzo1.Text, out parsedValue) || !double.TryParse(txtEsfuerzo2.Text, out parsedValue))
            {
                MessageBox.Show("Solo puedes colocar numeros");
                return;
            }
            else
            {

                data.ValorEsfuerzoX = Convert.ToDouble(txtEsfuerzo1.Text);
                data.ValorEsfuerzoY = Convert.ToDouble(txtEsfuerzo2.Text);
                data.ValorEsfuerzoCortante = Convert.ToDouble(txtFuerzaCortnate.Text);
                data.ValorResComp = Convert.ToDouble(txtResComp.Text);
                data.ValorResTens = Convert.ToDouble(txtRestTens.Text);

                int PrimerPoligono = Convert.ToInt32(data.ValorResTens);
                int SegundoPoligono = Convert.ToInt32(data.ValorResComp);
                Point point1 = new Point(AnchoZero, AltoZero - PrimerPoligono);
                Point point2 = new Point(AnchoZero + PrimerPoligono, AltoZero - PrimerPoligono);
                Point point3 = new Point(AnchoZero + PrimerPoligono, AltoZero);
                Point point4 = new Point(AnchoZero, AltoZero + SegundoPoligono);
                Point point5 = new Point(AnchoZero - SegundoPoligono, AltoZero + SegundoPoligono);
                Point point6 = new Point(AnchoZero - SegundoPoligono, AltoZero);

                Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };


                Pen MM = new Pen(Color.Azure, 2);
                graphics.DrawPolygon(MM, curvePoints);
                Pen Dot = new Pen(Color.Crimson, 6);

                if (data.ValorEsfuerzoCortante == 0)
                {
                    int SetX = Math.Abs(Convert.ToInt32(data.ValorEsfuerzoX));
                    int SetY = Math.Abs(Convert.ToInt32(data.ValorEsfuerzoY));
                    if (data.ValorEsfuerzoX > 0 && data.ValorEsfuerzoY < 0)
                    {
                        Rectangle ellipseBounds = new Rectangle(AnchoZero + SetX, AltoZero + SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);

                        AnsNFactorMC.Text = "" + data.FactorSeguridadN4(data.ValorEsfuerzoX, data.ValorEsfuerzoY
                                            , data.ValorResComp, data.ValorResTens);
                    if(data.CasoMedio(data.ValorEsfuerzoX, data.ValorEsfuerzoY) < 1)
                        {
                            ansNFactorMM.Text = "" + data.FactorseguridadN1(data.ValorEsfuerzoX
                                                                   , data.ValorResTens);
                        }
                        else
                        {
                            ansNFactorMM.Text = "" + data.FactorSeguridadN4MM(data.ValorEsfuerzoX, data.ValorEsfuerzoY
                                           , data.ValorResComp, data.ValorResTens);
                        }
                       


                        todos = data.ValorEsfuerzoX + " , " + data.ValorEsfuerzoY;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                    else if (data.ValorEsfuerzoX > 0 && data.ValorEsfuerzoY > 0)
                    {

                        Rectangle ellipseBounds = new Rectangle(AnchoZero + SetX, AltoZero - SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);

                        AnsNFactorMC.Text = "" + data.FactorseguridadN1(data.ValorEsfuerzoX
                                                                   , data.ValorResTens);
                        ansNFactorMM.Text = "" + data.FactorseguridadN1(data.ValorEsfuerzoX
                                                                   , data.ValorResTens);
                        todos = data.ValorEsfuerzoX + " , " + data.ValorEsfuerzoY;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                    else if (data.ValorEsfuerzoX < 0 && data.ValorEsfuerzoY < 0)
                    {

                        Rectangle ellipseBounds = new Rectangle(AnchoZero - SetX, AltoZero + SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);

                        AnsNFactorMC.Text = "" + data.FactorseguridadN3(data.ValorEsfuerzoY
                                                                   , data.ValorResComp);
                        ansNFactorMM.Text = "" + data.FactorseguridadN3(data.ValorEsfuerzoY
                                                                   , data.ValorResComp);
                        todos = data.ValorEsfuerzoX + " , " + data.ValorEsfuerzoY;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                }
                else
                {
                    data.ValorEsfuerzoXCor = data.NuevoEsfuerzoPositivo(data.ValorEsfuerzoX, data.ValorEsfuerzoY
                                            , data.ValorEsfuerzoCortante);

                    data.ValorEsfuerzoYCor = data.NuevoEsfuerzoNegativo(data.ValorEsfuerzoX, data.ValorEsfuerzoY
                                            , data.ValorEsfuerzoCortante);

                    int SetX = Math.Abs(Convert.ToInt32(data.ValorEsfuerzoXCor));
                    int SetY = Math.Abs(Convert.ToInt32(data.ValorEsfuerzoYCor));

                    if (data.ValorEsfuerzoXCor > 0 && data.ValorEsfuerzoYCor < 0)
                    {
                        Rectangle ellipseBounds = new Rectangle(AnchoZero + SetX, AltoZero + SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);

                        AnsNFactorMC.Text = "" + data.FactorSeguridadN4(data.ValorEsfuerzoXCor, data.ValorEsfuerzoYCor
                                            , data.ValorResComp, data.ValorResTens);
                        if (data.CasoMedio(data.ValorEsfuerzoXCor, data.ValorEsfuerzoYCor) < 1)
                        {
                            ansNFactorMM.Text = "" + data.FactorseguridadN1(data.ValorEsfuerzoXCor
                                                                   , data.ValorResTens);
                        }
                        else
                        {
                            ansNFactorMM.Text = "" + data.FactorSeguridadN4MM(data.ValorEsfuerzoXCor, data.ValorEsfuerzoYCor
                                           , data.ValorResComp, data.ValorResTens);
                        }

                        todos = data.ValorEsfuerzoXCor + " , " + data.ValorEsfuerzoYCor;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                    else if (data.ValorEsfuerzoXCor > 0 && data.ValorEsfuerzoYCor > 0)
                    {

                        Rectangle ellipseBounds = new Rectangle(AnchoZero + SetX, AltoZero - SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);

                        AnsNFactorMC.Text = "" + data.FactorseguridadN1(data.ValorEsfuerzoXCor
                                                                   , data.ValorResTens);
                        ansNFactorMM.Text = "" + data.FactorseguridadN1(data.ValorEsfuerzoXCor
                                                                   , data.ValorResTens);
                        todos = data.ValorEsfuerzoXCor + " , " + data.ValorEsfuerzoYCor;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                    else if (data.ValorEsfuerzoXCor < 0 && data.ValorEsfuerzoYCor < 0)
                    {

                        Rectangle ellipseBounds = new Rectangle(AnchoZero - SetX, AltoZero + SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);

                        AnsNFactorMC.Text = "" + data.FactorseguridadN3(data.ValorEsfuerzoYCor
                                                                   , data.ValorResComp);
                        ansNFactorMM.Text = "" + data.FactorseguridadN3(data.ValorEsfuerzoYCor
                                                                   , data.ValorResComp);
                        todos = data.ValorEsfuerzoXCor + " , " + data.ValorEsfuerzoYCor;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));

                    }
                }

            }


        }
    }
}
