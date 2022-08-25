namespace Programa_diseño_bandas
{
    partial class tiposBandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tiposBandas));
            this.txtTypeBelt = new System.Windows.Forms.TextBox();
            this.bttSave = new System.Windows.Forms.Button();
            this.Rpm = new System.Windows.Forms.Label();
            this.Designpower = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTypeBelt
            // 
            this.txtTypeBelt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTypeBelt.Location = new System.Drawing.Point(920, 93);
            this.txtTypeBelt.Name = "txtTypeBelt";
            this.txtTypeBelt.Size = new System.Drawing.Size(100, 20);
            this.txtTypeBelt.TabIndex = 1;
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(920, 47);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 2;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // Rpm
            // 
            this.Rpm.Location = new System.Drawing.Point(920, 138);
            this.Rpm.Name = "Rpm";
            this.Rpm.Size = new System.Drawing.Size(100, 53);
            this.Rpm.TabIndex = 3;
            this.Rpm.Text = "label1";
            // 
            // Designpower
            // 
            this.Designpower.Location = new System.Drawing.Point(920, 191);
            this.Designpower.Name = "Designpower";
            this.Designpower.Size = new System.Drawing.Size(100, 50);
            this.Designpower.TabIndex = 4;
            this.Designpower.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Programa_diseño_bandas.Properties.Resources.typeogfbelts;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 673);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // bttClear
            // 
            this.bttClear.Location = new System.Drawing.Point(903, 650);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(75, 23);
            this.bttClear.TabIndex = 6;
            this.bttClear.Text = "Limpiar";
            this.bttClear.UseVisualStyleBackColor = true;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // tiposBandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 685);
            this.Controls.Add(this.bttClear);
            this.Controls.Add(this.Designpower);
            this.Controls.Add(this.Rpm);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.txtTypeBelt);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tiposBandas";
            this.Text = "tiposBandas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTypeBelt;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Label Rpm;
        private System.Windows.Forms.Label Designpower;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttClear;
    }
}