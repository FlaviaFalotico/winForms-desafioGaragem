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
    public partial class FrmCadastrarEntrada : Form
    {
        public static List<Veiculo> listaVeiculosEntrada = new List<Veiculo>();
        public FrmCadastrarEntrada()
        {
            InitializeComponent();
            listaVeiculosEntrada = Persistencia.LerArquivoEntrada();
        }

        /// <summary>
        /// Inicia o timer com referência no sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCadastrarEntrada_Load(object sender, EventArgs e)
        {
            timerEntrada.Start();
        }

        /// <summary>
        /// Gera data atual e hora dinâmica com referência no sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEntrada_Tick(object sender, EventArgs e)
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
        /// Limpar os campos de placa, hora e data para realizar um novo cadastro de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbPlacaEntrada.Clear();
        }

        /// <summary>
        /// Validações realizadas para o cadastro de um veículo na garagem
        /// Gravação de um registro de entrada de veículo na garagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int maxTamanhoPlaca = 7;
                if (Veiculo.VerificarPlaca(tbPlacaEntrada.Text, listaVeiculosEntrada))
                {
                    MessageBox.Show("Placa já cadastrada!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPlacaEntrada.Clear();
                }
                else if (Veiculo.VagaDisponivel(listaVeiculosEntrada, 50) == false)
                {
                    MessageBox.Show("Garagem lotada!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbPlacaEntrada.Text.Equals("") || tbPlacaEntrada.Text.Length < maxTamanhoPlaca ||
                    tbPlacaEntrada.Text.Length > maxTamanhoPlaca)
                {
                    MessageBox.Show("O campo placa é obrigatório e deve conter sete caracteres.",
                        "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPlacaEntrada.Clear();
                }
                else
                {
                    //Colocar as letras da placa em maiúsculo antes de gravar no arquivo
                    tbPlacaEntrada.Text = tbPlacaEntrada.Text.ToUpper();

                    //Cria um novo cadastro de veículo
                    Veiculo cadastroVeiculo = new Veiculo(tbPlacaEntrada.Text, lblData.Text, lblHora.Text);

                    //Adicionar o novo cadastro na lista e no arquivo de entrada de veículos
                    listaVeiculosEntrada.Add(cadastroVeiculo);
                    Persistencia.GravarArquivoEntrada(cadastroVeiculo);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
