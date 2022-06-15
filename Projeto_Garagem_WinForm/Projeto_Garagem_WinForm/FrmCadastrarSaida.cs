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
    public partial class FrmCadastrarSaida : Form
    {
        public static List<Veiculo> listaVeiculosSaida = new List<Veiculo>();

        public FrmCadastrarSaida()
        {
            InitializeComponent();
            FrmCadastrarEntrada.listaVeiculosEntrada = Persistencia.LerArquivoEntrada();
            listaVeiculosSaida = Persistencia.LerArquivoSaida();
        }

        /// <summary>
        /// Inicia o timer com referência no sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCadastrarSaida_Load(object sender, EventArgs e)
        {
            timerSaida.Start();
        }

        /// <summary>
        /// Gera data atual e hora dinâmica com referência no sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSaida_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }

        /// <summary>
        /// Fechar o formulário, redirecionando para o formulário principal, mas sem fechar a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Limpar os campos de placa, hora e data para realizar um novo cadastro de saída 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbPlacaSaida.Clear();
        }

        /// <summary>
        /// Validações realizadas para o cadastro de saída de um veículo da garagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int maxTamanhoPlaca = 7;
                if (!Veiculo.VerificarPlaca(tbPlacaSaida.Text, FrmCadastrarEntrada.listaVeiculosEntrada))
                {
                    MessageBox.Show("Placa não registrada!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPlacaSaida.Clear();
                }
                else if (tbPlacaSaida.Text.Equals("") || tbPlacaSaida.Text.Length < maxTamanhoPlaca ||
                    tbPlacaSaida.Text.Length > maxTamanhoPlaca)
                {
                    MessageBox.Show("O campo placa é obrigatório e deve conter sete caracteres.",
                        "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPlacaSaida.Clear();
                }
                else
                {
                    //Colocar as letras da placa em maiúsculo antes de gravar no arquivo
                    tbPlacaSaida.Text = tbPlacaSaida.Text.ToUpper();

                    foreach (Veiculo i in FrmCadastrarEntrada.listaVeiculosEntrada)
                    {
                        if (tbPlacaSaida.Text == i.Placa)
                        {
                            i.Placa.ToUpper();
                            i.HoraSaida = lblHora.Text;
                            i.DataSaida = lblData.Text;

                            //Valor cobrado com referência ao tempo em que o veículo permaneceu na garagem
                            i.RealizarCobranca();

                            //Grava um registro no arquivo de saída de veículos
                            Persistencia.GravarArquivoSaida(i);

                            //Remove o registro anterior da lista de entrada de veículos
                            FrmCadastrarEntrada.listaVeiculosEntrada.Remove(i);

                            //Atualiza o arquivo de entrada sem o arquivo removido
                            Persistencia.AtualizarArquivo(FrmCadastrarEntrada.listaVeiculosEntrada);

                            break;
                        }
                    }
                }

            }
            catch (Exception)
            {

            }            
        }
    }
}
