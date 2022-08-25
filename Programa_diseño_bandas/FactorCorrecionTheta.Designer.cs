namespace Programa_diseño_bandas
{
    partial class FactorCorrecionTheta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactorCorrecionTheta));
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttClear = new System.Windows.Forms.Button();
            this.KeepTheta1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(772, 12);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.Size = new System.Drawing.Size(100, 20);
            this.txtTheta.TabIndex = 1;
            this.txtTheta.TextChanged += new System.EventHandler(this.txtTheta_TextChanged);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(797, 56);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 2;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttClear
            // 
            this.bttClear.Location = new System.Drawing.Point(747, 287);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(75, 23);
            this.bttClear.TabIndex = 3;
            this.bttClear.Text = "Limpiar";
            this.bttClear.UseVisualStyleBackColor = true;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // KeepTheta1
            // 
            this.KeepTheta1.AutoSize = true;
            this.KeepTheta1.Location = new System.Drawing.Point(744, 94);
            this.KeepTheta1.Name = "KeepTheta1";
            this.KeepTheta1.Size = new System.Drawing.Size(35, 13);
            this.KeepTheta1.TabIndex = 4;
            this.KeepTheta1.Text = "label1";
            this.KeepTheta1.Click += new System.EventHandler(this.KeepTheta1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Programa_diseño_bandas.Properties.Resources.FactorCorrecionTheta;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick_1);
            // 
            // FactorCorrecionTheta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 529);
            this.Controls.Add(this.KeepTheta1);
            this.Controls.Add(this.bttClear);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.txtTheta);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FactorCorrecionTheta";
            this.Text = "SecondForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.Label KeepTheta1;
    }
}