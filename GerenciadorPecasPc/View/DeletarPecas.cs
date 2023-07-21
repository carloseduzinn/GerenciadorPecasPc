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
    public partial class DeletarPecas : Form
    {
        public DeletarPecas()
        {
            InitializeComponent();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
           
                pecas.Codigo = Convert.ToInt32(textBoxdgtCod.Text);

                ManipulasPecas manipulasPecas = new ManipulasPecas();
                manipulasPecas.BuscaPecasCod();

                    textBoxcodigo.Text = pecas.Codigo.ToString();
                    txtboxpecas.Text = pecas.Peca.ToString();
                    textBoxMarca.Text = pecas.Marca.ToString();
                    textBoxCapacidade.Text = pecas.Capacidade.ToString();

            }

      
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pecas.Codigo = Convert.ToInt32(textBoxcodigo.Text);
            ManipulasPecas deletar = new ManipulasPecas();
            deletar.DeletarPecas();
        }
    }
    }
