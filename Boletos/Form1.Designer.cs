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
            RBtnNormal = new RadioButton();
            RBtnEstudiante = new RadioButton();
            RBtnInapam = new RadioButton();
            cant_boletos = new NumericUpDown();
            label1 = new Label();
            pre_boleto = new TextBox();
            txtDato = new TextBox();
            lbl_Dato = new Label();
            label4 = new Label();
            txtTotal = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)cant_boletos).BeginInit();
            SuspendLayout();
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.Black;
            BtnCalcular.ForeColor = SystemColors.ControlLight;
            BtnCalcular.Location = new Point(354, 344);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(112, 34);
            BtnCalcular.TabIndex = 0;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 2;
            label2.Text = "Precio de boleto";
            // 
            // RBtnNormal
            // 
            RBtnNormal.AutoSize = true;
            RBtnNormal.Location = new Point(12, 12);
            RBtnNormal.Name = "RBtnNormal";
            RBtnNormal.Size = new Size(152, 29);
            RBtnNormal.TabIndex = 3;
            RBtnNormal.TabStop = true;
            RBtnNormal.Text = "Boleto Normal";
            RBtnNormal.UseVisualStyleBackColor = true;
            // 
            // RBtnEstudiante
            // 
            RBtnEstudiante.AutoSize = true;
            RBtnEstudiante.Location = new Point(170, 12);
            RBtnEstudiante.Name = "RBtnEstudiante";
            RBtnEstudiante.Size = new Size(200, 29);
            RBtnEstudiante.TabIndex = 4;
            RBtnEstudiante.TabStop = true;
            RBtnEstudiante.Text = "Boleto de estudiante";
            RBtnEstudiante.UseVisualStyleBackColor = true;
            RBtnEstudiante.CheckedChanged += RBtnEstudiante_CheckedChanged;
            // 
            // RBtnInapam
            // 
            RBtnInapam.AutoSize = true;
            RBtnInapam.Location = new Point(376, 12);
            RBtnInapam.Name = "RBtnInapam";
            RBtnInapam.Size = new Size(160, 29);
            RBtnInapam.TabIndex = 5;
            RBtnInapam.TabStop = true;
            RBtnInapam.Text = "Boleto INAPAM";
            RBtnInapam.UseVisualStyleBackColor = true;
            // 
            // cant_boletos
            // 
            cant_boletos.BackColor = Color.FromArgb(255, 255, 192);
            cant_boletos.Location = new Point(19, 290);
            cant_boletos.Name = "cant_boletos";
            cant_boletos.Size = new Size(92, 31);
            cant_boletos.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 247);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 7;
            label1.Text = "Cantidad de boletos";
            // 
            // pre_boleto
            // 
            pre_boleto.BackColor = Color.Peru;
            pre_boleto.Location = new Point(19, 122);
            pre_boleto.Name = "pre_boleto";
            pre_boleto.ReadOnly = true;
            pre_boleto.Size = new Size(150, 31);
            pre_boleto.TabIndex = 8;
            pre_boleto.Text = "80";
            // 
            // txtDato
            // 
            txtDato.BackColor = Color.IndianRed;
            txtDato.Location = new Point(19, 194);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(150, 31);
            txtDato.TabIndex = 10;
            // 
            // lbl_Dato
            // 
            lbl_Dato.AutoSize = true;
            lbl_Dato.Location = new Point(19, 166);
            lbl_Dato.Name = "lbl_Dato";
            lbl_Dato.Size = new Size(84, 25);
            lbl_Dato.TabIndex = 9;
            lbl_Dato.Text = "Matricula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 79);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.HotTrack;
            txtTotal.ForeColor = SystemColors.Window;
            txtTotal.Location = new Point(569, 122);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(586, 79);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 14;
            label3.Text = "Total a pagar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtDato);
            Controls.Add(lbl_Dato);
            Controls.Add(pre_boleto);
            Controls.Add(label1);
            Controls.Add(cant_boletos);
            Controls.Add(RBtnInapam);
            Controls.Add(RBtnEstudiante);
            Controls.Add(RBtnNormal);
            Controls.Add(label2);
            Controls.Add(BtnCalcular);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cant_boletos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalcular;
        private Label label2;
        private RadioButton RBtnNormal;
        private RadioButton RBtnEstudiante;
        private RadioButton RBtnInapam;
        private NumericUpDown cant_boletos;
        private Label label1;
        private TextBox pre_boleto;
        private TextBox txtDato;
        private Label lbl_Dato;
        private Label label4;
        private TextBox txtTotal;
        private Label label3;
    }
}
