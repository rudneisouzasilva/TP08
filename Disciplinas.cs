using System;
using System.Windows.Forms;
using ClassErro;

namespace TP08
{
    public partial class Disciplinas : Form
    {
        Disciplina d = new Disciplina();
        public Disciplinas()
        {
            InitializeComponent();
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            if (!validarCamposTela())
                return;

            d.setCodigo(int.Parse(mskCodigo.Text));
            d.setDescricao(txtDescricao.Text.Trim());
            d.setHoras(int.Parse(mskHoras.Text));

            DisciplinasBLL.validaDados(d);

            if (Class1.getErro())
            {
                MessageBox.Show(Class1.getMsg());
                return;
            }

            DisciplinasBLL.conecta();

            if (!Class1.getErro())
            {
                DisciplinasDAL.insereDisciplina(d);

                if (!Class1.getErro())
                {
                    MessageBox.Show("Disciplina inserida com sucesso!");
                    limparCampos();
                }
                else
                {
                    MessageBox.Show(Class1.getMsg());
                }
            }
            else
            {
                MessageBox.Show(Class1.getMsg());
            }

            DisciplinasBLL.desconecta();
        }

        private void ler_Click(object sender, EventArgs e)
        {
            if (mskCodigo.Text == "")
            {
                MessageBox.Show("Informe o código da disciplina!");
                mskCodigo.Focus();
                return;
            }

            d.setCodigo(int.Parse(mskCodigo.Text));

            DisciplinasBLL.validaCodigo(d);

            if (Class1.getErro())
            {
                MessageBox.Show(Class1.getMsg());
                return;
            }

            DisciplinasBLL.conecta();

            if (!Class1.getErro())
            {
                DisciplinasDAL.consultaDisciplina(d);

                if (!Class1.getErro())
                {
                    txtDescricao.Text = d.getDescricao();
                    mskHoras.Text = d.getHoras().ToString();
                }
                else
                {
                    MessageBox.Show(Class1.getMsg());
                }
            }
            else
            {
                MessageBox.Show(Class1.getMsg());
            }

            DisciplinasBLL.desconecta();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            if (!validarCamposTela())
                return;

            d.setCodigo(int.Parse(mskCodigo.Text));
            d.setDescricao(txtDescricao.Text.Trim());
            d.setHoras(int.Parse(mskHoras.Text));

            DisciplinasBLL.validaDados(d);

            if (Class1.getErro())
            {
                MessageBox.Show(Class1.getMsg());
                return;
            }

            DisciplinasBLL.conecta();

            if (!Class1.getErro())
            {
                DisciplinasDAL.atualizaDisciplina(d);

                if (!Class1.getErro())
                {
                    MessageBox.Show("Disciplina atualizada com sucesso!");
                    limparCampos();
                }
                else
                {
                    MessageBox.Show(Class1.getMsg());
                }
            }
            else
            {
                MessageBox.Show(Class1.getMsg());
            }

            DisciplinasBLL.desconecta();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (mskCodigo.Text == "")
            {
                MessageBox.Show("Informe o código da disciplina!");
                mskCodigo.Focus();
                return;
            }

            d.setCodigo(int.Parse(mskCodigo.Text));

            DisciplinasBLL.validaCodigo(d);

            if (Class1.getErro())
            {
                MessageBox.Show(Class1.getMsg());
                return;
            }

            DisciplinasBLL.conecta();

            if (!Class1.getErro())
            {
                DisciplinasDAL.excluiDisciplina(d);

                if (!Class1.getErro())
                {
                    MessageBox.Show("Disciplina excluída com sucesso!");
                    limparCampos();
                }
                else
                {
                    MessageBox.Show(Class1.getMsg());
                }
            }
            else
            {
                MessageBox.Show(Class1.getMsg());
            }

            DisciplinasBLL.desconecta();
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private bool validarCamposTela()
        {
            if (mskCodigo.Text == "")
            {
                MessageBox.Show("O código é obrigatório!");
                mskCodigo.Focus();
                return false;
            }

            if (txtDescricao.Text.Trim().Equals(""))
            {
                MessageBox.Show("A descrição é obrigatória!");
                txtDescricao.Focus();
                return false;
            }

            if (mskHoras.Text == "")
            {
                MessageBox.Show("As horas são obrigatórias!");
                mskHoras.Focus();
                return false;
            }

            return true;
        }

        private void limparCampos()
        {
            mskCodigo.Clear();
            txtDescricao.Clear();
            mskHoras.Clear();
            mskCodigo.Focus();
        }
    }
}