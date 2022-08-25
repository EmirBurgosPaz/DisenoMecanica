namespace Programa_diseño_Teoria_de_fallas
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.bttMohr = new System.Windows.Forms.Button();
            this.bttEDECM = new System.Windows.Forms.Button();
            this.bttFragil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFracturaReal = new System.Windows.Forms.TextBox();
            this.bttSetOperations = new System.Windows.Forms.Button();
            this.cbDefault = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teoria de fallas:";
            // 
            // bttMohr
            // 
            this.bttMohr.Enabled = false;
            this.bttMohr.Location = new System.Drawing.Point(15, 172);
            this.bttMohr.Name = "bttMohr";
            this.bttMohr.Size = new System.Drawing.Size(243, 23);
            this.bttMohr.TabIndex = 10;
            this.bttMohr.Text = "Teoría de Mohr-Coulomb";
            this.bttMohr.UseVisualStyleBackColor = true;
            this.bttMohr.Click += new System.EventHandler(this.bttMohr_Click);
            // 
            // bttEDECM
            // 
            this.bttEDECM.Enabled = false;
            this.bttEDECM.Location = new System.Drawing.Point(15, 127);
            this.bttEDECM.Name = "bttEDECM";
            this.bttEDECM.Size = new System.Drawing.Size(243, 39);
            this.bttEDECM.TabIndex = 9;
            this.bttEDECM.Text = "Teoría del Esfuerzo cortante y teoría de la energía por dispersión";
            this.bttEDECM.UseVisualStyleBackColor = true;
            this.bttEDECM.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttFragil
            // 
            this.bttFragil.Enabled = false;
            this.bttFragil.Location = new System.Drawing.Point(15, 201);
            this.bttFragil.Name = "bttFragil";
            this.bttFragil.Size = new System.Drawing.Size(243, 23);
            this.bttFragil.TabIndex = 11;
            this.bttFragil.Text = "Falla para materiales fragiles";
            this.bttFragil.UseVisualStyleBackColor = true;
            this.bttFragil.Click += new System.EventHandler(this.bttFragil_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Para poder escoger ente uno u otro se debe de conocer la deformacion real a \r\nla " +
    "fractura.";
            // 
            // txtFracturaReal
            // 
            this.txtFracturaReal.Location = new System.Drawing.Point(287, 58);
            this.txtFracturaReal.Name = "txtFracturaReal";
            this.txtFracturaReal.Size = new System.Drawing.Size(100, 20);
            this.txtFracturaReal.TabIndex = 13;
            // 
            // bttSetOperations
            // 
            this.bttSetOperations.Location = new System.Drawing.Point(317, 84);
            this.bttSetOperations.Name = "bttSetOperations";
            this.bttSetOperations.Size = new System.Drawing.Size(70, 28);
            this.bttSetOperations.TabIndex = 14;
            this.bttSetOperations.Text = "Escoger";
            this.bttSetOperations.UseVisualStyleBackColor = true;
            this.bttSetOperations.Click += new System.EventHandler(this.bttSetOperations_Click);
            // 
            // cbDefault
            // 
            this.cbDefault.AutoSize = true;
            this.cbDefault.Location = new System.Drawing.Point(287, 127);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(105, 17);
            this.cbDefault.TabIndex = 15;
            this.cbDefault.Text = "No tengo el dato";
            this.cbDefault.UseVisualStyleBackColor = true;
            this.cbDefault.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 270);
            this.Controls.Add(this.cbDefault);
            this.Controls.Add(this.bttSetOperations);
            this.Controls.Add(this.txtFracturaReal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttFragil);
            this.Controls.Add(this.bttMohr);
            this.Controls.Add(this.bttEDECM);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttMohr;
        private System.Windows.Forms.Button bttEDECM;
        private System.Windows.Forms.Button bttFragil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFracturaReal;
        private System.Windows.Forms.Button bttSetOperations;
        private System.Windows.Forms.CheckBox cbDefault;
    }
}

