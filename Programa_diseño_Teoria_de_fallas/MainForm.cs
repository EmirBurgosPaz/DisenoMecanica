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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (ECMForm form2 = new ECMForm())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        private void bttMohr_Click(object sender, EventArgs e)
        {
            using (MohrForms form2 = new MohrForms  ())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void bttFragil_Click(object sender, EventArgs e)
        {
            using (MohrFragil form2 = new MohrFragil())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void bttSetOperations_Click(object sender, EventArgs e)
        {

            double parsedValue;
            if (!double.TryParse(txtFracturaReal.Text, out parsedValue))
            {
                MessageBox.Show("Solo puedes colocar numeros");
                return;
            }
            else
            {
                if (Convert.ToDouble(txtFracturaReal.Text) >= 0.05)
                {
                    bttMohr.Enabled = true;
                    bttEDECM.Enabled = true;
                    bttFragil.Enabled = false;

                }
                else
                {
                    bttMohr.Enabled = false;
                    bttEDECM.Enabled = false;
                    bttFragil.Enabled = true;
                }
            }
        }

        private void cbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDefault.Checked)
            {
                bttMohr.Enabled = true;
                bttEDECM.Enabled = true;
                bttFragil.Enabled = true;

            }
            else 
            {
                bttMohr.Enabled = false;
                bttEDECM.Enabled = false;
                bttFragil.Enabled = false;
            }
        }
    }
}
