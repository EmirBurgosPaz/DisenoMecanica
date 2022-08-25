namespace Programa_diseño_bandas
{
    partial class FormService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormService));
            this.label1 = new System.Windows.Forms.Label();
            this.bttGetService = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tu factor de servicio es:";
            // 
            // bttGetService
            // 
            this.bttGetService.Location = new System.Drawing.Point(678, 23);
            this.bttGetService.Name = "bttGetService";
            this.bttGetService.Size = new System.Drawing.Size(138, 23);
            this.bttGetService.TabIndex = 10;
            this.bttGetService.Text = "Escoger valor";
            this.bttGetService.UseVisualStyleBackColor = true;
            this.bttGetService.Click += new System.EventHandler(this.bttGetService_Click);
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(696, 143);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(100, 20);
            this.txtService.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Programa_diseño_bandas.Properties.Resources.servideFactor;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 674);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 698);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.bttGetService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormService";
            this.Text = "TablaServicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttGetService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}