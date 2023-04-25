// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using PhoneSystem;

Console.Write($"Cor: ");
string cor = Console.ReadLine();

Console.Write($"Modelo: ");
string modelo = Console.ReadLine();

Console.Write($"Tamanho: ");
float tamanho = float.Parse(Console.ReadLine());

Console.Write($"Está ligado (s/n): ");
bool ligado = Console.ReadLine().ToLower() == "s";

Celular celular = new Celular(cor, modelo, tamanho, ligado);


short opcao = 0;
do 
{
	Console.Clear();
	
	Console.WriteLine($@"
	Digite uma opção:
	1 - Ligar
	2 - Desligar
	3 - Fazer ligação
	4 - Enviar mensagem
	5 - Sair
	");

	opcao = short.Parse(Console.ReadLine());
	switch (opcao) 
	{
		case 1:
			celular.ligar();
			break;
		case 2:
			celular.desligar();
			break;
		case 3:
			celular.fazerLigacao();
			break;
		case 4:
			celular.enviarMensagem();
			break;
		case 5:
			break;
		default:
			Console.WriteLine($"Invalid option!");
			break;
	}
	
	Console.WriteLine($"Type any button...");
	Console.ReadKey();
} while (opcao != 5);

