namespace Projeto_Garagem_WinForm
{
    partial class Form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btCadSaida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadEntrada = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.lbl_Etq = new System.Windows.Forms.Label();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.picbx_Logo = new System.Windows.Forms.PictureBox();
            this.bt_Consultar = new System.Windows.Forms.Button();
            this.bt_Home = new System.Windows.Forms.Button();
            this.lblBemVindo1 = new System.Windows.Forms.Label();
            this.lblBemVindo2 = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pnl_Principal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Logo)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.BackColor = System.Drawing.Color.LightGreen;
            this.pnl_Principal.Controls.Add(this.panelMenu);
            this.pnl_Principal.Controls.Add(this.lbl_Etq);
            this.pnl_Principal.Controls.Add(this.bt_Cadastrar);
            this.pnl_Principal.Controls.Add(this.picbx_Logo);
            this.pnl_Principal.Controls.Add(this.bt_Consultar);
            this.pnl_Principal.Controls.Add(this.bt_Home);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_Principal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(198, 509);
            this.pnl_Principal.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightGreen;
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btCadSaida);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btCadEntrada);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btConsultar);
            this.panelMenu.Controls.Add(this.btHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(198, 509);
            this.panelMenu.TabIndex = 4;
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.DimGray;
            this.btSair.Location = new System.Drawing.Point(0, 395);
            this.btSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(194, 80);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCadSaida
            // 
            this.btCadSaida.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btCadSaida.FlatAppearance.BorderSize = 0;
            this.btCadSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btCadSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCadSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadSaida.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadSaida.ForeColor = System.Drawing.Color.DimGray;
            this.btCadSaida.Location = new System.Drawing.Point(1, 226);
            this.btCadSaida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadSaida.Name = "btCadSaida";
            this.btCadSaida.Size = new System.Drawing.Size(194, 80);
            this.btCadSaida.TabIndex = 4;
            this.btCadSaida.Text = "Cadastrar Saída";
            this.btCadSaida.UseVisualStyleBackColor = true;
            this.btCadSaida.Click += new System.EventHandler(this.btCadSaida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(9, 485);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "© 2022 GaraGeek. All rights reserved.";
            // 
            // btCadEntrada
            // 
            this.btCadEntrada.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btCadEntrada.FlatAppearance.BorderSize = 0;
            this.btCadEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btCadEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCadEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadEntrada.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadEntrada.ForeColor = System.Drawing.Color.DimGray;
            this.btCadEntrada.Location = new System.Drawing.Point(2, 141);
            this.btCadEntrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadEntrada.Name = "btCadEntrada";
            this.btCadEntrada.Size = new System.Drawing.Size(194, 80);
            this.btCadEntrada.TabIndex = 1;
            this.btCadEntrada.Text = "Cadastrar Entrada";
            this.btCadEntrada.UseVisualStyleBackColor = true;
            this.btCadEntrada.Click += new System.EventHandler(this.btCadEntrada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btConsultar.FlatAppearance.BorderSize = 0;
            this.btConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.ForeColor = System.Drawing.Color.DimGray;
            this.btConsultar.Location = new System.Drawing.Point(0, 310);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(194, 80);
            this.btConsultar.TabIndex = 2;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btHome
            // 
            this.btHome.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.DimGray;
            this.btHome.Location = new System.Drawing.Point(2, 57);
            this.btHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(194, 80);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // lbl_Etq
            // 
            this.lbl_Etq.AutoSize = true;
            this.lbl_Etq.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_Etq.Location = new System.Drawing.Point(9, 471);
            this.lbl_Etq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Etq.Name = "lbl_Etq";
            this.lbl_Etq.Size = new System.Drawing.Size(187, 13);
            this.lbl_Etq.TabIndex = 3;
            this.lbl_Etq.Text = "© 2022 GaraGeek. All rights reserved.";
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bt_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.bt_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cadastrar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_Cadastrar.Location = new System.Drawing.Point(2, 155);
            this.bt_Cadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(194, 80);
            this.bt_Cadastrar.TabIndex = 1;
            this.bt_Cadastrar.Text = "Cadastrar Entrada";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // picbx_Logo
            // 
            this.picbx_Logo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.picbx_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_Logo.BackgroundImage")));
            this.picbx_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_Logo.Location = new System.Drawing.Point(4, 4);
            this.picbx_Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picbx_Logo.Name = "picbx_Logo";
            this.picbx_Logo.Size = new System.Drawing.Size(191, 48);
            this.picbx_Logo.TabIndex = 0;
            this.picbx_Logo.TabStop = false;
            // 
            // bt_Consultar
            // 
            this.bt_Consultar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bt_Consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.bt_Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Consultar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Consultar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_Consultar.Location = new System.Drawing.Point(0, 377);
            this.bt_Consultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Consultar.Name = "bt_Consultar";
            this.bt_Consultar.Size = new System.Drawing.Size(194, 80);
            this.bt_Consultar.TabIndex = 2;
            this.bt_Consultar.Text = "Consultar";
            this.bt_Consultar.UseVisualStyleBackColor = true;
            // 
            // bt_Home
            // 
            this.bt_Home.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bt_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.bt_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Home.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Home.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bt_Home.Location = new System.Drawing.Point(2, 71);
            this.bt_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Home.Name = "bt_Home";
            this.bt_Home.Size = new System.Drawing.Size(194, 80);
            this.bt_Home.TabIndex = 0;
            this.bt_Home.Text = "Home";
            this.bt_Home.UseVisualStyleBackColor = true;
            // 
            // lblBemVindo1
            // 
            this.lblBemVindo1.AutoSize = true;
            this.lblBemVindo1.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblBemVindo1.ForeColor = System.Drawing.Color.LightGreen;
            this.lblBemVindo1.Location = new System.Drawing.Point(182, 84);
            this.lblBemVindo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBemVindo1.Name = "lblBemVindo1";
            this.lblBemVindo1.Size = new System.Drawing.Size(291, 25);
            this.lblBemVindo1.TabIndex = 0;
            this.lblBemVindo1.Text = "Bem-vindo(a) ao GaraGekeek!";
            // 
            // lblBemVindo2
            // 
            this.lblBemVindo2.AutoSize = true;
            this.lblBemVindo2.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblBemVindo2.ForeColor = System.Drawing.Color.LightGreen;
            this.lblBemVindo2.Location = new System.Drawing.Point(104, 366);
            this.lblBemVindo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBemVindo2.Name = "lblBemVindo2";
            this.lblBemVindo2.Size = new System.Drawing.Size(455, 25);
            this.lblBemVindo2.TabIndex = 1;
            this.lblBemVindo2.Text = "O melhor sitema de controle de Estacionamento!";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.Controls.Add(this.lblBemVindo2);
            this.panelForm.Controls.Add(this.lblBemVindo1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(198, 0);
            this.panelForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(607, 509);
            this.panelForm.TabIndex = 1;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 509);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.pnl_Principal);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Principal";
            this.Text = "GaraGeek";
            this.pnl_Principal.ResumeLayout(false);
            this.pnl_Principal.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Logo)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Principal;
        private System.Windows.Forms.PictureBox picbx_Logo;
        private System.Windows.Forms.Button bt_Home;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Consultar;
        private System.Windows.Forms.Label lbl_Etq;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadEntrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btCadSaida;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lblBemVindo1;
        private System.Windows.Forms.Label lblBemVindo2;
        private System.Windows.Forms.Panel panelForm;
    }
}

