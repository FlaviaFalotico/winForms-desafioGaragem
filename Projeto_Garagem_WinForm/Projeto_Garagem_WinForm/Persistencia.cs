using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Garagem_WinForm
{
    internal class Persistencia
    {/// <summary>
     /// Método que à partir da lista persiste os dados no arquivo dos veículos que estão na garagem.
     /// </summary>
     /// <param name="lista">lista de veículos</param>
        public static void GravarArquivoEntrada(Veiculo veiculo)
        {           
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosEntrada.dat", true);

                escritor.WriteLine(veiculo.Placa.ToUpper() + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada);
                escritor.Flush();
                escritor.Close();
                MessageBox.Show("Cadastro concluído com sucesso!", "Obrigado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                Console.WriteLine("Arquivo de veículos com problemas" + error.Message);
            }
            
        }
        /// <summary>
        /// Método que à partir da lista persiste os dados no arquivo dos veículos que passaram pela garagem (histórico de veículos).
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        public static void GravarArquivoSaida(Veiculo veiculo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosSaida.dat", true);

                escritor.WriteLine(veiculo.Placa.ToUpper() + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada + ";" +
                   veiculo.DataSaida + ";" + veiculo.HoraSaida + ";" + veiculo.TempoPermanecia + ";" + veiculo.ValorCobrado);
                escritor.Flush();
                escritor.Close();
                MessageBox.Show("Tempo de permanência: " + veiculo.TempoPermanecia +
                    " minutos."+ "\nValor de cobrança: R$" + veiculo.ValorCobrado + ",00.", "Obrigado!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                Console.WriteLine("Arquivo de veículos com problemas" + error.Message);
            }
        }

        /// <summary>
        /// Método que à partir do arquivo base, popula a lista de veículos de estão na garagem
        /// </summary>
        /// <param name="lista">lista de veículos</param>
        public static List<Veiculo> LerArquivoEntrada()
        {
            List<Veiculo> listaVeiculos = new List<Veiculo>();
            string linha;
            string[] dataHora;
            try
            {   
                StreamReader leitor = new StreamReader("veiculosEntrada.dat");
                do
                {
                    linha = leitor.ReadLine();
                    dataHora = linha.Split(';');
                    listaVeiculos.Add(new Veiculo(dataHora[0], dataHora[1], dataHora[2]));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
            }        
            return listaVeiculos;
        }

        /// <summary>
        /// Método que à partir do arquivo base, popula a lista de veículos que passaram pela garagem
        /// </summary>
        /// <param name="lista"></param>
        public static List<Veiculo> LerArquivoSaida()
        {
            List<Veiculo> listaVeiculos = new List<Veiculo>();           
            string linha;
            string[] dataHora;
            try
            {
                StreamReader leitor = new StreamReader("veiculosSaida.dat");
                do
                {
                    linha = leitor.ReadLine();
                    dataHora = linha.Split(';');
                    listaVeiculos.Add(new Veiculo(dataHora[0], dataHora[1], dataHora[2], dataHora[3],
                        dataHora[4], int.Parse(dataHora[5]), double.Parse(dataHora[6])));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {

            }          
            return listaVeiculos;
        }

        /// <summary>
        /// Método que refaz a lista de entrada de veículos após a remoção de um veículo no cadastro de saída
        /// </summary>
        /// <param name="listaVeiculos"></param>
        public static void AtualizarArquivo(List<Veiculo> listaVeiculos)
        {
            StreamWriter escritor = new StreamWriter("veiculosEntrada.dat");

            foreach(Veiculo veiculo in listaVeiculos)
            {
                escritor.WriteLine(veiculo.Placa + ";" + veiculo.DataEntrada + ";" + veiculo.HoraEntrada);
                escritor.Flush();
            }            
            escritor.Close();
        }             
    }
}