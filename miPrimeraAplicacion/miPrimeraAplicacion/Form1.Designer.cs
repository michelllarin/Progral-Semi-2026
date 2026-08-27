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
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblISSS = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblISR = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalarioaResibir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.Location = new System.Drawing.Point(77, 25);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(318, 26);
            this.lblCalculo.TabIndex = 0;
            this.lblCalculo.Text = "Calculo  de ley (ISSS, AFP, ISR)";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(157, 78);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(177, 34);
            this.txtSueldo.TabIndex = 1;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(68, 81);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(83, 26);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(351, 126);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(149, 95);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(351, 248);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(149, 93);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblISSS
            // 
            this.lblISSS.AutoSize = true;
            this.lblISSS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISSS.Location = new System.Drawing.Point(68, 182);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(123, 26);
            this.lblISSS.TabIndex = 5;
            this.lblISSS.Text = "ISSS (3%): ";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFP.Location = new System.Drawing.Point(68, 219);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(139, 26);
            this.lblAFP.TabIndex = 6;
            this.lblAFP.Text = "AFP (7.25%):";
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISR.Location = new System.Drawing.Point(68, 251);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(129, 26);
            this.lblISR.TabIndex = 7;
            this.lblISR.Text = "ISR (Renta):";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(68, 280);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(217, 26);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total de Deducciones:";
            // 
            // lblSalarioaResibir
            // 
            this.lblSalarioaResibir.AutoSize = true;
            this.lblSalarioaResibir.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioaResibir.Location = new System.Drawing.Point(77, 315);
            this.lblSalarioaResibir.Name = "lblSalarioaResibir";
            this.lblSalarioaResibir.Size = new System.Drawing.Size(171, 26);
            this.lblSalarioaResibir.TabIndex = 9;
            this.lblSalarioaResibir.Text = "Salario a Resibir:";
            // 
            // btnLooo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 419);
            this.Controls.Add(this.lblSalarioaResibir);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.lblISSS);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblCalculo);
            this.Name = "btnLooo";
            this.Text = "Mi Pimera Aplicacion ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalarioaResibir;
    }
}

