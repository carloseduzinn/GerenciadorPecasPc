using GerenciadorPecasPc.controler;
using GerenciadorPecasPc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorPecasPc.View
{
    public partial class TelaCadastrarPecas : Form
    {
        public TelaCadastrarPecas()
        {
            InitializeComponent();
        }

        private void btncadastrarpecas_Click(object sender, EventArgs e)
        {
            pecas.Peca = textpecas.Text;
            pecas.Marca = textBoxmarcas.Text;
            pecas.Capacidade = txtboxcapacidade.Text;

            ManipulasPecas mPeca = new ManipulasPecas();
            mPeca.CadPecas();
        }

        public void AbrirCadastro()
        {
            this.ShowDialog();
        }
                    
    }
}
