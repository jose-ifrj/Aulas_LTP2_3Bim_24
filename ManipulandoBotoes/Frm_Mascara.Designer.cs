namespace ManipulandoBotoes
{
    partial class Frm_Mascara
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
            Msk_TextBox = new MaskedTextBox();
            Lbl_Conteudo = new Label();
            Lbl_MascaraAtiva = new Label();
            Btn_Hora = new Button();
            Btn_CEP = new Button();
            Btn_Moeda = new Button();
            Btn_Data = new Button();
            Btn_Telefone = new Button();
            Btn_Senha = new Button();
            Btn_VerConteudo = new Button();
            SuspendLayout();
            // 
            // Msk_TextBox
            // 
            Msk_TextBox.Font = new Font("Arial", 12F, FontStyle.Bold);
            Msk_TextBox.Location = new Point(23, 31);
            Msk_TextBox.Name = "Msk_TextBox";
            Msk_TextBox.Size = new Size(258, 26);
            Msk_TextBox.TabIndex = 0;
            // 
            // Lbl_Conteudo
            // 
            Lbl_Conteudo.AutoSize = true;
            Lbl_Conteudo.Font = new Font("Arial", 12F, FontStyle.Bold);
            Lbl_Conteudo.Location = new Point(23, 246);
            Lbl_Conteudo.Name = "Lbl_Conteudo";
            Lbl_Conteudo.Size = new Size(0, 19);
            Lbl_Conteudo.TabIndex = 1;
            // 
            // Lbl_MascaraAtiva
            // 
            Lbl_MascaraAtiva.AutoSize = true;
            Lbl_MascaraAtiva.Font = new Font("Arial", 12F, FontStyle.Bold);
            Lbl_MascaraAtiva.Location = new Point(23, 75);
            Lbl_MascaraAtiva.Name = "Lbl_MascaraAtiva";
            Lbl_MascaraAtiva.Size = new Size(0, 19);
            Lbl_MascaraAtiva.TabIndex = 2;
            // 
            // Btn_Hora
            // 
            Btn_Hora.Location = new Point(23, 110);
            Btn_Hora.Name = "Btn_Hora";
            Btn_Hora.Size = new Size(82, 37);
            Btn_Hora.TabIndex = 3;
            Btn_Hora.Text = "Hora";
            Btn_Hora.UseVisualStyleBackColor = true;
            Btn_Hora.Click += Btn_Hora_Click;
            // 
            // Btn_CEP
            // 
            Btn_CEP.Location = new Point(111, 110);
            Btn_CEP.Name = "Btn_CEP";
            Btn_CEP.Size = new Size(82, 37);
            Btn_CEP.TabIndex = 4;
            Btn_CEP.Text = "CEP";
            Btn_CEP.UseVisualStyleBackColor = true;
            Btn_CEP.Click += Btn_CEP_Click;
            // 
            // Btn_Moeda
            // 
            Btn_Moeda.Location = new Point(199, 110);
            Btn_Moeda.Name = "Btn_Moeda";
            Btn_Moeda.Size = new Size(82, 37);
            Btn_Moeda.TabIndex = 5;
            Btn_Moeda.Text = "Moeda";
            Btn_Moeda.UseVisualStyleBackColor = true;
            Btn_Moeda.Click += Btn_Moeda_Click;
            // 
            // Btn_Data
            // 
            Btn_Data.Location = new Point(23, 153);
            Btn_Data.Name = "Btn_Data";
            Btn_Data.Size = new Size(82, 37);
            Btn_Data.TabIndex = 6;
            Btn_Data.Text = "Data";
            Btn_Data.UseVisualStyleBackColor = true;
            Btn_Data.Click += Btn_Data_Click;
            // 
            // Btn_Telefone
            // 
            Btn_Telefone.Location = new Point(199, 153);
            Btn_Telefone.Name = "Btn_Telefone";
            Btn_Telefone.Size = new Size(82, 37);
            Btn_Telefone.TabIndex = 7;
            Btn_Telefone.Text = "Telefone";
            Btn_Telefone.UseVisualStyleBackColor = true;
            Btn_Telefone.Click += Btn_Telefone_Click;
            // 
            // Btn_Senha
            // 
            Btn_Senha.Location = new Point(111, 153);
            Btn_Senha.Name = "Btn_Senha";
            Btn_Senha.Size = new Size(82, 37);
            Btn_Senha.TabIndex = 8;
            Btn_Senha.Text = "Senha";
            Btn_Senha.UseVisualStyleBackColor = true;
            // 
            // Btn_VerConteudo
            // 
            Btn_VerConteudo.Location = new Point(23, 196);
            Btn_VerConteudo.Name = "Btn_VerConteudo";
            Btn_VerConteudo.Size = new Size(258, 37);
            Btn_VerConteudo.TabIndex = 9;
            Btn_VerConteudo.Text = "Ver Conteúdo";
            Btn_VerConteudo.UseVisualStyleBackColor = true;
            Btn_VerConteudo.Click += Btn_VerConteudo_Click;
            // 
            // Frm_Mascara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 283);
            Controls.Add(Btn_VerConteudo);
            Controls.Add(Btn_Senha);
            Controls.Add(Btn_Telefone);
            Controls.Add(Btn_Data);
            Controls.Add(Btn_Moeda);
            Controls.Add(Btn_CEP);
            Controls.Add(Btn_Hora);
            Controls.Add(Lbl_MascaraAtiva);
            Controls.Add(Lbl_Conteudo);
            Controls.Add(Msk_TextBox);
            Name = "Frm_Mascara";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exemplos de Máscaras";
            Load += Frm_Mascara_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox Msk_TextBox;
        private Label Lbl_Conteudo;
        private Label Lbl_MascaraAtiva;
        private Button Btn_Hora;
        private Button Btn_CEP;
        private Button Btn_Moeda;
        private Button Btn_Data;
        private Button Btn_Telefone;
        private Button Btn_Senha;
        private Button Btn_VerConteudo;
    }
}
