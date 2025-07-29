namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        // Preço inicial cobrado ao estacionar
        private decimal precoInicial = 0;

        // preço cobrado por hora adicional
        private decimal precoPorHora = 0;

        // Lista para armazenar as placas dos veículos estacionados
        private List<string> veiculos = new List<string>();
        
        // Construtor que recebe os preços e inicializa o estacionamento
        public Estacionamento(decimal precoInicial,
                            decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        
        // Método para adcionar um veículo a lista
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do Veículo para estacionar:");

            // Lê a placa dígitada pelo usuário
            string placa = Console.ReadLine();

            // Adciona a placa á lista de veículos
            veiculos.Add(placa);

            // Informa ao usuário que o veículo foi cadastrado com sucesso
            Console.WriteLine($"O veículo {placa} foi cadastrado com sucesso!");
        }

        // Método para remover um veículo da lista
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Lê a placa que o usuário deseja remover
            string placa = Console.ReadLine();

            // verifica se a placa existe na lista de véiculos (ignorando maiúsculas e minúsculas)
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Lê a quantidade de horas estacionado
                int horas = int.Parse(Console.ReadLine());

                // Calcula o valor total a ser pago
                // Preço total = preço inicial + (preço por hora * horas)
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // exibe a mensagem informando o valor total a ser pago
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                // Remove a placa da lista de veículos
                veiculos.Remove(placa);
            }
            else
            {
                // Caso a placa não esteja na lista, inorma ao usuário
                Console.WriteLine("Desculpe o veículo não está estacionado aqui. " +
                                  "Verifique se a placa foi digitada corretamente.");
            }
        }
        // Método responsável para listar todos veículos cadastrados
        public void ListarVeiculos()
        {
            // Verifica se há veículos na lista
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Percorre a lista de veículos e exibe a placa de cada veículo
                foreach (var v in veiculos)
                {
                    Console.WriteLine($"- {v}");
                }
            }
            else
            {
                // Caso não haja veículos cadastrado, exibe a mensagem informamdo ao usuário
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}