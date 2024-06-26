namespace prs_simple_pedal_app
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.acceleratorBar = new System.Windows.Forms.ProgressBar();
            this.brakeBar = new System.Windows.Forms.ProgressBar();
            this.clutchBar = new System.Windows.Forms.ProgressBar();
            this.serialArduino = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acceleratorBar
            // 
            this.acceleratorBar.BackColor = System.Drawing.SystemColors.Control;
            this.acceleratorBar.Location = new System.Drawing.Point(155, 109);
            this.acceleratorBar.Maximum = 225000;
            this.acceleratorBar.Name = "acceleratorBar";
            this.acceleratorBar.Size = new System.Drawing.Size(325, 25);
            this.acceleratorBar.TabIndex = 0;
            // 
            // brakeBar
            // 
            this.brakeBar.Location = new System.Drawing.Point(155, 201);
            this.brakeBar.Maximum = 225000;
            this.brakeBar.Name = "brakeBar";
            this.brakeBar.Size = new System.Drawing.Size(325, 25);
            this.brakeBar.TabIndex = 1;
            // 
            // clutchBar
            // 
            this.clutchBar.Location = new System.Drawing.Point(155, 280);
            this.clutchBar.Maximum = 225000;
            this.clutchBar.Name = "clutchBar";
            this.clutchBar.Size = new System.Drawing.Size(325, 25);
            this.clutchBar.TabIndex = 2;
            // 
            // serialArduino
            // 
            this.serialArduino.PortName = "COM3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simple Pedal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Acelerador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Freio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Embreagem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clutchBar);
            this.Controls.Add(this.brakeBar);
            this.Controls.Add(this.acceleratorBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar acceleratorBar;
        private System.Windows.Forms.ProgressBar brakeBar;
        private System.Windows.Forms.ProgressBar clutchBar;
        private System.IO.Ports.SerialPort serialArduino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

