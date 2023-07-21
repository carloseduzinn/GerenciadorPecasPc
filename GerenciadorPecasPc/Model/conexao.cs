using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPecasPc.Model
{
    internal class conexao
    {
       public static string Conectar() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlos.efspires\source\repos\GerenciadorPecasPc\GerenciadorPecasPc\Model\pecaspcbd.mdf;Integrated Security=True";
        }
    }
}
