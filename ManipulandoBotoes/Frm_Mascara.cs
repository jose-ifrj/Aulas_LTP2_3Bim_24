namespace ManipulandoBotoes
{
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
            
            
            
            Msk_TextBox.KeyDown += Msk_TextBox_EventoTecla;
        }

        static string Selecionado = string.Empty;
        int NumerosInseridos = 0;
        bool DireitoParaEsquerda = (Selecionado == "moeda" | Selecionado == "telefone");

        private void Msk_TextBox_EventoTecla(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 | e.KeyCode == Keys.D0)
            {
                if(DireitoParaEsquerda)
                {
                    
                    e.Handled = true;
                }
            }
        }

        public bool ExcedeuLimite()
        {
            if (Selecionado == "moeda")
            {

            }
        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Selecionado = "hora";
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            Lbl_Conteudo.Text = Msk_TextBox.Text;
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Selecionado = "cep";
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00000-000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Selecionado = "moeda";
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "$ 000,000,000.00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "00000000000";
            
            Msk_TextBox.ReadOnly = true;
            
            Msk_TextBox.Focus();
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Selecionado = "data";
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Selecionado = "telefone";
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "(00) 0000-0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
        }

        private void Frm_Mascara_Load(object sender, EventArgs e)
        {

        }
    }
}
