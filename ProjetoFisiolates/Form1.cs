using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFisiolates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 cad = new Form2();
            cad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxUsuario.Text == "" && textBoxSenha.Text == "")
            MessageBox.Show("Logado com sucesso");
            else
                MessageBox.Show("precisa preencher os campos Usuário e senha");
        }
    }
}
