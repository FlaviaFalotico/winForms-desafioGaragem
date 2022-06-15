namespace Projeto_Garagem_WinForm
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            this.lblConsult = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.tbListaEntrada = new System.Windows.Forms.TextBox();
            this.tbListaSaida = new System.Windows.Forms.TextBox();
            this.lblVeiculosEstacionados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConsult
            // 
            this.lblConsult.BackColor = System.Drawing.Color.Transparent;
            this.lblConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConsult.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsult.ForeColor = System.Drawing.Color.LightGreen;
            this.lblConsult.Location = new System.Drawing.Point(12, 29);
            this.lblConsult.Name = "lblConsult";
            this.lblConsult.Size = new System.Drawing.Size(552, 36);
            this.lblConsult.TabIndex = 4;
            this.lblConsult.Text = "Consultar Veículos";
            // 
            // lblSeparador
            // 
            this.lblSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeparador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeparador.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSeparador.Location = new System.Drawing.Point(13, 85);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(655, 1);
            this.lblSeparador.TabIndex = 5;
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
            this.btFechar.Location = new System.Drawing.Point(607, 550);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(106, 44);
            this.btFechar.TabIndex = 6;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // tbListaEntrada
            // 
            this.tbListaEntrada.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListaEntrada.ForeColor = System.Drawing.Color.DimGray;
            this.tbListaEntrada.Location = new System.Drawing.Point(34, 126);
            this.tbListaEntrada.Multiline = true;
            this.tbListaEntrada.Name = "tbListaEntrada";
            this.tbListaEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaEntrada.Size = new System.Drawing.Size(684, 178);
            this.tbListaEntrada.TabIndex = 7;
            // 
            // tbListaSaida
            // 
            this.tbListaSaida.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListaSaida.ForeColor = System.Drawing.Color.DimGray;
            this.tbListaSaida.Location = new System.Drawing.Point(31, 347);
            this.tbListaSaida.Multiline = true;
            this.tbListaSaida.Name = "tbListaSaida";
            this.tbListaSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaSaida.Size = new System.Drawing.Size(684, 178);
            this.tbListaSaida.TabIndex = 8;
            // 
            // lblVeiculosEstacionados
            // 
            this.lblVeiculosEstacionados.BackColor = System.Drawing.Color.Transparent;
            this.lblVeiculosEstacionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVeiculosEstacionados.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblVeiculosEstacionados.ForeColor = System.Drawing.Color.LightGreen;
            this.lblVeiculosEstacionados.Location = new System.Drawing.Point(29, 96);
            this.lblVeiculosEstacionados.Name = "lblVeiculosEstacionados";
            this.lblVeiculosEstacionados.Size = new System.Drawing.Size(324, 24);
            this.lblVeiculosEstacionados.TabIndex = 15;
            this.lblVeiculosEstacionados.Text = "Veículos Estacionados:";
            this.lblVeiculosEstacionados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(29, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Veículos - Saída:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVeiculosEstacionados);
            this.Controls.Add(this.tbListaSaida);
            this.Controls.Add(this.tbListaEntrada);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.lblConsult);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultar";
            this.Text = "FrmConsultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConsult;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.TextBox tbListaEntrada;
        private System.Windows.Forms.TextBox tbListaSaida;
        private System.Windows.Forms.Label lblVeiculosEstacionados;
        private System.Windows.Forms.Label label1;
    }
}