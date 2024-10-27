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
        int tamanho;
        int NumerosInseridos = 0;
        bool DireitaParaEsquerda => (Selecionado == "moeda" | Selecionado == "telefone");

        private void Msk_TextBox_EventoTecla(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0 or Keys.NumPad0:
                    InserirNumero(0);
                    break;
                case Keys.D1 or Keys.NumPad1:
                    InserirNumero(1);
                    break;
                case Keys.D2 or Keys.NumPad2:
                    InserirNumero(2);
                    break;
                case Keys.D3 or Keys.NumPad3:
                    InserirNumero(3);
                    break;
                case Keys.D4 or Keys.NumPad4:
                    InserirNumero(4);
                    break;
                case Keys.D5 or Keys.NumPad5:
                    InserirNumero(5);
                    break;
                case Keys.D6 or Keys.NumPad6:
                    InserirNumero(6);
                    break;
                case Keys.D7 or Keys.NumPad7:
                    InserirNumero(7);
                    break;
                case Keys.D8 or Keys.NumPad8:
                    InserirNumero(8);
                    break;
                case Keys.D9 or Keys.NumPad9:
                    InserirNumero(9);
                    break;
                case Keys.Back:
                    Apagar_DireitaParaEsquerda();
                    break;
                default:
                    e.Handled = false;
                    return;
            }
        }

        private void InserirNumero(int num)
        {
            if (DireitaParaEsquerda)
            {
                if (ExcedeuLimite()) return;
                Inserir_DireitaParaEsquerda(num);
            }
            if (Selecionado == "hora")
            {

            }
        }

        public bool ExcedeuLimite()
        {
            if (NumerosInseridos >= Msk_TextBox.Text.Length) return true;
            return false;
        }

        private void Inserir_DireitaParaEsquerda(int num)
        {
            int alvo = Msk_TextBox.Text.Length - NumerosInseridos;
            //string temp = ;
            Msk_TextBox.Text = Msk_TextBox.Text.Remove(alvo - 1, 1);
            Msk_TextBox.Text = Msk_TextBox.Text.Insert(Msk_TextBox.Text.Length - 1, num.ToString());
            //Msk_TextBox.Text = temp;
            NumerosInseridos++;
        }

        private void Apagar_DireitaParaEsquerda()
        {
            int alvo = Msk_TextBox.Text.Length - NumerosInseridos;
            Msk_TextBox.Text = Msk_TextBox.Text.Remove(Msk_TextBox.Text.Length - 1, 1);
            Msk_TextBox.Text = Msk_TextBox.Text.Insert(alvo - 1, "0");
            NumerosInseridos--;
        }


        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Selecionado = "hora";
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "0000";
            tamanho = Msk_TextBox.Text.Length;

            Msk_TextBox.ReadOnly = true;

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
            Msk_TextBox.Text = "00000000";
            tamanho = Msk_TextBox.Text.Length;

            Msk_TextBox.ReadOnly = false;

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
            tamanho = Msk_TextBox.Text.Length;

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
            Msk_TextBox.Text = "00000000";
            tamanho = Msk_TextBox.Text.Length;

            Msk_TextBox.ReadOnly = false;

            Msk_TextBox.Focus();
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Selecionado = "telefone";
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "(00) 0000-0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "0000000000";
            tamanho = Msk_TextBox.Text.Length;

            Msk_TextBox.ReadOnly = true;

            Msk_TextBox.Focus();
        }

        private void Frm_Mascara_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Selecionado = "senha";
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "0000000000";
            tamanho = Msk_TextBox.Text.Length;

            Msk_TextBox.ReadOnly = true;

            Msk_TextBox.Focus();
        }
    }
}
