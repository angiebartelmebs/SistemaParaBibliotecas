
namespace BibliotecaHOW4
{
    partial class RetornoLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetornoLivro));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmailSaida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTelefoneSaida = new System.Windows.Forms.TextBox();
            this.tbNomeSaida = new System.Windows.Forms.TextBox();
            this.tbCPFsaida = new System.Windows.Forms.TextBox();
            this.tbIDSaida = new System.Windows.Forms.TextBox();
            this.telefoneSaida = new System.Windows.Forms.Label();
            this.NomeSaida = new System.Windows.Forms.Label();
            this.CPFSaida = new System.Windows.Forms.Label();
            this.IDsaida = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtadeRetirada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtadeRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNome,
            this.ColLivro,
            this.ColDtadeRetirada,
            this.ColDtadeRetorno,
            this.ColObs});
            this.dataGridView1.Location = new System.Drawing.Point(12, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 165);
            this.dataGridView1.TabIndex = 53;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(261, 193);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker2.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Data de Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbEmailSaida
            // 
            this.tbEmailSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailSaida.Location = new System.Drawing.Point(261, 125);
            this.tbEmailSaida.Name = "tbEmailSaida";
            this.tbEmailSaida.Size = new System.Drawing.Size(281, 24);
            this.tbEmailSaida.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "E-mail";
            // 
            // tbTelefoneSaida
            // 
            this.tbTelefoneSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefoneSaida.Location = new System.Drawing.Point(59, 125);
            this.tbTelefoneSaida.Name = "tbTelefoneSaida";
            this.tbTelefoneSaida.Size = new System.Drawing.Size(168, 24);
            this.tbTelefoneSaida.TabIndex = 45;
            // 
            // tbNomeSaida
            // 
            this.tbNomeSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeSaida.Location = new System.Drawing.Point(411, 63);
            this.tbNomeSaida.Name = "tbNomeSaida";
            this.tbNomeSaida.Size = new System.Drawing.Size(321, 24);
            this.tbNomeSaida.TabIndex = 44;
            // 
            // tbCPFsaida
            // 
            this.tbCPFsaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPFsaida.Location = new System.Drawing.Point(147, 63);
            this.tbCPFsaida.Name = "tbCPFsaida";
            this.tbCPFsaida.Size = new System.Drawing.Size(235, 24);
            this.tbCPFsaida.TabIndex = 43;
            // 
            // tbIDSaida
            // 
            this.tbIDSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDSaida.Location = new System.Drawing.Point(59, 63);
            this.tbIDSaida.Name = "tbIDSaida";
            this.tbIDSaida.Size = new System.Drawing.Size(54, 24);
            this.tbIDSaida.TabIndex = 42;
            // 
            // telefoneSaida
            // 
            this.telefoneSaida.AutoSize = true;
            this.telefoneSaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneSaida.Location = new System.Drawing.Point(58, 101);
            this.telefoneSaida.Name = "telefoneSaida";
            this.telefoneSaida.Size = new System.Drawing.Size(67, 21);
            this.telefoneSaida.TabIndex = 40;
            this.telefoneSaida.Text = "Telefone";
            // 
            // NomeSaida
            // 
            this.NomeSaida.AutoSize = true;
            this.NomeSaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeSaida.Location = new System.Drawing.Point(407, 39);
            this.NomeSaida.Name = "NomeSaida";
            this.NomeSaida.Size = new System.Drawing.Size(52, 21);
            this.NomeSaida.TabIndex = 39;
            this.NomeSaida.Text = "Nome";
            // 
            // CPFSaida
            // 
            this.CPFSaida.AutoSize = true;
            this.CPFSaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFSaida.Location = new System.Drawing.Point(143, 37);
            this.CPFSaida.Name = "CPFSaida";
            this.CPFSaida.Size = new System.Drawing.Size(37, 21);
            this.CPFSaida.TabIndex = 38;
            this.CPFSaida.Text = "CPF";
            // 
            // IDsaida
            // 
            this.IDsaida.AutoSize = true;
            this.IDsaida.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDsaida.Location = new System.Drawing.Point(58, 37);
            this.IDsaida.Name = "IDsaida";
            this.IDsaida.Size = new System.Drawing.Size(25, 21);
            this.IDsaida.TabIndex = 37;
            this.IDsaida.Text = "ID";
            this.IDsaida.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(261, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 24);
            this.textBox1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "Multa";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(59, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 24);
            this.textBox2.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "Valor";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(59, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 24);
            this.textBox3.TabIndex = 58;
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
            // RetornoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(894, 598);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmailSaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTelefoneSaida);
            this.Controls.Add(this.tbNomeSaida);
            this.Controls.Add(this.tbCPFsaida);
            this.Controls.Add(this.tbIDSaida);
            this.Controls.Add(this.telefoneSaida);
            this.Controls.Add(this.NomeSaida);
            this.Controls.Add(this.CPFSaida);
            this.Controls.Add(this.IDsaida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RetornoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retorno de Livro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmailSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefoneSaida;
        private System.Windows.Forms.TextBox tbNomeSaida;
        private System.Windows.Forms.TextBox tbCPFsaida;
        private System.Windows.Forms.TextBox tbIDSaida;
        private System.Windows.Forms.Label telefoneSaida;
        private System.Windows.Forms.Label NomeSaida;
        private System.Windows.Forms.Label CPFSaida;
        private System.Windows.Forms.Label IDsaida;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtadeRetirada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtadeRetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObs;
    }
}