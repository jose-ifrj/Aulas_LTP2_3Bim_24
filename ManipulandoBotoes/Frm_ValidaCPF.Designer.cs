namespace ManipulandoBotoes
{
    partial class Frm_ValidaCPF
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
            Msk_CPF = new MaskedTextBox();
            Lbl_Resultado = new Label();
            Btn_Reset = new Button();
            Btn_Valida = new Button();
            SuspendLayout();
            // 
            // Msk_CPF
            // 
            Msk_CPF.Location = new Point(12, 45);
            Msk_CPF.Mask = "000,000,000-00";
            Msk_CPF.Name = "Msk_CPF";
            Msk_CPF.Size = new Size(218, 23);
            Msk_CPF.TabIndex = 0;
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.AutoSize = true;
            Lbl_Resultado.Font = new Font("Arial", 12.25F, FontStyle.Bold);
            Lbl_Resultado.Location = new Point(12, 90);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(0, 19);
            Lbl_Resultado.TabIndex = 1;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(245, 42);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 23);
            Btn_Reset.TabIndex = 2;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Btn_Valida
            // 
            Btn_Valida.Location = new Point(245, 71);
            Btn_Valida.Name = "Btn_Valida";
            Btn_Valida.Size = new Size(111, 23);
            Btn_Valida.TabIndex = 3;
            Btn_Valida.Text = "Valida";
            Btn_Valida.UseVisualStyleBackColor = true;
            Btn_Valida.Click += Btn_Valida_Click;
            // 
            // Frm_ValidaCPF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 154);
            Controls.Add(Btn_Valida);
            Controls.Add(Btn_Reset);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Msk_CPF);
            Name = "Frm_ValidaCPF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validação CPF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox Msk_CPF;
        private Label Lbl_Resultado;
        private Button Btn_Reset;
        private Button Btn_Valida;
    }
}