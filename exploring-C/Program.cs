using System.Diagnostics;
using explorandoC.Models;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados["MG"]);


// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------------");

// estados.Remove("BA");
// estados["SP"] = "São Tomé";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave =  "BA2";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }





// Stack<int> pilha = new Stack<int>();

// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(7);
// pilha.Push(9);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(13);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }




// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }






// new exemploExcecao().Metodo1();




// try
// {
// string [] linhas = File.ReadAllLines("Arquivos/arquivo Leitura.txt");

// foreach(string linha in linhas) 
// {
// Console.WriteLine(linha);
// }
// }

// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção pasta não encontrada! {ex.Message}");
// }

// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu um exceção genérica. {ex.Message}.");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }



// string dataString = "2023-10-23 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida!");
// }




// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-br");

// decimal valorMoeda = 1580.45m;
// Console.WriteLine(valorMoeda.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Console.WriteLine(valorMoeda.ToString("N1"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("p"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Lima");
// Pessoa p2 = new Pessoa(nome: "Marcos", sobrenome: "Carvalho");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAluno();

// Pessoa p1 = new Pessoa();
// p1.Nome =  "Marcos";
// p1.Idade = 28;
// p1.Sobrenome = "Carvalho";
// p1.Apresentar();