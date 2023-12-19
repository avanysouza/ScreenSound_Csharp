


//Screen Sound
string mensagemDeBoasVindas = "Bem Vindo ao Screen Sound!";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Beatles", new List<int>());  


//MÉTODO PARA MENSAGEM DE BOAS VINDAS
void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
  
    Console.WriteLine(mensagemDeBoasVindas);
}

//MÉTODO PARA CRIAR OPÇOES DO MENU
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nDigite a sua opção: ");
    int opcaoSelecionada = Convert.ToInt32(Console.ReadLine());

    switch (opcaoSelecionada)
    {
        case 1: RegistrarBanda(); 
            break;
        case 2: MostrarBandasRegistradas(); 
            break;
        case 3: AvaliarUmaBanda(); 
            break;
        case 4: MediaDeUmaBanda(); 
            break;
        case -1:
            Console.WriteLine("Tchau Tchau!");
            break;
        default: Console.WriteLine("Opção inválida! Escolha uma opção do menu."); 
                break; 
    }

}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas"); 
    Console.Write("Digite o nome da banda que deseja registrar: \n"); 
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());

    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
    Thread.Sleep(2000);                  //Introduzir um intervalo de processamento para exibir a mensagem na tela.
    
    Console.Clear();

    ExibirLogo();
    ExibirOpcoesDoMenu();

}

//MÉTODO PARA OPÇÃO DE REGISTRAR NOVAS BANDAS
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas:"); 


    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");

    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();

    ExibirLogo();
    ExibirOpcoesDoMenu();
}

//MÉTODO PARA EXIBIR TITULO DA OPÇÃO ESCOLHIDA

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(astericos);
    Console.WriteLine(titulo);
    Console.WriteLine(astericos + "\n");

}

//MÉTODO PARA AVALIAR UMA BANDA (OPÇÃO 4)
void AvaliarUmaBanda()
{

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;


    //se a banda existir no dicionario, atribua uma nota. Se nao existir, exibe uma mensagem e volta para o menu principal.


    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? "); 
        int nota = int.Parse(Console.ReadLine())!;
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}\n");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu(); 
    }

}

void MediaDeUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da Banda");

    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    //pesquisar banda no dicionário de bandas

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List <int> notasDabanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A banda {nomeDaBanda} possui média de {notasDabanda.Average()}");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();




