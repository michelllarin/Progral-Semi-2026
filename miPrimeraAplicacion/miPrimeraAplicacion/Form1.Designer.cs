namespace miPrimeraAplicacion
{
    partial class btnLooo
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
            this.lblCalculo = new System.Windows.Forms.Label();
            this.txtMontoMensual = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMeses = new System.Windows.Forms.NumericUpDown();
            this.dgvAcumulado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcumulado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.Location = new System.Drawing.Point(77, 25);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(365, 26);
            this.lblCalculo.TabIndex = 0;
            this.lblCalculo.Text = "Tabla de meses acumulados a n meses";
            // 
            // txtMontoMensual
            // 
            this.txtMontoMensual.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoMensual.Location = new System.Drawing.Point(23, 142);
            this.txtMontoMensual.Name = "txtMontoMensual";
            this.txtMontoMensual.Size = new System.Drawing.Size(177, 34);
            this.txtMontoMensual.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(183, 365);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(149, 95);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(23, 87);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(120, 22);
            this.txtMeses.TabIndex = 10;
            // 
            // dgvAcumulado
            // 
            this.dgvAcumulado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcumulado.Location = new System.Drawing.Point(23, 194);
            this.dgvAcumulado.Name = "dgvAcumulado";
            this.dgvAcumulado.RowHeadersWidth = 51;
            this.dgvAcumulado.RowTemplate.Height = 24;
            this.dgvAcumulado.Size = new System.Drawing.Size(479, 150);
            this.dgvAcumulado.TabIndex = 11;
            // 
            // btnLooo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 472);
            this.Controls.Add(this.dgvAcumulado);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMontoMensual);
            this.Controls.Add(this.lblCalculo);
            this.Name = "btnLooo";
            this.Text = "Mi Pimera Aplicacion ";
            this.Load += new System.EventHandler(this.btnLooo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcumulado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.TextBox txtMontoMensual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown txtMeses;
        private System.Windows.Forms.DataGridView dgvAcumulado;
    }
}

