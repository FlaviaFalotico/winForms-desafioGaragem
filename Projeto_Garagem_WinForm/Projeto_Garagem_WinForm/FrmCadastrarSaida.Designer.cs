namespace Projeto_Garagem_WinForm
{
    partial class FrmCadastrarSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarSaida));
            this.lblCadSai = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.tbPlacaSaida = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timerSaida = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCadSai
            // 
            this.lblCadSai.BackColor = System.Drawing.Color.Transparent;
            this.lblCadSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCadSai.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSai.ForeColor = System.Drawing.Color.LightGreen;
            this.lblCadSai.Location = new System.Drawing.Point(12, 29);
            this.lblCadSai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadSai.Name = "lblCadSai";
            this.lblCadSai.Size = new System.Drawing.Size(552, 36);
            this.lblCadSai.TabIndex = 2;
            this.lblCadSai.Text = "Cadastro de Saída de Veículos";
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeparador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeparador.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSeparador.Location = new System.Drawing.Point(12, 85);
            this.lblSeparador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(654, 1);
            this.lblSeparador.TabIndex = 3;
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
            this.btFechar.Location = new System.Drawing.Point(605, 545);
            this.btFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(106, 44);
            this.btFechar.TabIndex = 6;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
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
            this.btLimpar.Location = new System.Drawing.Point(395, 401);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(122, 44);
            this.btLimpar.TabIndex = 20;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.LightGreen;
            this.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btFinalizar.FlatAppearance.BorderSize = 0;
            this.btFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.DimGray;
            this.btFinalizar.Location = new System.Drawing.Point(246, 401);
            this.btFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(122, 44);
            this.btFinalizar.TabIndex = 19;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // tbPlacaSaida
            // 
            this.tbPlacaSaida.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.tbPlacaSaida.ForeColor = System.Drawing.Color.DimGray;
            this.tbPlacaSaida.Location = new System.Drawing.Point(296, 131);
            this.tbPlacaSaida.Margin = new System.Windows.Forms.Padding(2);
            this.tbPlacaSaida.Multiline = true;
            this.tbPlacaSaida.Name = "tbPlacaSaida";
            this.tbPlacaSaida.Size = new System.Drawing.Size(176, 45);
            this.tbPlacaSaida.TabIndex = 15;
            this.tbPlacaSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlaca
            // 
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlaca.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPlaca.ForeColor = System.Drawing.Color.LightGreen;
            this.lblPlaca.Location = new System.Drawing.Point(189, 146);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(102, 24);
            this.lblPlaca.TabIndex = 14;
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoraSaida.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblHoraSaida.ForeColor = System.Drawing.Color.LightGreen;
            this.lblHoraSaida.Location = new System.Drawing.Point(168, 194);
            this.lblHoraSaida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(118, 78);
            this.lblHoraSaida.TabIndex = 24;
            this.lblHoraSaida.Text = "Horário de Saída:";
            this.lblHoraSaida.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblHoraSaida.UseCompatibleTextRendering = true;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataEntrada.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblDataEntrada.ForeColor = System.Drawing.Color.LightGreen;
            this.lblDataEntrada.Location = new System.Drawing.Point(185, 301);
            this.lblDataEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(102, 24);
            this.lblDataEntrada.TabIndex = 27;
            this.lblDataEntrada.Text = "Data:";
            this.lblDataEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.DimGray;
            this.lblHora.Location = new System.Drawing.Point(299, 210);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(175, 45);
            this.lblHora.TabIndex = 29;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.DimGray;
            this.lblData.Location = new System.Drawing.Point(299, 285);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(175, 45);
            this.lblData.TabIndex = 28;
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSaida
            // 
            this.timerSaida.Tick += new System.EventHandler(this.timerSaida_Tick);
            // 
            // FrmCadastrarSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 628);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.tbPlacaSaida);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.lblCadSai);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastrarSaida";
            this.Text = "FrmCadastrarSaida";
            this.Load += new System.EventHandler(this.FrmCadastrarSaida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCadSai;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.TextBox tbPlacaSaida;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timerSaida;
    }
}