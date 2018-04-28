namespace Graficos_por_tortugas
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnParriba = new System.Windows.Forms.Button();
            this.btnPabajo = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.txtPizarron = new System.Windows.Forms.TextBox();
            this.txtAvanzar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar.......";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(36, 83);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(184, 34);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir.....";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(36, 132);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(184, 34);
            this.btnIzquierda.TabIndex = 2;
            this.btnIzquierda.Text = "Izquierda....";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(36, 174);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(184, 34);
            this.btnDerecha.TabIndex = 3;
            this.btnDerecha.Text = "Derecha.....";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnParriba
            // 
            this.btnParriba.Location = new System.Drawing.Point(36, 212);
            this.btnParriba.Name = "btnParriba";
            this.btnParriba.Size = new System.Drawing.Size(184, 34);
            this.btnParriba.TabIndex = 4;
            this.btnParriba.Text = "Pluma Arriba....";
            this.btnParriba.UseVisualStyleBackColor = true;
            this.btnParriba.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPabajo
            // 
            this.btnPabajo.Location = new System.Drawing.Point(36, 254);
            this.btnPabajo.Name = "btnPabajo";
            this.btnPabajo.Size = new System.Drawing.Size(184, 34);
            this.btnPabajo.TabIndex = 5;
            this.btnPabajo.Text = "Pluma Abajo.....";
            this.btnPabajo.UseVisualStyleBackColor = true;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(36, 300);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(184, 34);
            this.btnAvanzar.TabIndex = 6;
            this.btnAvanzar.Text = "Avanzar.....";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // txtPizarron
            // 
            this.txtPizarron.Location = new System.Drawing.Point(292, 49);
            this.txtPizarron.Multiline = true;
            this.txtPizarron.Name = "txtPizarron";
            this.txtPizarron.Size = new System.Drawing.Size(445, 372);
            this.txtPizarron.TabIndex = 7;
            // 
            // txtAvanzar
            // 
            this.txtAvanzar.Location = new System.Drawing.Point(70, 369);
            this.txtAvanzar.Name = "txtAvanzar";
            this.txtAvanzar.Size = new System.Drawing.Size(100, 22);
            this.txtAvanzar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 486);
            this.Controls.Add(this.txtAvanzar);
            this.Controls.Add(this.txtPizarron);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnPabajo);
            this.Controls.Add(this.btnParriba);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnParriba;
        private System.Windows.Forms.Button btnPabajo;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.TextBox txtPizarron;
        private System.Windows.Forms.TextBox txtAvanzar;
    }
}

