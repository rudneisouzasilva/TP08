using ClassErro;

namespace TP08
{
    internal class DisciplinasBLL
    {
        public static void conecta()
        {
            DisciplinasDAL.conecta();
        }

        public static void desconecta()
        {
            DisciplinasDAL.desconecta();
        }

        public static void validaDados(Disciplina disciplina)
        {
            Class1.setErro(false);

            if (disciplina.getCodigo() == 0)
            {
                Class1.setErro(true);
                Class1.setMsg("O código é de preenchimento obrigatório!");
                return;
            }

            if (disciplina.getDescricao().Trim().Equals(""))
            {
                Class1.setErro(true);
                Class1.setMsg("A descrição é de preenchimento obrigatório!");
                return;
            }

            if (disciplina.getHoras() == 0)
            {
                Class1.setErro(true);
                Class1.setMsg("As horas são de preenchimento obrigatório!");
                return;
            }
        }

        public static void validaCodigo(Disciplina disciplina)
        {
            Class1.setErro(false);

            if (disciplina.getCodigo() == 0)
            {
                Class1.setErro(true);
                Class1.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
        }
    }
}
