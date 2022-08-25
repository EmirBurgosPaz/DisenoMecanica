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
    public partial class PowerAdded5VCase : Form
    {
        public PowerAdded5VCase(Double RelationDiamter)
        {
            InitializeComponent();
            DiameterRelation.Text = "Tu relacion de diametros es: " + RelationDiamter; 
        }

        public Double ChooseAddedPower;

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

        private void button1_Click(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(InputAPower.Text, out parsedValue))
            {
                MessageBox.Show("Solo puedes colocar numeros");
                return;
            }
            else
            {
                ChooseAddedPower = Convert.ToDouble(InputAPower.Text);
            }

            if (ChooseAddedPower == 0)
            {
                MessageBox.Show("No has escogido tu valor");
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paint = false;
            this.Invalidate();
            p1List.Clear();
            p2List.Clear();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics gr = e.Graphics;
            //gr.FillRectangle(Brushes.Red, new Rectangle(10, 10, 50, 50));
            if (paint) {
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
