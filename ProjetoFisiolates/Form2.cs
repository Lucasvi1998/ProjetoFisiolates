using System;
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
    public partial class Form2 : Form
    {
        Thread nt; //como se tivesse criado uma variavel do tipo thread
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm); //novoForm é um método
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm() //método 
        {
            Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            MessageBox.Show("Cadastrado com sucesso");

            this.Close();
            nt = new Thread(novoForm); //novoForm é um método
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
    }
 
}
