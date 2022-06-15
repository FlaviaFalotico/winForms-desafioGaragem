using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Garagem_WinForm
{
    public partial class Form_Principal : Form
    {
        /// <summary>
        /// Irá controlar o formulário filho que será aberto dentro do formulário principal
        /// </summary>
        private Form frmAtivo;
        public Form_Principal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construtor da Classe do FrmPrincipal
        /// </summary>
        /// <param name="frm"></param>
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront(); //traz para a primeira camada do objeto
            frm.Show();
        }

        /// <summary>
        /// Método que irá fechar o formulário ativo, antes de abrir o próximo
        /// </summary>
        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        /// <summary>
        /// Método criado para alterar a cor do texto do botão enquanto formulário estiver aberto
        /// </summary>
        /// <param name="frmAtivo"></param>
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelMenu.Controls)
                ctrl.ForeColor = Color.DimGray;
            frmAtivo.ForeColor = Color.White;
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btHome);
            ActiveFormClose();
        }

        private void btCadEntrada_Click(object sender, EventArgs e)
        {
            ActiveButton(btCadEntrada);
            FormShow(new FrmCadastrarEntrada());

        }

        private void btCadSaida_Click(object sender, EventArgs e)
        {
            ActiveButton(btCadSaida);
            FormShow(new FrmCadastrarSaida());
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            ActiveButton(btConsultar);
            FormShow(new FrmConsultar());
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por utilizar o Garageek!");
            Application.Exit();
        }
    }
}
