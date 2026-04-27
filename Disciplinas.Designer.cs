namespace TP08
{
    partial class Disciplinas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.mskHoras = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.inserir = new System.Windows.Forms.Button();
            this.ler = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas:";
            // 
            // mskCodigo
            // 
            this.mskCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCodigo.Location = new System.Drawing.Point(248, 47);
            this.mskCodigo.Mask = "00000";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(282, 44);
            this.mskCodigo.TabIndex = 3;
            this.mskCodigo.ValidatingType = typeof(int);
            // 
            // mskHoras
            // 
            this.mskHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskHoras.Location = new System.Drawing.Point(248, 165);
            this.mskHoras.Mask = "00000";
            this.mskHoras.Name = "mskHoras";
            this.mskHoras.Size = new System.Drawing.Size(282, 44);
            this.mskHoras.TabIndex = 4;
            this.mskHoras.ValidatingType = typeof(int);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(248, 105);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(282, 44);
            this.txtDescricao.TabIndex = 5;
            // 
            // inserir
            // 
            this.inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserir.Location = new System.Drawing.Point(98, 283);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(156, 50);
            this.inserir.TabIndex = 6;
            this.inserir.Text = "Inserir";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // ler
            // 
            this.ler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ler.Location = new System.Drawing.Point(338, 283);
            this.ler.Name = "ler";
            this.ler.Size = new System.Drawing.Size(148, 50);
            this.ler.TabIndex = 7;
            this.ler.Text = "Ler";
            this.ler.UseVisualStyleBackColor = true;
            this.ler.Click += new System.EventHandler(this.ler_Click);
            // 
            // atualizar
            // 
            this.atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.Location = new System.Drawing.Point(98, 351);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(156, 50);
            this.atualizar.TabIndex = 8;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir.Location = new System.Drawing.Point(338, 351);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(148, 50);
            this.excluir.TabIndex = 9;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // limpar
            // 
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(162, 425);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(250, 53);
            this.limpar.TabIndex = 10;
            this.limpar.Text = "Limpar campos";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // Disciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 490);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.ler);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.mskHoras);
            this.Controls.Add(this.mskCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Disciplinas";
            this.Text = "Disciplinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.MaskedTextBox mskHoras;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.Button ler;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button limpar;
    }
}

