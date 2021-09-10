using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Control;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            if(ControllerTeste.AdicionaPessoa(txtNome.Text, txtCpf.Text, txtRg.Text))
            {
                MessageBox.Show("Elemento inserido");
            }
            else
            {
                MessageBox.Show("Tem que inserir os valores aí");
            }
            txtNome.Clear();
            txtCpf.Clear();
            txtRg.Clear();

        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            List<string[]> lista = ControllerTeste.SelecionaPessoas();

            string mostraTexto = "";

            foreach (var item in lista)
            {
                string elemento = "";

                foreach (var item1 in item)
                {
                    elemento += (item1 + "  ");
                }
                mostraTexto += (elemento + "\n");
            }

            MessageBox.Show(mostraTexto);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
