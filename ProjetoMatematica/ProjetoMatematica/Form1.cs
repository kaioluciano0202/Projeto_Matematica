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
    public partial class Frm_Abertura : Form
    {
        public Frm_Abertura()
        {
            InitializeComponent();
        }

        private void Rad_Operacao_CheckedChanged(object sender, EventArgs e)
        {
            Frm_OperacaoAritmetica Aritmetica = new Frm_OperacaoAritmetica();
            Aritmetica.Show();
            Hide();
        }

        private void Btn_Fechar_Click_1(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Rad_Dobro_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Dobro Dobro = new Frm_Dobro();
            Dobro.Show();
            Hide();
        }

        private void Rad_ParOuImpar_CheckedChanged(object sender, EventArgs e)
        {
            Frm_ParOuImpar ParOuImpar = new Frm_ParOuImpar();
            ParOuImpar.Show();
            Hide();
        }

        private void Rad_Antecessor_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Antecessor Antecessor = new Frm_Antecessor();
            Antecessor.Show();
            Hide();
        }

        private void Rad_Positivo_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Positivo Positivo = new Frm_Positivo();
            Positivo.Show();
            Hide();
        }

        private void Lbl_Projeto_Click(object sender, EventArgs e)
        {
            
        }
    }
}
