namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite o nome do seu veiculo e a placa para poder estacionar");
            Console.WriteLine("EX: FIAT UNO / ABC-1234");
            string addVeiculo = Console.ReadLine();
            veiculos.Add(addVeiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite o nome do seu veiculo e a placa do veículo para remover");
            Console.WriteLine("EX: FIAT UNO / ABC-1234");
            string deleteVeiculo = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == deleteVeiculo.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                Console.WriteLine("Apenas número, EX: 3");
                int totalhoras = int.Parse(Console.ReadLine());

                decimal valorTotal = 0;
                valorTotal = precoInicial + (precoPorHora * totalhoras);

                Console.WriteLine($"O veículo {deleteVeiculo} foi removido e o preço total foi de: R${valorTotal}");
                Console.WriteLine($"O calculo base é preço inicial = {precoInicial} + ( preço por horas = {precoPorHora} * total horas = {totalhoras})");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
