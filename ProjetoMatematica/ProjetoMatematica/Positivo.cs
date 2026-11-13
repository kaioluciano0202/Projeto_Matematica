using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMatematica
{
    public partial class Frm_Positivo : Form
    {
        int numeroPNN; // Declarando a variável que recebe números inteiros
        public Frm_Positivo()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Abertura Abertura = new Frm_Abertura();
            Abertura.Show();
            Hide();
        }

        private void Frm_Positivo_Load(object sender, EventArgs e)
        {

        }

        private void Txt_NumeroPNN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '-'))
            {
                e.Handled = true;
                MessageBox.Show("Só é permitido números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (Txt_NumeroPNN.Text != "")
                {
                    numeroPNN = int.Parse(Txt_NumeroPNN.Text);

                    if (numeroPNN == 0)
                    {
                        MessageBox.Show("O número digitado é Neutro!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (numeroPNN > 0)
                    {
                        MessageBox.Show("O número digitado é Positívo!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O número digitado é Negativo!!!", "Resutaltado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Txt_NumeroPNN.Clear(); //Limpa o número digitado
                    Txt_NumeroPNN.Focus(); //Digitar o proximo némro
                }
                else 
                {
                    MessageBox.Show("Digite o Número!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
