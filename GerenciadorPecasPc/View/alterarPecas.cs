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
    public partial class alterarPecas : Form
    {
        public alterarPecas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pecas.Codigo = Convert.ToInt32(textBoxCodigo.Text);
            pecas.Peca = textBoxPecas.Text;
            pecas.Marca= textBoxMarca.Text;
            pecas.Capacidade= textBoxCapacidade.Text;

            ManipulasPecas manipulas = new ManipulasPecas();
            manipulas.alterarPecas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pecas.Codigo = Convert.ToInt32(textBoxCodigo.Text);

            ManipulasPecas manipulasPecas = new ManipulasPecas();
            manipulasPecas.BuscaPecasCod();

            textBoxCodigoVer.Text = pecas.Codigo.ToString();
            textBoxPecas.Text = pecas.Peca.ToString();
            textBoxMarca.Text = pecas.Marca.ToString();
            textBoxCapacidade.Text = pecas.Capacidade.ToString();
        }
    }
}
