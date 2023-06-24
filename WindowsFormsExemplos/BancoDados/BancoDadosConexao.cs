﻿using System.Data.SqlClient;

namespace WindowsFormsExemplos.BancoDados
{
    public class BancoDadosConexao
    {
        public SqlCommand Conectar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Familia\Documents\Leilane\Projeto\proway-curso-c-sharp-lc1-2023-04-main\WindowsFormsExemplos\BancoDados\WindowsFormsBancoDados.mdf;Integrated Security=True";
            conexao.Open();

            var comando = conexao.CreateCommand();

            return comando;
        }
    }
}
