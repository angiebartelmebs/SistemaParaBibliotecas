
namespace BibliotecaHOW4
{
    partial class EmprestimoLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoLivro));
            this.IDsaida = new System.Windows.Forms.Label();
            this.CPFSaida = new System.Windows.Forms.Label();
            this.NomeSaida = new System.Windows.Forms.Label();
            this.telefoneSaida = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIDSaida = new System.Windows.Forms.TextBox();
            this.tbCPFsaida = new System.Windows.Forms.TextBox();
            this.tbNomeSaida = new System.Windows.Forms.TextBox();
            this.tbTelefoneSaida = new System.Windows.Forms.TextBox();
            this.tbDescricaoSaida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmailSaida = new System.Windows.Forms.TextBox();
            this.dtRetira = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtVolta = new System.Windows.Forms.DateTimePicker();
            this.dgEmprestimo = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtadeRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtadeRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.btInclui = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dUpDLivro = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // IDsaida
            // 
            this.IDsaida.AutoSize = true;
            this.IDsaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDsaida.Location = new System.Drawing.Point(43, 44);
            this.IDsaida.Name = "IDsaida";
            this.IDsaida.Size = new System.Drawing.Size(25, 21);
            this.IDsaida.TabIndex = 20;
            this.IDsaida.Text = "ID";
            this.IDsaida.UseMnemonic = false;
            // 
            // CPFSaida
            // 
            this.CPFSaida.AutoSize = true;
            this.CPFSaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFSaida.Location = new System.Drawing.Point(128, 44);
            this.CPFSaida.Name = "CPFSaida";
            this.CPFSaida.Size = new System.Drawing.Size(37, 21);
            this.CPFSaida.TabIndex = 21;
            this.CPFSaida.Text = "CPF";
            // 
            // NomeSaida
            // 
            this.NomeSaida.AutoSize = true;
            this.NomeSaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeSaida.Location = new System.Drawing.Point(392, 46);
            this.NomeSaida.Name = "NomeSaida";
            this.NomeSaida.Size = new System.Drawing.Size(52, 21);
            this.NomeSaida.TabIndex = 22;
            this.NomeSaida.Text = "Nome";
            // 
            // telefoneSaida
            // 
            this.telefoneSaida.AutoSize = true;
            this.telefoneSaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneSaida.Location = new System.Drawing.Point(43, 108);
            this.telefoneSaida.Name = "telefoneSaida";
            this.telefoneSaida.Size = new System.Drawing.Size(67, 21);
            this.telefoneSaida.TabIndex = 23;
            this.telefoneSaida.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Descrição";
            // 
            // tbIDSaida
            // 
            this.tbIDSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDSaida.Location = new System.Drawing.Point(44, 70);
            this.tbIDSaida.Name = "tbIDSaida";
            this.tbIDSaida.Size = new System.Drawing.Size(54, 24);
            this.tbIDSaida.TabIndex = 25;
            // 
            // tbCPFsaida
            // 
            this.tbCPFsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPFsaida.Location = new System.Drawing.Point(132, 70);
            this.tbCPFsaida.Name = "tbCPFsaida";
            this.tbCPFsaida.Size = new System.Drawing.Size(235, 24);
            this.tbCPFsaida.TabIndex = 26;
            // 
            // tbNomeSaida
            // 
            this.tbNomeSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeSaida.Location = new System.Drawing.Point(396, 70);
            this.tbNomeSaida.Name = "tbNomeSaida";
            this.tbNomeSaida.Size = new System.Drawing.Size(321, 24);
            this.tbNomeSaida.TabIndex = 27;
            // 
            // tbTelefoneSaida
            // 
            this.tbTelefoneSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefoneSaida.Location = new System.Drawing.Point(44, 132);
            this.tbTelefoneSaida.Name = "tbTelefoneSaida";
            this.tbTelefoneSaida.Size = new System.Drawing.Size(168, 24);
            this.tbTelefoneSaida.TabIndex = 28;
            // 
            // tbDescricaoSaida
            // 
            this.tbDescricaoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricaoSaida.Location = new System.Drawing.Point(439, 277);
            this.tbDescricaoSaida.Multiline = true;
            this.tbDescricaoSaida.Name = "tbDescricaoSaida";
            this.tbDescricaoSaida.Size = new System.Drawing.Size(369, 83);
            this.tbDescricaoSaida.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "E-mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEmailSaida
            // 
            this.tbEmailSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailSaida.Location = new System.Drawing.Point(246, 132);
            this.tbEmailSaida.Name = "tbEmailSaida";
            this.tbEmailSaida.Size = new System.Drawing.Size(281, 24);
            this.tbEmailSaida.TabIndex = 31;
            this.tbEmailSaida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtRetira
            // 
            this.dtRetira.Location = new System.Drawing.Point(44, 199);
            this.dtRetira.Name = "dtRetira";
            this.dtRetira.Size = new System.Drawing.Size(202, 20);
            this.dtRetira.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Data de Retirada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data de Retorno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtVolta
            // 
            this.dtVolta.Location = new System.Drawing.Point(269, 199);
            this.dtVolta.Name = "dtVolta";
            this.dtVolta.Size = new System.Drawing.Size(202, 20);
            this.dtVolta.TabIndex = 35;
            // 
            // dgEmprestimo
            // 
            this.dgEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNome,
            this.ColLivro,
            this.ColDtadeRetirada,
            this.ColDtadeRetorno,
            this.ColObs});
            this.dgEmprestimo.Location = new System.Drawing.Point(12, 398);
            this.dgEmprestimo.Name = "dgEmprestimo";
            this.dgEmprestimo.Size = new System.Drawing.Size(870, 165);
            this.dgEmprestimo.TabIndex = 54;
            this.dgEmprestimo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.FillWeight = 10F;
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Width = 50;
            // 
            // ColNome
            // 
            this.ColNome.FillWeight = 200F;
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.Width = 250;
            // 
            // ColLivro
            // 
            this.ColLivro.FillWeight = 200F;
            this.ColLivro.HeaderText = "Livro";
            this.ColLivro.Name = "ColLivro";
            this.ColLivro.Width = 250;
            // 
            // ColDtadeRetirada
            // 
            this.ColDtadeRetirada.FillWeight = 20F;
            this.ColDtadeRetirada.HeaderText = "Data de Retirada";
            this.ColDtadeRetirada.Name = "ColDtadeRetirada";
            this.ColDtadeRetirada.Width = 80;
            // 
            // ColDtadeRetorno
            // 
            this.ColDtadeRetorno.FillWeight = 20F;
            this.ColDtadeRetorno.HeaderText = "Data de Retorno";
            this.ColDtadeRetorno.Name = "ColDtadeRetorno";
            this.ColDtadeRetorno.Width = 80;
            // 
            // ColObs
            // 
            this.ColObs.FillWeight = 350F;
            this.ColObs.HeaderText = "Observação";
            this.ColObs.Name = "ColObs";
            this.ColObs.Width = 300;
            // 
            // btPesquisa
            // 
            this.btPesquisa.BackColor = System.Drawing.Color.LightCyan;
            this.btPesquisa.BackgroundImage = global::BibliotecaHOW4.Properties.Resources.seo;
            this.btPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisa.Location = new System.Drawing.Point(817, 199);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(47, 45);
            this.btPesquisa.TabIndex = 56;
            this.btPesquisa.UseVisualStyleBackColor = false;
            // 
            // btInclui
            // 
            this.btInclui.BackColor = System.Drawing.Color.LightCyan;
            this.btInclui.BackgroundImage = global::BibliotecaHOW4.Properties.Resources.add_file;
            this.btInclui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInclui.FlatAppearance.BorderColor = System.Drawing.Color.LightCyan;
            this.btInclui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInclui.Location = new System.Drawing.Point(818, 139);
            this.btInclui.Name = "btInclui";
            this.btInclui.Size = new System.Drawing.Size(46, 51);
            this.btInclui.TabIndex = 55;
            this.btInclui.UseVisualStyleBackColor = false;
            this.btInclui.Click += new System.EventHandler(this.btInclui_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Livro";
            // 
            // dUpDLivro
            // 
            this.dUpDLivro.Location = new System.Drawing.Point(47, 277);
            this.dUpDLivro.Name = "dUpDLivro";
            this.dUpDLivro.Size = new System.Drawing.Size(323, 20);
            this.dUpDLivro.TabIndex = 58;
            // 
            // EmprestimoLivro
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(894, 598);
            this.Controls.Add(this.dUpDLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btPesquisa);
            this.Controls.Add(this.btInclui);
            this.Controls.Add(this.dgEmprestimo);
            this.Controls.Add(this.dtVolta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtRetira);
            this.Controls.Add(this.tbEmailSaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescricaoSaida);
            this.Controls.Add(this.tbTelefoneSaida);
            this.Controls.Add(this.tbNomeSaida);
            this.Controls.Add(this.tbCPFsaida);
            this.Controls.Add(this.tbIDSaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefoneSaida);
            this.Controls.Add(this.NomeSaida);
            this.Controls.Add(this.CPFSaida);
            this.Controls.Add(this.IDsaida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmprestimoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saída de Livro";
            this.Load += new System.EventHandler(this.EmprestimoLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDsaida;
        private System.Windows.Forms.Label CPFSaida;
        private System.Windows.Forms.Label NomeSaida;
        private System.Windows.Forms.Label telefoneSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIDSaida;
        private System.Windows.Forms.TextBox tbCPFsaida;
        private System.Windows.Forms.TextBox tbNomeSaida;
        private System.Windows.Forms.TextBox tbTelefoneSaida;
        private System.Windows.Forms.TextBox tbDescricaoSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmailSaida;
        private System.Windows.Forms.DateTimePicker dtRetira;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtVolta;
        private System.Windows.Forms.DataGridView dgEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtadeRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtadeRetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObs;
        private System.Windows.Forms.Button btInclui;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown dUpDLivro;
    }
}