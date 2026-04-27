using System;
using System.Data;
using System.Data.SqlClient;
using ClassErro;

namespace TP08
{
    internal class DisciplinasDAL
    {
        private static string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Disciplinas;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(strConexao);
        private static SqlCommand strSQL;
        private static SqlDataReader result;

        public static void conecta()
        {
            try
            {
                Class1.setErro(false);

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception erro)
            {
                Class1.setErro(true);
                Class1.setMsg("Problemas ao se conectar ao Banco de Dados: " + erro.Message);
            }
        }

        public static void desconecta()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public static void insereDisciplina(Disciplina disciplina)
        {
            conecta();
            try
            {
                Class1.setErro(false);

                string sql = "INSERT INTO tbDisciplinas (cd_disciplina, ds_disciplina, qt_hora) " +
                             "VALUES (@codigo, @descricao, @horas)";

                strSQL = new SqlCommand(sql, conn);

                strSQL.Parameters.Add("@codigo", SqlDbType.Int).Value = disciplina.getCodigo();
                strSQL.Parameters.Add("@descricao", SqlDbType.VarChar).Value = disciplina.getDescricao();
                strSQL.Parameters.Add("@horas", SqlDbType.Int).Value = disciplina.getHoras();

                strSQL.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                Class1.setErro(true);
                Class1.setMsg("Erro ao inserir disciplina: " + erro.Message);
            }
            desconecta();
        }

        public static void consultaDisciplina(Disciplina disciplina)
        {
            conecta();
            try
            {
                Class1.setErro(false);

                string sql = "SELECT * FROM tbDisciplinas WHERE cd_disciplina = @codigo";

                strSQL = new SqlCommand(sql, conn);
                strSQL.Parameters.Add("@codigo", SqlDbType.Int).Value = disciplina.getCodigo();

                result = strSQL.ExecuteReader();

                if (result.Read())
                {
                    disciplina.setDescricao(result["ds_disciplina"].ToString());
                    disciplina.setHoras(Convert.ToInt32(result["qt_hora"]));
                }
                else
                {
                    Class1.setErro(true);
                    Class1.setMsg("Disciplina não encontrada");
                }

                result.Close();
            }
            catch (Exception erro)
            {
                Class1.setErro(true);
                Class1.setMsg("Erro ao consultar disciplina: " + erro.Message);

                if (result != null && !result.IsClosed)
                    result.Close();
            }
            desconecta();
        }

        public static void atualizaDisciplina(Disciplina disciplina)
        {
            conecta();
            try
            {
                Class1.setErro(false);

                string sql = "UPDATE tbDisciplinas SET ds_disciplina=@descricao, qt_hora=@horas " +
                             "WHERE cd_disciplina=@codigo";

                strSQL = new SqlCommand(sql, conn);

                strSQL.Parameters.Add("@codigo", SqlDbType.Int).Value = disciplina.getCodigo();
                strSQL.Parameters.Add("@descricao", SqlDbType.VarChar).Value = disciplina.getDescricao();
                strSQL.Parameters.Add("@horas", SqlDbType.Int).Value = disciplina.getHoras();

                strSQL.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                Class1.setErro(true);
                Class1.setMsg("Erro ao atualizar disciplina: " + erro.Message);
            }
            desconecta();
        }

        public static void excluiDisciplina(Disciplina disciplina)
        {
            conecta();
            try
            {
                Class1.setErro(false);

                string sql = "DELETE FROM tbDisciplinas WHERE cd_disciplina=@codigo";

                strSQL = new SqlCommand(sql, conn);
                strSQL.Parameters.Add("@codigo", SqlDbType.Int).Value = disciplina.getCodigo();

                strSQL.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                Class1.setErro(true);
                Class1.setMsg("Erro ao excluir disciplina: " + erro.Message);
            }
            desconecta();
        }
    }
}