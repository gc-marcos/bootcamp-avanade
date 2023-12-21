using ex001.Models;

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digitema sua opção:");
    Console.WriteLine("1 - Cadastrar cliente.");
    Console.WriteLine("2 - Buscar cliente.");
    Console.WriteLine("3 - Apagar cliente.");
    Console.WriteLine("4 - Encerrar.");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar cliente.");
            break;

        case "2":
            Console.WriteLine("Buscar cliente.");
            break;

        case "3":
            Console.WriteLine("Apagar cliente.");
            break;

        case "4":
            Console.WriteLine("Encerrar.");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa encerrou!!");

// int soma = 0, numero = 0;

// do {
//     Console.WriteLine("Digite um número (0 para encerrar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// } while (numero != 0);
// Console.WriteLine($"Total da soma números digitados é: {soma}");

// int numero = 5;
// int contador = 1;

// while (contador <= 10) {
//     Console.WriteLine($"{contador + 1} - Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6) {
//         break;
//     }
// }

// int numero = 5;

// for(int contador = 0; contador <= 10; contador++) {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero = numero + 1;
// numero++;

// Console.WriteLine("Decrementando ");
// numero--;

// Console.WriteLine(numero);


// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15,45);
// calc.Dividir(2,2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.raizQuadrada(9);

// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde) {
//     Console.WriteLine("Vou Pedalar!");
// } else {
//     Console.WriteLine("Vou Pedalar outro Dia!");
// }

// bool possuiPresencaMinima = true;
// double media = 7;

// if (possuiPresencaMinima && media >= 7) {
//     Console.WriteLine("Aprovado!");
// } else {
//     Console.WriteLine("Reprovado!");
// }

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacao = false;

// if (ehMaiorDeIdade || possuiAutorizacao) {
//     Console.WriteLine("Entrata Liberada!");
// } else {
//     Console.WriteLine("Entrada não Liberada!");
// }

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma Vogal!");
//         break;

//     default:
//         Console.WriteLine("Não é uma Vogal!");
//         break;
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
//     {
//         Console.WriteLine("É uma Vogal!");
//     } else {
//         Console.WriteLine("Não é uma Vogal!");
//     }

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// if (letra == "a") {
//     Console.WriteLine("É uma Vogal!");
// } else if (letra == "e") {
//     Console.WriteLine("É uma Vogal!");
// } else if (letra == "i") {
//     Console.WriteLine("É uma Vogal!");
// } else if (letra == "o") {
//     Console.WriteLine("É uma Vogal!");
// } else if (letra == "u") {
//     Console.WriteLine("É uma Vogal!");
// } else {
//     Console.WriteLine("Não é ima Vogal");
// }


// int quantidadeEmEstoque = 10;
// int quantidadeComprada = 0;
// bool possivelVenda = quantidadeComprada > 0 && quantidadeEmEstoque >= quantidadeComprada;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade comprada: {quantidadeComprada}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if (quantidadeComprada == 0) {
//     Console.WriteLine("Venda Inválida");
// }

// else if (possivelVenda) {
//     Console.WriteLine("Venda Realizada!");
// } else {
//     Console.WriteLine("Desculpe! Não temos a quantidade em estoque");
// }

// int quantidadeEmEstoque = 10;
// int quantidadeCompranda = 4;

// if (quantidadeEmEstoque >= quantidadeCompranda) {
//     Console.WriteLine("Venda Realizada!");
// } else {
//     Console.WriteLine("Desculpe! Não temos a quantidade em estoque");
// }

// string a = "15-"

// //int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão ralizada com sucesso!");

// double a = 4 / 2 + 2;
// double a = 4 / (2 + 2);


// Console.WriteLine(a);

// int a =5;
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// int a = 5;
// double b = a;

// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// Cast - Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);

// int a = 10;
// int b = 20;
// int c = a + b;

// // c = c + 5;

// c += 5;

// c = c - 5;

// c *= 5;


// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// string apresentacao = "Olá, seja bem vindo!";

// int quantidade =  1;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da Variável condição: " + condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Marcos";
// pessoa1.Idade = 28;
// pessoa1.Apresentar();


