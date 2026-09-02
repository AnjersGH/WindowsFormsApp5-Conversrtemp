namespace WindowsFormsApp5
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblFahrenheit = new System.Windows.Forms.Label();
            this.LblKelvin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbCelcius = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbCelcius = new System.Windows.Forms.TextBox();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.tbKelvin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celcius";
            // 
            // LblFahrenheit
            // 
            this.LblFahrenheit.AutoSize = true;
            this.LblFahrenheit.Location = new System.Drawing.Point(294, 145);
            this.LblFahrenheit.Name = "LblFahrenheit";
            this.LblFahrenheit.Size = new System.Drawing.Size(70, 16);
            this.LblFahrenheit.TabIndex = 1;
            this.LblFahrenheit.Text = "Farhenheit";
            // 
            // LblKelvin
            // 
            this.LblKelvin.AutoSize = true;
            this.LblKelvin.Location = new System.Drawing.Point(312, 202);
            this.LblKelvin.Name = "LblKelvin";
            this.LblKelvin.Size = new System.Drawing.Size(43, 16);
            this.LblKelvin.TabIndex = 2;
            this.LblKelvin.Text = "Kelvin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKelvin);
            this.groupBox1.Controls.Add(this.rbFahrenheit);
            this.groupBox1.Controls.Add(this.rbCelcius);
            this.groupBox1.Location = new System.Drawing.Point(105, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(375, 20);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(64, 20);
            this.rbKelvin.TabIndex = 2;
            this.rbKelvin.TabStop = true;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit
            // 
            this.rbFahrenheit.AutoSize = true;
            this.rbFahrenheit.Location = new System.Drawing.Point(192, 19);
            this.rbFahrenheit.Name = "rbFahrenheit";
            this.rbFahrenheit.Size = new System.Drawing.Size(91, 20);
            this.rbFahrenheit.TabIndex = 1;
            this.rbFahrenheit.TabStop = true;
            this.rbFahrenheit.Text = "Fahrenheit";
            this.rbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbCelcius
            // 
            this.rbCelcius.AutoSize = true;
            this.rbCelcius.Location = new System.Drawing.Point(8, 18);
            this.rbCelcius.Name = "rbCelcius";
            this.rbCelcius.Size = new System.Drawing.Size(72, 20);
            this.rbCelcius.TabIndex = 0;
            this.rbCelcius.TabStop = true;
            this.rbCelcius.Text = "Celcius";
            this.rbCelcius.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimpiar.Location = new System.Drawing.Point(411, 345);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(169, 54);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightYellow;
            this.btnCalcular.Location = new System.Drawing.Point(105, 345);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(169, 54);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbCelcius
            // 
            this.tbCelcius.Location = new System.Drawing.Point(226, 107);
            this.tbCelcius.Name = "tbCelcius";
            this.tbCelcius.Size = new System.Drawing.Size(210, 22);
            this.tbCelcius.TabIndex = 8;
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(226, 164);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(210, 22);
            this.tbFahrenheit.TabIndex = 9;
            // 
            // tbKelvin
            // 
            this.tbKelvin.Location = new System.Drawing.Point(226, 221);
            this.tbKelvin.Name = "tbKelvin";
            this.tbKelvin.Size = new System.Drawing.Size(210, 22);
            this.tbKelvin.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.tbKelvin);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbCelcius);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblKelvin);
            this.Controls.Add(this.LblFahrenheit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFahrenheit;
        private System.Windows.Forms.Label LblKelvin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.RadioButton rbFahrenheit;
        private System.Windows.Forms.RadioButton rbCelcius;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbCelcius;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.TextBox tbKelvin;
    }
}

