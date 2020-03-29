namespace Percepptron
{
    partial class Form1
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
            this.tbW1 = new System.Windows.Forms.TextBox();
            this.tbW2 = new System.Windows.Forms.TextBox();
            this.tbU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btInicio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbW3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbW1
            // 
            this.tbW1.Location = new System.Drawing.Point(51, 20);
            this.tbW1.Name = "tbW1";
            this.tbW1.Size = new System.Drawing.Size(100, 20);
            this.tbW1.TabIndex = 0;
            this.tbW1.TextChanged += new System.EventHandler(this.tbW1_TextChanged);
            // 
            // tbW2
            // 
            this.tbW2.Location = new System.Drawing.Point(218, 23);
            this.tbW2.Name = "tbW2";
            this.tbW2.Size = new System.Drawing.Size(100, 20);
            this.tbW2.TabIndex = 1;
            // 
            // tbU
            // 
            this.tbU.Location = new System.Drawing.Point(521, 16);
            this.tbU.Name = "tbU";
            this.tbU.Size = new System.Drawing.Size(100, 20);
            this.tbU.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "W1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "W2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "U";
            // 
            // btInicio
            // 
            this.btInicio.Location = new System.Drawing.Point(291, 71);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(75, 23);
            this.btInicio.TabIndex = 6;
            this.btInicio.Text = "Inicio";
            this.btInicio.UseVisualStyleBackColor = true;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "W3";
            // 
            // tbW3
            // 
            this.tbW3.Location = new System.Drawing.Point(372, 19);
            this.tbW3.Name = "tbW3";
            this.tbW3.Size = new System.Drawing.Size(100, 20);
            this.tbW3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 153);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbW3);
            this.Controls.Add(this.btInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbU);
            this.Controls.Add(this.tbW2);
            this.Controls.Add(this.tbW1);
            this.Name = "Form1";
            this.Text = "Perceptron";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbW1;
        private System.Windows.Forms.TextBox tbW2;
        private System.Windows.Forms.TextBox tbU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbW3;
    }
}

