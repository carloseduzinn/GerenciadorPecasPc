using GerenciadorPecasPc.Model;
using GerenciadorPecasPc.View;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPecasPc.controler
{
    internal class ManipulasPecas
    {
        public void CadPecas()
        {
            SqlConnection cn =new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PcadastrarPecas",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Pecas", pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidades", pecas.Capacidade);

                SqlParameter nv = cmd.Parameters.Add("IdPecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça cadastrada com sucesso, Deseja cadastrar outra peça?",
                    "Novo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    TelaCadastrarPecas telaCadastrar = new TelaCadastrarPecas();
                    telaCadastrar.AbrirCadastro();
                }

                else
                {
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void BuscaPecasCod()
        { 

                 SqlConnection cn = new SqlConnection(conexao.Conectar());
                 SqlCommand cmd = new SqlCommand("pBuscaPecasCodigo", cn);
                 cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdPecas", pecas.Codigo);
                cn.Open();

                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    pecas.Codigo = Convert.ToInt32(registros["IdPecas"]);
                    pecas.Peca =(string) registros["Pecas"];             
                    pecas.Marca = (string)registros["Marcas"];
                    pecas.Capacidade = (string)registros["Capacidades"];
                }
                else {

                    pecas.Codigo = 0;
                    pecas.Peca = "";
                    pecas.Marca = "";
                    pecas.Capacidade = "";
                    MessageBox.Show("Peça não encontrada", "Pesquisa Código");
                }

               
            }

            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarPecas()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("idPecas", pecas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça deletada com sucesso, Deseja deletar outra peça?",
                    "Deletar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void alterarPecas()
        {

            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.AddWithValue("@IdPecas", pecas.Codigo);
                cmd.Parameters.AddWithValue("Pecas", pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidades", pecas.Capacidade);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Peça alterada com sucesso");
                pecas.Codigo = 0;
                pecas.Peca = "";
                pecas.Marca = "";
                pecas.Capacidade = "";
            }
            catch (Exception)
            {

                throw;
            }

            }

       }

    }


