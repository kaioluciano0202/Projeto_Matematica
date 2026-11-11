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
    public partial class Frm_Dobro : Form
    { 
       int numero_dobro; //Criando a variável (Guardar Informação)

        public Frm_Dobro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Abertura Abertura = new Frm_Abertura();
            Abertura.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_Abertura Abertura = new Frm_Abertura();
            Abertura.Show();
            Hide();
        }

        private void Frm_Dobro_Load(object sender, EventArgs e)
        {

        }

        private void Txt_NumDobro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_NumDobro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar)) // Criando a Condição para aceitar Somente Números
            {
                e.Handled = true; // Verificando se a informação pressionada foi um número
                MessageBox.Show("Só é permitido digitar números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); // Aviso na tela
            }
            if (e.KeyChar == 13) // Condição se a tecla ENTER foi pressionada
            {
                if (Txt_NumDobro.Text != "") // Condição para verificar se foi digitado um número
                {
                    numero_dobro = int.Parse(Txt_NumDobro.Text); // A variável está Recebendo o número que foi digitado e convertido
                    numero_dobro = numero_dobro * 2; // Cálculo do número
                    MessageBox.Show("O Dobro é: " + numero_dobro, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mostando o Resultado
                    Txt_NumDobro.Clear(); // Limpando o Número que foi Digitado
                    Txt_NumDobro.Focus(); // Deixar o cursor para digitar o próximo número
                }
                else // Se não for digitado nada - Inverso do IF (Condição Verdadeira)
                {
                    MessageBox.Show("Digite um Número!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
