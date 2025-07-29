using DesafioFundamentos.Models;
using DesafioFundamentos.Models; // Importa o namespace onde está a classe Estacionamento

// Define a codificação para permetir caracteres especiais (como R$)
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Declaração de variáveis que vão armazenar o preço inicial e o preço por hora do estacionamento
decimal precoInicial = 0;
decimal precoPorHora = 0;

// Mensagem inicial e leitura do preço inicial
Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial do estacionamento:");

// Converte a entrada do usuário para decimal e armazena na variável precoInicial
precoInicial = Convert.ToDecimal(Console.ReadLine());

// leitura do preço por hora
Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Cria uma instância da classe Estacionamento passando os preções informados pelo usuário
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// Variável para de controle do menu
string opcao = string.Empty;
bool exibirMenu = true;

// loop para exibir o menu até que o usuário escolha sair
while (exibirMenu)
{
    Console.Clear(); // Limpa o console a cada iteração do loop para deixar o menu mais organizado
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Sair");

    // Lê a opção escolhida pelo usuário e executa o método correspondente
    switch (Console.ReadLine())
    {
        case "1":
            // Chama o método para adicionar um veículo
            es.AdicionarVeiculo();
            break;

        case "2":
            // Chama o método para remover um veículo
            es.RemoverVeiculo();
            break;

        case "3":
            // Chama o método para listar os veículos estacionados
            es.ListarVeiculos();
            break;

        case "4":
            // Define a variável para sair do loop e exibe a mensagem de saída
            exibirMenu = false;
            Console.WriteLine("Obrigado por utilizar o sistema de estacionamento!");
            break;

        default:
            // Caso a opção digitada não seja válida, informa ao usuário
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

    // Aguarda o usuário pressionar uma tecla antes de retornar ao menu
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey(); // Usa o ReadKey para esperar uma tecla ser pressionada
}

// Exibe uma mensagem final ao usuário quando o programa é encerrado
Console.WriteLine("O programa se encerrou.");