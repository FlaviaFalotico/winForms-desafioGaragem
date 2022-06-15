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
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
            FrmCadastrarEntrada.listaVeiculosEntrada = Persistencia.LerArquivoEntrada();
            FrmCadastrarSaida.listaVeiculosSaida = Persistencia.LerArquivoSaida();
            ExibirListaEntrada();
            ListaSaida();
        }

        /// <summary>
        /// Método que exibe a lista de entrada de veículos na garagem
        /// </summary>
        private void ExibirListaEntrada()
        {
            tbListaEntrada.Text = "";
            foreach (Veiculo veiculo in FrmCadastrarEntrada.listaVeiculosEntrada)
            {
                tbListaEntrada.AppendText(veiculo.Placa.ToUpper() + " - " + veiculo.DataEntrada +
                    " - " + veiculo.HoraEntrada + Environment.NewLine);
            }
        }

        /// <summary>
        /// Método que exibe a lista de saída de veículos da garagem
        /// </summary>
        private void ListaSaida()
        {
            tbListaSaida.Text = "";
            foreach (Veiculo veiculo in FrmCadastrarSaida.listaVeiculosSaida)
            {
                tbListaSaida.AppendText(veiculo.Placa.ToUpper() + " - " + veiculo.DataEntrada 
                    + " - " + veiculo.HoraEntrada + " - " + veiculo.DataSaida + " - " + veiculo.HoraSaida + 
                    " - " + veiculo.TempoPermanecia + " minutos - R$" + veiculo.ValorCobrado + ",00." + Environment.NewLine);
            }

        }
        /// <summary>
        /// Método para fechar o formulario de consulta, retornando ao formulário principal (home)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
