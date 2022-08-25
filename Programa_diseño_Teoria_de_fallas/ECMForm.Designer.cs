namespace Programa_diseño_Teoria_de_fallas
{
    partial class ECMForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnsVonMieses = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bttClean = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bttCompute = new System.Windows.Forms.Button();
            this.txtEsfuerzo1 = new System.Windows.Forms.TextBox();
            this.txtEsfuerzo2 = new System.Windows.Forms.TextBox();
            this.txtFuerzaCortnate = new System.Windows.Forms.TextBox();
            this.txtFluencia = new System.Windows.Forms.TextBox();
            this.AnsNFactorECM = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AnsNFactorED = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EsfuerzosXY = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(275, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 560);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Datos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "Esfuerzo cortante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Fluencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Esfuerzo y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Esfuerzo x:";
            // 
            // AnsVonMieses
            // 
            this.AnsVonMieses.AutoSize = true;
            this.AnsVonMieses.Location = new System.Drawing.Point(203, 188);
            this.AnsVonMieses.Name = "AnsVonMieses";
            this.AnsVonMieses.Size = new System.Drawing.Size(0, 13);
            this.AnsVonMieses.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Esfuerzo de Von-Miese";
            // 
            // bttClean
            // 
            this.bttClean.Location = new System.Drawing.Point(172, 306);
            this.bttClean.Name = "bttClean";
            this.bttClean.Size = new System.Drawing.Size(75, 23);
            this.bttClean.TabIndex = 74;
            this.bttClean.Text = "Limpiar";
            this.bttClean.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttClean.UseVisualStyleBackColor = true;
            this.bttClean.Click += new System.EventHandler(this.bttClean_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Respuestas";
            // 
            // bttCompute
            // 
            this.bttCompute.Location = new System.Drawing.Point(183, 135);
            this.bttCompute.Name = "bttCompute";
            this.bttCompute.Size = new System.Drawing.Size(75, 23);
            this.bttCompute.TabIndex = 70;
            this.bttCompute.Text = "Calcular";
            this.bttCompute.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttCompute.UseVisualStyleBackColor = true;
            this.bttCompute.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEsfuerzo1
            // 
            this.txtEsfuerzo1.Location = new System.Drawing.Point(158, 21);
            this.txtEsfuerzo1.Name = "txtEsfuerzo1";
            this.txtEsfuerzo1.Size = new System.Drawing.Size(100, 20);
            this.txtEsfuerzo1.TabIndex = 77;
            // 
            // txtEsfuerzo2
            // 
            this.txtEsfuerzo2.Location = new System.Drawing.Point(158, 47);
            this.txtEsfuerzo2.Name = "txtEsfuerzo2";
            this.txtEsfuerzo2.Size = new System.Drawing.Size(100, 20);
            this.txtEsfuerzo2.TabIndex = 78;
            // 
            // txtFuerzaCortnate
            // 
            this.txtFuerzaCortnate.Location = new System.Drawing.Point(158, 73);
            this.txtFuerzaCortnate.Name = "txtFuerzaCortnate";
            this.txtFuerzaCortnate.Size = new System.Drawing.Size(100, 20);
            this.txtFuerzaCortnate.TabIndex = 80;
            // 
            // txtFluencia
            // 
            this.txtFluencia.Location = new System.Drawing.Point(158, 99);
            this.txtFluencia.Name = "txtFluencia";
            this.txtFluencia.Size = new System.Drawing.Size(100, 20);
            this.txtFluencia.TabIndex = 82;
            // 
            // AnsNFactorECM
            // 
            this.AnsNFactorECM.AutoSize = true;
            this.AnsNFactorECM.Location = new System.Drawing.Point(203, 249);
            this.AnsNFactorECM.Name = "AnsNFactorECM";
            this.AnsNFactorECM.Size = new System.Drawing.Size(0, 13);
            this.AnsNFactorECM.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Factor de seguridad";
            // 
            // AnsNFactorED
            // 
            this.AnsNFactorED.AutoSize = true;
            this.AnsNFactorED.Location = new System.Drawing.Point(203, 277);
            this.AnsNFactorED.Name = "AnsNFactorED";
            this.AnsNFactorED.Size = new System.Drawing.Size(0, 13);
            this.AnsNFactorED.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "ECM:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "ED:";
            // 
            // EsfuerzosXY
            // 
            this.EsfuerzosXY.BackColor = System.Drawing.SystemColors.Control;
            this.EsfuerzosXY.HideSelection = false;
            this.EsfuerzosXY.Location = new System.Drawing.Point(24, 327);
            this.EsfuerzosXY.Name = "EsfuerzosXY";
            this.EsfuerzosXY.Size = new System.Drawing.Size(89, 193);
            this.EsfuerzosXY.TabIndex = 90;
            this.EsfuerzosXY.TabStop = false;
            this.EsfuerzosXY.UseCompatibleStateImageBehavior = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 91;
            this.label12.Text = "Coordenadas:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "ECM:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 93;
            this.label14.Text = "ED:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(290, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 59);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico:";
            // 
            // ECMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EsfuerzosXY);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AnsNFactorED);
            this.Controls.Add(this.AnsNFactorECM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFluencia);
            this.Controls.Add(this.txtFuerzaCortnate);
            this.Controls.Add(this.txtEsfuerzo2);
            this.Controls.Add(this.txtEsfuerzo1);
            this.Controls.Add(this.AnsVonMieses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttClean);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttCompute);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ECMForm";
            this.Text = "ECMForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AnsVonMieses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttClean;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttCompute;
        private System.Windows.Forms.TextBox txtEsfuerzo1;
        private System.Windows.Forms.TextBox txtEsfuerzo2;
        private System.Windows.Forms.TextBox txtFuerzaCortnate;
        private System.Windows.Forms.TextBox txtFluencia;
        private System.Windows.Forms.Label AnsNFactorECM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label AnsNFactorED;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView EsfuerzosXY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}