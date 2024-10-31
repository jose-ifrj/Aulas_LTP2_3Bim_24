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
                    e.Handled = InserirNumero(0);
                    break;
                case Keys.D1 or Keys.NumPad1:
                    e.Handled = InserirNumero(1);
                    break;
                case Keys.D2 or Keys.NumPad2:
                    e.Handled = InserirNumero(2);
                    break;
                case Keys.D3 or Keys.NumPad3:
                    e.Handled = InserirNumero(3);
                    break;
                case Keys.D4 or Keys.NumPad4:
                    e.Handled = InserirNumero(4);
                    break;
                case Keys.D5 or Keys.NumPad5:
                    e.Handled = InserirNumero(5);
                    break;
                case Keys.D6 or Keys.NumPad6:
                    e.Handled = InserirNumero(6);
                    break;
                case Keys.D7 or Keys.NumPad7:
                    e.Handled = InserirNumero(7);
                    break;
                case Keys.D8 or Keys.NumPad8:
                    e.Handled = InserirNumero(8);
                    break;
                case Keys.D9 or Keys.NumPad9:
                    e.Handled = InserirNumero(9);
                    break;
                case Keys.Back:
                    e.Handled = Apagar();
                    break;
                default:
                    e.Handled = false;
                    return;
            }
        }

        private bool InserirNumero(int num)
        {
            if (ExcedeuLimite()) return false;
            if (DireitaParaEsquerda)
            {
                Inserir_DireitaParaEsquerda(num);
                return true;
            }
            if (Selecionado == "hora")
            {
                switch (NumerosInseridos)
                {
                    case 0:
                        if (num > 2) return false; break;
                    case 1:
                        if (num > 3) return false; break;
                    case 2:
                        if (num > 5) return false; break;
                    case 3:
                        if (num > 9) return false; break;
                }
                Msk_TextBox.Text = Msk_TextBox.Text.Insert(NumerosInseridos, num.ToString());
                NumerosInseridos++;
                return true;
            }
            if (Selecionado == "data")
            {
                switch (NumerosInseridos)
                {
                    case 0:
                        if (num > 3) return false; break;
                    case 1:
                        if (num > 4) return false; break;
                    case 2:
                        if (num > 1) return false; break;
                    case 3:
                        if (num > 2) return false; break;
                }
                Msk_TextBox.Text = Msk_TextBox.Text.Insert(NumerosInseridos, num.ToString());
                NumerosInseridos++;
                return true;
            }
            return false;
        }

        public bool ExcedeuLimite()
        {
            //exceção: senha nao tem limite de caractere
            if (Selecionado == "senha") return false;

            if (NumerosInseridos >= Msk_TextBox.Text.Length) return true;
            return false;
        }

        private void Inserir_DireitaParaEsquerda(int num)
        {
            int alvo = Msk_TextBox.Text.Length - NumerosInseridos;
            Msk_TextBox.Text = Msk_TextBox.Text.Remove(alvo - 1, 1);
            Msk_TextBox.Text = Msk_TextBox.Text.Insert(Msk_TextBox.Text.Length - 1, num.ToString());
            NumerosInseridos++;
        }

        private bool Apagar()
        {
            if (NumerosInseridos == 0) return false;

            if (DireitaParaEsquerda)
            {
                int alvo = Msk_TextBox.Text.Length - NumerosInseridos;
                Msk_TextBox.Text = Msk_TextBox.Text.Remove(Msk_TextBox.Text.Length - 1, 1);
                Msk_TextBox.Text = Msk_TextBox.Text.Insert(alvo - 1, "0");
            }
            else
            {
                Msk_TextBox.Text = Msk_TextBox.Text.Remove(NumerosInseridos - 1, 1);
                Msk_TextBox.Text = Msk_TextBox.Text.Insert(NumerosInseridos - 1, "0");
            }

            NumerosInseridos--;
            return true;

        }


        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Selecionado = "hora";
            NumerosInseridos = 0;

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
            if (Selecionado == "senha" && SenhaInvalida()) { return; }
            var FormatoOriginal = Msk_TextBox.CutCopyMaskFormat;
            Msk_TextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            Lbl_Conteudo.Text = Msk_TextBox.Text;
            Msk_TextBox.TextMaskFormat = FormatoOriginal;
        }

        public bool SenhaInvalida()
        {
            if (!(Msk_TextBox.Text.Any(ch => !char.IsLetterOrDigit(ch)))) {
                MessageBox.Show("Não contém caractere especial");
                return true;
            }
            if (!(Msk_TextBox.Text.Any(ch => char.IsUpper(ch)))) {
                MessageBox.Show("Não contém letra maiúscula");
                return true;
            }
            if (!(Msk_TextBox.Text.Any(ch => char.IsLower(ch))))
            {
                MessageBox.Show("Não contém letra minúscula.");
                return true;
            }
            if (!(Msk_TextBox.Text.Any(ch => char.IsNumber(ch))))
            {
                MessageBox.Show("Não contém número.");
                return true;
            }
            if (Msk_TextBox.Text.Length < 8)
            {
                MessageBox.Show("Contém menos que 8 caracteres.");
                return true;
            }
            return false;
            
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Selecionado = "cep";
            NumerosInseridos = 0;

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
            NumerosInseridos = 0;

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
            NumerosInseridos = 0;

            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "00000000";
            tamanho = Msk_TextBox.Text.Length;

            Msk_TextBox.ReadOnly = true;

            Msk_TextBox.Focus();
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Selecionado = "telefone";
            NumerosInseridos = 0;

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
            NumerosInseridos = 0;

            Msk_TextBox.UseSystemPasswordChar = false;
            Msk_TextBox.PasswordChar = '●';
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            tamanho = Msk_TextBox.Text.Length;

            Msk_TextBox.ReadOnly = false;

            Msk_TextBox.Focus();
        }

        private void Msk_TextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
