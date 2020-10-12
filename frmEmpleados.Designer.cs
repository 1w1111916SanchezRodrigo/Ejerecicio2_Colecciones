namespace Ejerecicio2
{
    partial class frmEmpleados
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
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.lstSueldos = new System.Windows.Forms.ListBox();
            this.lstNeto = new System.Windows.Forms.ListBox();
            this.btnAumento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(28, 61);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(120, 95);
            this.lstEmpleados.TabIndex = 0;
            // 
            // lstSueldos
            // 
            this.lstSueldos.FormattingEnabled = true;
            this.lstSueldos.Location = new System.Drawing.Point(181, 61);
            this.lstSueldos.Name = "lstSueldos";
            this.lstSueldos.Size = new System.Drawing.Size(120, 95);
            this.lstSueldos.TabIndex = 1;
            // 
            // lstNeto
            // 
            this.lstNeto.FormattingEnabled = true;
            this.lstNeto.Location = new System.Drawing.Point(428, 61);
            this.lstNeto.Name = "lstNeto";
            this.lstNeto.Size = new System.Drawing.Size(120, 95);
            this.lstNeto.TabIndex = 2;
            // 
            // btnAumento
            // 
            this.btnAumento.Location = new System.Drawing.Point(323, 97);
            this.btnAumento.Name = "btnAumento";
            this.btnAumento.Size = new System.Drawing.Size(75, 23);
            this.btnAumento.TabIndex = 3;
            this.btnAumento.Text = "Aumento";
            this.btnAumento.UseVisualStyleBackColor = true;
            this.btnAumento.Click += new System.EventHandler(this.btnAumento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Emleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sueldo Neto";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 190);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAumento);
            this.Controls.Add(this.lstNeto);
            this.Controls.Add(this.lstSueldos);
            this.Controls.Add(this.lstEmpleados);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.ListBox lstSueldos;
        private System.Windows.Forms.ListBox lstNeto;
        private System.Windows.Forms.Button btnAumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}