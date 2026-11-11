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
    public partial class Frm_ParOuImpar : Form
    {
        int ParOuImpar;

        public Frm_ParOuImpar()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Abertura Abertura = new Frm_Abertura();
            Abertura.Show();
            Hide();
        }

        private void Txt_ParOuImpar_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar)) // Criando a Condição para aceitar Somente Números
            {
                e.Handled = true; // Verificando se a informação pressionada foi um número
                MessageBox.Show("Só é permitido números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) // Condição se a tecla ENTER foi pressionada
            {
                if (Txt_ParOuImpar.Text != "") // Condição para verificar se foi digitado um número
                {
                    ParOuImpar = int.Parse(Txt_ParOuImpar.Text); // A variável está Recebendo o número que foi digitado e convertido

                    if (ParOuImpar % 2 == 0) //Condição para saber se o número é par
                    {
                        MessageBox.Show("O número é par!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //Caso contrário - SENÃO o número é impar
                    {
                        MessageBox.Show("O número é impar!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Txt_ParOuImpar.Clear();
                    Txt_ParOuImpar.Focus();
                }
                else
                {
                    MessageBox.Show("Digite os Números!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Frm_ParOuImpar_Load(object sender, EventArgs e)
        {

        }
    }
}
