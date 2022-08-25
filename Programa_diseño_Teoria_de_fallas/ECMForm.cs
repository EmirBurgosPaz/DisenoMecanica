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
    public partial class ECMForm : Form
    {
        DataFailure data = new DataFailure();
        Graphics graphics;
        Graphics utilidades;
        Pen Axis;       

        private Point PuntoZero;
        private String todos;

        List<String> Puntos = new List<String>();
        ListViewGroup Mostrar = new ListViewGroup("Coordenadas", HorizontalAlignment.Right);

        public ECMForm()
        {
            InitializeComponent();
            utilidades = groupBox1.CreateGraphics();
            graphics = pictureBox1.CreateGraphics();
            EsfuerzosXY.View = View.List;
        }

        private void bttClean_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            Puntos.Clear();
            EsfuerzosXY.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
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

            if (!double.TryParse(txtEsfuerzo1.Text, out parsedValue) || !double.TryParse(txtEsfuerzo2.Text, out parsedValue) )
            {
                MessageBox.Show("Solo puedes colocar numeros");
                return;
            }
            else
            {

                data.ValorEsfuerzoX = Convert.ToDouble(txtEsfuerzo1.Text);
                data.ValorEsfuerzoY = Convert.ToDouble(txtEsfuerzo2.Text);
                data.ValorEsfuerzoCortante = Convert.ToDouble(txtFuerzaCortnate.Text);
                data.ValorFluencia = Convert.ToDouble(txtFluencia.Text);

                int Setear = Convert.ToInt32(data.ValorFluencia);
                Point point1 = new Point(AnchoZero, AltoZero - Setear);
                Point point2 = new Point(AnchoZero + Setear, AltoZero - Setear);
                Point point3 = new Point(AnchoZero + Setear, AltoZero);
                Point point4 = new Point(AnchoZero, AltoZero + Setear);
                Point point5 = new Point(AnchoZero - Setear, AltoZero + Setear);
                Point point6 = new Point(AnchoZero - Setear, AltoZero);

                Point[] curvePoints = { point1, point2, point3, point4, point5, point6 };

                Pen ECM = new Pen(Color.Red, 2);
                graphics.DrawPolygon(ECM, curvePoints);

                Pen ED = new Pen(Color.BlueViolet, 2);
                graphics.DrawClosedCurve(ED, curvePoints);

                Pen Esfuerzo = new Pen(Color.Blue, 2);
                Pen Dot = new Pen(Color.Goldenrod, 6);
                Pen Dot2 = new Pen(Color.LightSteelBlue, 6);

                utilidades.DrawLine(ECM, 35, 25, 80, 25);
                utilidades.DrawLine(ED  , 35, 45, 80, 45);

                if (data.ValorEsfuerzoCortante == 0)
                {
                    int SetX =Math.Abs( Convert.ToInt32(data.ValorEsfuerzoX)); 
                    int SetY = Math.Abs(Convert.ToInt32(data.ValorEsfuerzoY)); 
                    if (data.ValorEsfuerzoX > 0 && data.ValorEsfuerzoY < 0)
                    {
                        Rectangle ellipseBounds = new Rectangle(AnchoZero + SetX, AltoZero + SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);

                        data.ValorVonMienses = data.EsfuerzoVonMienses(data.ValorEsfuerzoX, data.ValorEsfuerzoY);
                        AnsVonMieses.Text = "" + data.ValorVonMienses;
                        data.ValorNFactorEc = data.NFactorVonECM(data.ValorEsfuerzoX, data.ValorEsfuerzoY, data.ValorFluencia);
                        AnsNFactorECM.Text = data.ValorNFactorEc + "";
                        data.ValorNFactor = data.NFactorVonED(data.ValorFluencia, data.ValorVonMienses);
                        AnsNFactorED.Text = "" + data.ValorNFactor;
                        todos = data.ValorEsfuerzoX + " , " + data.ValorEsfuerzoY;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                        
                    }
                    else if (data.ValorEsfuerzoX > 0 && data.ValorEsfuerzoY > 0)
                    {

                        Rectangle ellipseBounds = new Rectangle(AnchoZero + SetX, AltoZero - SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);

                        data.ValorVonMienses = data.EsfuerzoVonMienses(data.ValorEsfuerzoX, data.ValorEsfuerzoY);
                        AnsVonMieses.Text = "" + data.ValorVonMienses;
                        data.ValorNFactorEc = data.NFactorVonECM(data.ValorEsfuerzoX, 0, data.ValorFluencia);
                        AnsNFactorECM.Text = data.ValorNFactorEc + "";
                        data.ValorNFactor = data.NFactorVonED(data.ValorFluencia, data.ValorVonMienses);
                        AnsNFactorED.Text = "" + data.ValorNFactor;
                        todos = data.ValorEsfuerzoX + " , " + data.ValorEsfuerzoY;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                    else if (data.ValorEsfuerzoX < 0 && data.ValorEsfuerzoY < 0)
                    {

                        Rectangle ellipseBounds = new Rectangle(AnchoZero - SetX, AltoZero + SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);
                        data.ValorVonMienses = data.EsfuerzoVonMienses(data.ValorEsfuerzoX, data.ValorEsfuerzoY);
                        AnsVonMieses.Text = "" + data.ValorVonMienses;
                        data.ValorNFactorEc = data.NFactorVonECM(0, data.ValorEsfuerzoY, data.ValorFluencia);
                        AnsNFactorECM.Text = data.ValorNFactorEc + "";
                        data.ValorNFactor = data.NFactorVonED(data.ValorFluencia, data.ValorVonMienses);
                        AnsNFactorED.Text = "" + data.ValorNFactor;
                        todos = data.ValorEsfuerzoX + " , " + data.ValorEsfuerzoY;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                }
                else
                {
                    data.ValorEsfuerzoNX = data.NuevoEsfuerzoPositivo(data.ValorEsfuerzoX, data.ValorEsfuerzoY, data.ValorEsfuerzoCortante);
                    data.ValorEsfuerzoNY = data.NuevoEsfuerzoNegativo(data.ValorEsfuerzoX, data.ValorEsfuerzoY, data.ValorEsfuerzoCortante);

                    
                    int SetX = Math.Abs(Convert.ToInt32(data.ValorEsfuerzoNX));
                    int SetY = Math.Abs(Convert.ToInt32(data.ValorEsfuerzoNY));
                    if (data.ValorEsfuerzoNX > 0 && data.ValorEsfuerzoNY < 0)
                    {
                        data.ValorVonMienses = data.EsfuerzoVonMienses(data.ValorEsfuerzoNX, data.ValorEsfuerzoNY);
                        AnsVonMieses.Text = "" + data.ValorVonMienses;
                        data.ValorNFactorEc = data.NFactorVonECMCortante(data.ValorEsfuerzoNX, data.ValorEsfuerzoNY, data.ValorFluencia);
                        AnsNFactorECM.Text = data.ValorNFactorEc + "";
                        data.ValorNFactor = data.NFactorVonED(data.ValorFluencia, data.ValorVonMienses);
                        AnsNFactorED.Text = "" + data.ValorNFactor;
                        Rectangle ellipseBounds = new Rectangle(AnchoZero + SetX, AltoZero + SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);
                        todos = data.ValorEsfuerzoNX + " , " + data.ValorEsfuerzoNY;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                    else if (data.ValorEsfuerzoNX > 0 && data.ValorEsfuerzoNY > 0)
                    {
                        data.ValorVonMienses = data.EsfuerzoVonMienses(data.ValorEsfuerzoNX, data.ValorEsfuerzoNY);
                        AnsVonMieses.Text = "" + data.ValorVonMienses;
                        data.ValorNFactorEc = data.NFactorVonECMCortante(data.ValorEsfuerzoNX, 0, data.ValorFluencia);
                        AnsNFactorECM.Text = data.ValorNFactorEc + "";
                        data.ValorNFactor = data.NFactorVonED(data.ValorFluencia, data.ValorVonMienses);
                        AnsNFactorED.Text = "" + data.ValorNFactor;
                        Rectangle ellipseBounds = new Rectangle(AnchoZero + SetX, AltoZero - SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);
                        todos = data.ValorEsfuerzoNX + " , " + data.ValorEsfuerzoNY;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                    else if (data.ValorEsfuerzoNX < 0 && data.ValorEsfuerzoNY < 0)
                    {
                        data.ValorVonMienses = data.EsfuerzoVonMienses(data.ValorEsfuerzoNX, data.ValorEsfuerzoNY);
                        AnsVonMieses.Text = "" + data.ValorVonMienses;
                        data.ValorNFactorEc = data.NFactorVonECMCortante(0, data.ValorEsfuerzoNY, data.ValorFluencia);
                        AnsNFactorECM.Text = data.ValorNFactorEc + "";
                        data.ValorNFactor = data.NFactorVonED(data.ValorFluencia, data.ValorVonMienses);
                        AnsNFactorED.Text = "" + data.ValorNFactor;
                        Rectangle ellipseBounds = new Rectangle(AnchoZero - SetX, AltoZero + SetY, 5, 5);
                        graphics.DrawEllipse(Dot, ellipseBounds);
                        todos = data.ValorEsfuerzoNX + " , " + data.ValorEsfuerzoNY;
                        EsfuerzosXY.Items.Add(new ListViewItem(todos, Mostrar));
                    }
                }
            }
        }
    }
}
