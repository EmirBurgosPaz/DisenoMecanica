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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }

        private void bttGetService_Click(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(txtService.Text, out parsedValue))
            {
                MessageBox.Show("Solo puedes colocar numeros");
                return;
            }

            if (new double[] { 1.0, 1.1, 1.2, 1.3, 1.4,1.5, 1.6,1.8,2.0 }.Contains(parsedValue))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No existe ese valor");
            }

               
           
    } 
        public string ServiceFactor
        {
            get { return txtService.Text; }
        }

        
    }
}
