using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Garagem_WinForm
{
    public class Veiculo
    {
        string placa; //7 caracteres -> verificar jaNaGaragem
        string dataEntrada;
        string horaEntrada;
        string dataSaida;
        string horaSaida;
        int tempoPermanecia; //min
        double valorCobrado; //para valores diferentes na tabela de preços

        public Veiculo()
        {

        }

        /// <summary>
        /// Este Construtor é utilizado na leitura do arquivo para popular a lista de entrada
        /// </summary>
        /// <param name="placa"></param> Identificação do veículo
        /// <param name="dataEntrada">Data do sistema para a entrada do veiculo</param> 
        /// <param name="horaEntrada">Hora do sistema para a entrada do veiculo</param> 
        public Veiculo(string placa, string dataEntrada, string horaEntrada)
        {
            this.placa = placa;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
        }

        /// <summary>
        /// Construtor que captura somente a placa do veículo
        /// </summary>
        /// <param name="placa"></param>
        public Veiculo(string placa)
        {
            this.placa = placa;
        }

        /// <summary>
        /// Construtor utilizado na leitura do arquivo de saída com veículos que já passaram pela garagem
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="dataEntrada"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="dataSaida"></param>
        /// <param name="horaSaida"></param>
        /// <param name="tempoPermanecia"></param>
        /// <param name="valorCobrado"></param>
        public Veiculo(string placa, string dataEntrada, string horaEntrada, string dataSaida,
            string horaSaida, int tempoPermanecia, double valorCobrado) : this(placa, dataEntrada, horaEntrada)
        {
            this.dataSaida = dataSaida;
            this.horaSaida = horaSaida;
            this.tempoPermanecia = tempoPermanecia;
            this.valorCobrado = valorCobrado;
        }

        /// <summary>
        /// Método que calcula o tempo de permanência em minutos e o valor de cobrança
        /// </summary>  
        public void RealizarCobranca()
        {
            this.tempoPermanecia = (int) DateTime.Parse(this.horaSaida).Subtract(DateTime.Parse(this.horaEntrada)).TotalMinutes;

            if (this.tempoPermanecia % 60 > 0)
            {
                this.valorCobrado += 5.0 + (5 * Math.Truncate(this.tempoPermanecia / 60.0));
            }
            else
            {
                this.valorCobrado =  5.0 * (this.tempoPermanecia / 60.0);
            }
        }

        public string Placa { get => placa; set => placa = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string DataSaida { get => dataSaida; set => dataSaida = value; }
        public string HoraSaida { get => horaSaida; set => horaSaida = value; }
        public int TempoPermanecia { get => tempoPermanecia; set => tempoPermanecia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }

        /// <summary>
        /// Método qure procura um veículo na lista a partir de sua placa 
        /// </summary>
        /// <param name="placa">identificação do veículo</param>
        /// <param name="lista"> lista de entrada ou de saída</param>
        /// <returns></returns>
        public static bool VerificarPlaca(string placa, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return true;
                }
            }
            return false; 
        }

        /// <summary>
        /// Método que descobre se há espaço para mais veículos na garagem (Lista de controle de veículos da garagem)
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="tamanhoGaragem"></param>
        /// <returns></returns>
        public static bool VagaDisponivel(List<Veiculo> lista, int tamanhoGaragem)
        {
            return lista.Count() <= tamanhoGaragem;
        }
    }
}
