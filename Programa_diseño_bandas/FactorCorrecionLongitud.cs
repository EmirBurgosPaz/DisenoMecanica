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
    public partial class FactorCorrecionLongitud : Form
    {
        public FactorCorrecionLongitud(Double LongitudCorrecion)
        {
            InitializeComponent();
            KeepTheta1.Text = "Tu Longitud es:" + Math.Round(LongitudCorrecion, 3);

        }
        public double parsedValue;
        private void bttSave_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtTheta.Text, out parsedValue))
            {
                MessageBox.Show("Solo puedes colocar numeros");
                return;
            }

            if (parsedValue < 1.2)
            {

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No existe ese valor");
            }
        }
        private Point p1, p2;
        List<Point> p1List = new List<Point>();
        List<Point> p2List = new List<Point>();

        bool paint = true;


        private void bttClear_Click(object sender, EventArgs e)
        {
            paint = false;
            this.Invalidate();
            p1List.Clear();
            p2List.Clear();
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
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

        private void KeepTheta1_Click(object sender, EventArgs e)
        {

        }

        private void txtTheta_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (paint)
            {
                using (var p = new Pen(Color.Blue, 2))
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
