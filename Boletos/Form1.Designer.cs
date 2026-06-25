namespace Boletos
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
            BtnCalcular = new Button();
            label2 = new Label();
            cant_boletos = new NumericUpDown();
            label1 = new Label();
            pre_boleto = new TextBox();
            txtDato = new TextBox();
            lbl_Dato = new Label();
            label4 = new Label();
            txtTotal = new TextBox();
            label3 = new Label();
            cmbTipoBoleto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)cant_boletos).BeginInit();
            SuspendLayout();
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.Black;
            BtnCalcular.ForeColor = SystemColors.ControlLight;
            BtnCalcular.Location = new Point(283, 275);
            BtnCalcular.Margin = new Padding(2);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(90, 27);
            BtnCalcular.TabIndex = 0;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio de boleto";
            // 
            // cant_boletos
            // 
            cant_boletos.BackColor = Color.FromArgb(255, 255, 192);
            cant_boletos.Location = new Point(15, 232);
            cant_boletos.Margin = new Padding(2);
            cant_boletos.Name = "cant_boletos";
            cant_boletos.Size = new Size(74, 27);
            cant_boletos.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 198);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 7;
            label1.Text = "Cantidad de boletos";
            // 
            // pre_boleto
            // 
            pre_boleto.BackColor = Color.Peru;
            pre_boleto.Location = new Point(15, 98);
            pre_boleto.Margin = new Padding(2);
            pre_boleto.Name = "pre_boleto";
            pre_boleto.ReadOnly = true;
            pre_boleto.Size = new Size(121, 27);
            pre_boleto.TabIndex = 8;
            pre_boleto.Text = "80";
            // 
            // txtDato
            // 
            txtDato.BackColor = Color.IndianRed;
            txtDato.Location = new Point(15, 155);
            txtDato.Margin = new Padding(2);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(121, 27);
            txtDato.TabIndex = 10;
            // 
            // lbl_Dato
            // 
            lbl_Dato.AutoSize = true;
            lbl_Dato.Location = new Point(15, 133);
            lbl_Dato.Margin = new Padding(2, 0, 2, 0);
            lbl_Dato.Name = "lbl_Dato";
            lbl_Dato.Size = new Size(71, 20);
            lbl_Dato.TabIndex = 9;
            lbl_Dato.Text = "Matricula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 63);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.HotTrack;
            txtTotal.ForeColor = SystemColors.Window;
            txtTotal.Location = new Point(455, 98);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(121, 27);
            txtTotal.TabIndex = 13;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 63);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 14;
            label3.Text = "Total a pagar";
            // 
            // cmbTipoBoleto
            // 
            cmbTipoBoleto.FormattingEnabled = true;
            cmbTipoBoleto.Location = new Point(10, 12);
            cmbTipoBoleto.Name = "cmbTipoBoleto";
            cmbTipoBoleto.Size = new Size(151, 28);
            cmbTipoBoleto.TabIndex = 15;
            cmbTipoBoleto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(640, 360);
            Controls.Add(cmbTipoBoleto);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtDato);
            Controls.Add(lbl_Dato);
            Controls.Add(pre_boleto);
            Controls.Add(label1);
            Controls.Add(cant_boletos);
            Controls.Add(label2);
            Controls.Add(BtnCalcular);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cant_boletos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalcular;
        private Label label2;
        private NumericUpDown cant_boletos;
        private Label label1;
        private TextBox pre_boleto;
        private TextBox txtDato;
        private Label lbl_Dato;
        private Label label4;
        private TextBox txtTotal;
        private Label label3;
        private ComboBox cmbTipoBoleto;
    }
}
