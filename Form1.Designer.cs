namespace Ejerecicio2
{
    partial class Form1
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
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnAllDerecha = new System.Windows.Forms.Button();
            this.btnAllIzq = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(29, 33);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(120, 147);
            this.lst1.TabIndex = 0;
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(241, 33);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(120, 147);
            this.lst2.TabIndex = 1;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(173, 33);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(38, 23);
            this.btnDerecha.TabIndex = 2;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnAllDerecha
            // 
            this.btnAllDerecha.Location = new System.Drawing.Point(173, 72);
            this.btnAllDerecha.Name = "btnAllDerecha";
            this.btnAllDerecha.Size = new System.Drawing.Size(38, 23);
            this.btnAllDerecha.TabIndex = 3;
            this.btnAllDerecha.Text = ">>";
            this.btnAllDerecha.UseVisualStyleBackColor = true;
            this.btnAllDerecha.Click += new System.EventHandler(this.btnAllDerecha_Click);
            // 
            // btnAllIzq
            // 
            this.btnAllIzq.Location = new System.Drawing.Point(173, 111);
            this.btnAllIzq.Name = "btnAllIzq";
            this.btnAllIzq.Size = new System.Drawing.Size(38, 23);
            this.btnAllIzq.TabIndex = 4;
            this.btnAllIzq.Text = "<<";
            this.btnAllIzq.UseVisualStyleBackColor = true;
            this.btnAllIzq.Click += new System.EventHandler(this.btnAllIzq_Click);
            // 
            // btnIzq
            // 
            this.btnIzq.Location = new System.Drawing.Point(173, 150);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(38, 23);
            this.btnIzq.TabIndex = 5;
            this.btnIzq.Text = "<";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(118, 200);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 231);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnAllIzq);
            this.Controls.Add(this.btnAllDerecha);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnAllDerecha;
        private System.Windows.Forms.Button btnAllIzq;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Label lbl1;
    }
}

