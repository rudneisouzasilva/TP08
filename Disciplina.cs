using System;

namespace TP08
{
    internal class Disciplina
    {
        private int codigo;
        private string descricao;
        private int horas;

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public void setHoras(int horas)
        {
            this.horas = horas;
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public string getDescricao()
        {
            return this.descricao;
        }

        public int getHoras()
        {
            return this.horas;
        }
    }
}
