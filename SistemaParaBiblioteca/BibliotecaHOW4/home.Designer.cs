
namespace BibliotecaHOW4
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoAlterarInativarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EmprestimoDeLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaDeLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retornoDeLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.leitorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.EmprestimoDeLivrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1347, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.manutençãoAlterarInativarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Livros";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(270, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // manutençãoAlterarInativarToolStripMenuItem
            // 
            this.manutençãoAlterarInativarToolStripMenuItem.Name = "manutençãoAlterarInativarToolStripMenuItem";
            this.manutençãoAlterarInativarToolStripMenuItem.Size = new System.Drawing.Size(270, 24);
            this.manutençãoAlterarInativarToolStripMenuItem.Text = "Manutenção (Alterar/Inativar)";
            this.manutençãoAlterarInativarToolStripMenuItem.Click += new System.EventHandler(this.manutençãoAlterarInativarToolStripMenuItem_Click);
            // 
            // leitorToolStripMenuItem
            // 
            this.leitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastarToolStripMenuItem});
            this.leitorToolStripMenuItem.Name = "leitorToolStripMenuItem";
            this.leitorToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.leitorToolStripMenuItem.Text = "Leitor";
            // 
            // cadastarToolStripMenuItem
            // 
            this.cadastarToolStripMenuItem.Name = "cadastarToolStripMenuItem";
            this.cadastarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cadastarToolStripMenuItem.Text = "Cadastar/Editar";
            this.cadastarToolStripMenuItem.Click += new System.EventHandler(this.cadastarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 24);
            this.toolStripMenuItem1.Text = "Estoque de Livros";
            // 
            // EmprestimoDeLivrosToolStripMenuItem
            // 
            this.EmprestimoDeLivrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saidaDeLivroToolStripMenuItem,
            this.retornoDeLivroToolStripMenuItem});
            this.EmprestimoDeLivrosToolStripMenuItem.Name = "EmprestimoDeLivrosToolStripMenuItem";
            this.EmprestimoDeLivrosToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.EmprestimoDeLivrosToolStripMenuItem.Text = "Empréstimo";
            this.EmprestimoDeLivrosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.EmprestimoDeLivrosToolStripMenuItem.Click += new System.EventHandler(this.estoqueDeLivrosToolStripMenuItem_Click);
            // 
            // saidaDeLivroToolStripMenuItem
            // 
            this.saidaDeLivroToolStripMenuItem.Name = "saidaDeLivroToolStripMenuItem";
            this.saidaDeLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saidaDeLivroToolStripMenuItem.Text = "Saída ";
            // 
            // retornoDeLivroToolStripMenuItem
            // 
            this.retornoDeLivroToolStripMenuItem.Name = "retornoDeLivroToolStripMenuItem";
            this.retornoDeLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.retornoDeLivroToolStripMenuItem.Text = "Retorno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1316, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1347, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoAlterarInativarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem leitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmprestimoDeLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saidaDeLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retornoDeLivroToolStripMenuItem;
    }
}