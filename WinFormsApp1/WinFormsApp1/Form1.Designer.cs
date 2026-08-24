namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSerie = new Label();
            cboSerie = new ComboBox();
            tsValores = new ListBox();
            btnProcesar = new Button();
            txtSerie = new TextBox();
            SuspendLayout();
            // 
            // lblSerie
            // 
            lblSerie.AutoSize = true;
            lblSerie.Location = new Point(108, 50);
            lblSerie.Name = "lblSerie";
            lblSerie.Size = new Size(45, 20);
            lblSerie.TabIndex = 0;
            lblSerie.Text = "Serie:";
            // 
            // cboSerie
            // 
            cboSerie.FormattingEnabled = true;
            cboSerie.Location = new Point(184, 50);
            cboSerie.Name = "cboSerie";
            cboSerie.Size = new Size(151, 28);
            cboSerie.TabIndex = 1;
            // 
            // tsValores
            // 
            tsValores.FormattingEnabled = true;
            tsValores.Location = new Point(123, 178);
            tsValores.Name = "tsValores";
            tsValores.Size = new Size(150, 104);
            tsValores.TabIndex = 2;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(318, 190);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(140, 78);
            btnProcesar.TabIndex = 3;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(365, 51);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(125, 27);
            txtSerie.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSerie);
            Controls.Add(btnProcesar);
            Controls.Add(tsValores);
            Controls.Add(cboSerie);
            Controls.Add(lblSerie);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSerie;
        private ComboBox cboSerie;
        private ListBox tsValores;
        private Button btnProcesar;
        private TextBox txtSerie;
    }
}
