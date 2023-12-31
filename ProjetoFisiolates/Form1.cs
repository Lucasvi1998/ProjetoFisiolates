﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //para chamar uma nova tela

namespace ProjetoFisiolates
{
    public partial class Form1 : Form
    {
        Thread nt; //como se tivesse criado uma variavel do tipo thread
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm); //novoForm é um método
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxUsuario1.Text == "" && textBoxSenha1.Text == "")
                MessageBox.Show("Logado com sucesso");
            else
                MessageBox.Show("precisa preencher os campos Usuário e senha");
        }
    }
}
