namespace Projeto_Garagem_WinForm
{
    partial class FrmCadastrarEntrada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarEntrada));
            this.lblFrmCadEnt = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.tbPlacaEntrada = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerEntrada = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFrmCadEnt
            // 
            this.lblFrmCadEnt.BackColor = System.Drawing.Color.Transparent;
            this.lblFrmCadEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFrmCadEnt.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmCadEnt.ForeColor = System.Drawing.Color.LightGreen;
            this.lblFrmCadEnt.Location = new System.Drawing.Point(12, 30);
            this.lblFrmCadEnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrmCadEnt.Name = "lblFrmCadEnt";
            this.lblFrmCadEnt.Size = new System.Drawing.Size(552, 36);
            this.lblFrmCadEnt.TabIndex = 0;
            this.lblFrmCadEnt.Text = "Cadastro de Entrada de Veículos";
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeparador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeparador.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSeparador.Location = new System.Drawing.Point(12, 88);
            this.lblSeparador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(654, 1);
            this.lblSeparador.TabIndex = 1;
            // 
            // lblPlaca
            // 
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlaca.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPlaca.ForeColor = System.Drawing.Color.LightGreen;
            this.lblPlaca.Location = new System.Drawing.Point(180, 149);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(102, 24);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.LightGreen;
            this.btFechar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.DimGray;
            this.btFechar.Location = new System.Drawing.Point(606, 542);
            this.btFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(106, 44);
            this.btFechar.TabIndex = 5;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // tbPlacaEntrada
            // 
            this.tbPlacaEntrada.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbPlacaEntrada.ForeColor = System.Drawing.Color.DimGray;
            this.tbPlacaEntrada.Location = new System.Drawing.Point(299, 142);
            this.tbPlacaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.tbPlacaEntrada.Multiline = true;
            this.tbPlacaEntrada.Name = "tbPlacaEntrada";
            this.tbPlacaEntrada.Size = new System.Drawing.Size(174, 44);
            this.tbPlacaEntrada.TabIndex = 1;
            this.tbPlacaEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.btCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.DimGray;
            this.btCadastrar.Location = new System.Drawing.Point(229, 415);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(122, 44);
            this.btCadastrar.TabIndex = 11;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.LightGreen;
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.DimGray;
            this.btLimpar.Location = new System.Drawing.Point(404, 415);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(122, 44);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblHoraEntrada.ForeColor = System.Drawing.Color.LightGreen;
            this.lblHoraEntrada.Location = new System.Drawing.Point(136, 200);
            this.lblHoraEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(146, 78);
            this.lblHoraEntrada.TabIndex = 13;
            this.lblHoraEntrada.Text = "Horário de Entrada:";
            this.lblHoraEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHoraEntrada.UseCompatibleTextRendering = true;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataEntrada.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDataEntrada.ForeColor = System.Drawing.Color.LightGreen;
            this.lblDataEntrada.Location = new System.Drawing.Point(179, 308);
            this.lblDataEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(102, 24);
            this.lblDataEntrada.TabIndex = 14;
            this.lblDataEntrada.Text = "Data:";
            this.lblDataEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.DimGray;
            this.lblData.Location = new System.Drawing.Point(299, 292);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(175, 45);
            this.lblData.TabIndex = 15;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.DimGray;
            this.lblHora.Location = new System.Drawing.Point(299, 218);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(175, 45);
            this.lblHora.TabIndex = 16;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerEntrada
            // 
            this.timerEntrada.Enabled = true;
            this.timerEntrada.Tick += new System.EventHandler(this.timerEntrada_Tick);
            // 
            // FrmCadastrarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 628);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbPlacaEntrada);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.lblFrmCadEnt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastrarEntrada";
            this.Text = "FrmCadastrar";
            this.Load += new System.EventHandler(this.FrmCadastrarEntrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrmCadEnt;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.TextBox tbPlacaEntrada;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerEntrada;
    }
}