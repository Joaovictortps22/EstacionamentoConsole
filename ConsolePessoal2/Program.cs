
#region
//Console.WriteLine("Olá, estamos feliz em ter você no nosso site de compras!");
//Console.WriteLine("Poderia digitar seu nome e endereço?");
//Console.Write("Nome: ");
//var nome = Console.ReadLine();
//Console.Write("Endereço: ");
//var endereco = Console.ReadLine();
//Console.WriteLine("Agora escolha seus produtos: ");
//string maca = "maça";
//string manga = "manga";
//string melancia = "melancia";
//Console.WriteLine(maca);
//Console.WriteLine(manga);
//Console.WriteLine(melancia);
//var frutaEscolhida = Console.ReadLine();
//var valorProduto = 0;
//switch (frutaEscolhida)
//{
//    case "maça":
//        frutaEscolhida = maca;
//        valorProduto = 7;
//        break;
//    case "manga":
//        frutaEscolhida = manga;
//        valorProduto = 10;
//        break;
//    case "melancia":
//        frutaEscolhida = melancia;
//        valorProduto = 5;
//        break;
//    default:
//        Console.WriteLine("Não foi escolhido nenhum produto!");
//        break;
//}
//Console.WriteLine("Agora escolha a quantidade do produto: ");
//var quantidade = Console.ReadLine();

//var valorTotal = Convert.ToInt32(valorProduto) * Convert.ToInt32(quantidade);
//Console.WriteLine($"O valor total é: {valorTotal}");
#endregion

#region
//Console.WriteLine("Olá, cadastre um produto!");
//Console.WriteLine("Digite o nome do produto");
//var nome = Console.ReadLine();
//Console.WriteLine("Digite o valor do produto");
//var valor = Console.ReadLine();
//Console.WriteLine("Digite a quantidade que possui em estoque");
//var estoque = Console.ReadLine();
//Console.WriteLine("Okay seu produto foi cadastrado com sucesso");
//Console.WriteLine("");
//Console.WriteLine("Agora nos diga o nome de quem está comprando o produto");
//var nomeCliente = Console.ReadLine();
//Console.WriteLine("Qual a quantidade vendida?");
//var quantidadeVendida = Console.ReadLine();
//Console.WriteLine("Forma de pagamento");
//var formaPagamento = Console.ReadLine();
//if (Convert.ToInt32(quantidadeVendida) > Convert.ToInt32(estoque))
//{
//    Console.WriteLine("Não temos a quantidade de produto desejada em nossa loja");
//}
//else if (formaPagamento == "Dinheiro")
//{
//    var valorTotalVenda = Convert.ToDouble(valor) * Convert.ToInt32(quantidadeVendida);
//    Console.WriteLine($"O valor total da venda é: {valorTotalVenda}");
//    Console.WriteLine($"Qual o valor pago? :");
//    var valorPago = Console.ReadLine();
//    var troco = Convert.ToInt32(valorPago) - Convert.ToInt32(valorTotalVenda);
//    Console.WriteLine($"Seu troco é: {troco}");
//    var estoqueAtual = Convert.ToInt32(estoque) - Convert.ToInt32(quantidadeVendida);
//    Console.WriteLine($"Estoque atual: {estoqueAtual}");
//}
//else
//{
//    var valorTotalVenda = Convert.ToDouble(valor) * Convert.ToInt32(quantidadeVendida);
//    Console.WriteLine($"O valor total da venda é: {valorTotalVenda}");
//    Console.WriteLine($"Pagamento em cartão");
//    var estoqueAtual = Convert.ToInt32(estoque) - Convert.ToInt32(quantidadeVendida);
//    Console.WriteLine($"Estoque atual: {estoqueAtual}");
//    Console.ReadLine();
//}
#endregion

#region
//Console.WriteLine("Por favor, digite tres números para conter no array");
//Console.WriteLine("Digite o primeiro");
//var n1 = Console.ReadLine();
//Console.WriteLine("Digite o segundo");
//var n2 = Console.ReadLine();
//Console.WriteLine("Digite o terceiro");
//var n3 = Console.ReadLine();
//int[] numeros = { Convert.ToInt32(n1), Convert.ToInt32(n2), Convert.ToInt32(n3) };
//    if (numeros.Contains(7))
//    {
//        int? index = Array.IndexOf(numeros, 7);
//        Console.WriteLine("O indíce do número 7 é: " + index);
//        Console.ReadLine();
//    }
//    else
//    {
//        Console.WriteLine("Não foi encontrado o número 7 no array");
//        Console.ReadLine();
//    }
#endregion

#region
//Console.WriteLine("Por favor, digite tres números para conter no array");
//Console.WriteLine("Digite o primeiro");
//var n1 = Console.ReadLine();
//Console.WriteLine("Digite o segundo");
//var n2 = Console.ReadLine();
//Console.WriteLine("Digite o terceiro");
//var n3 = Console.ReadLine();
//int[] numeros = { Convert.ToInt32(n1), Convert.ToInt32(n2), Convert.ToInt32(n3) };
//Console.WriteLine($"o maior número desse array é: {numeros.Max()}");
#endregion

#region
//Console.WriteLine("Por favor, digite tres números para conter no array");
//Console.WriteLine("Digite o primeiro");
//var n1 = Console.ReadLine();
//Console.WriteLine("Digite o segundo");
//var n2 = Console.ReadLine();
//Console.WriteLine("Digite o terceiro");
//var n3 = Console.ReadLine();
//int[] numeros = { Convert.ToInt32(n1), Convert.ToInt32(n2), Convert.ToInt32(n3) };
//foreach (int numero in numeros)
//{
//    if(numero % 2 == 0)
//    {
//        Console.WriteLine($"Esse é um número par que contém no array: {numero}");
//    }
//}
#endregion

#region
//var clientes = new List<dynamic>();
//while (true)
//{
//    Console.Clear();
//    Console.WriteLine("Digite uma das opções abaixo:");
//    Console.WriteLine("1 - Cadastrar Cliente");
//    Console.WriteLine("2 - Listar Cliente");
//    Console.WriteLine("3 - Sair");

//    var opcao = Console.ReadLine();
//    var sair = false;

//    switch (opcao)
//    {
//        case "1":
//            Console.Clear();
//            Console.WriteLine("Digite o nome do cliente");
//            var nome = Console.ReadLine();
//            Console.WriteLine("Digite o telefone do cliente");
//            var telefone = Console.ReadLine();

//            dynamic cliente = new
//            {
//                Nome = nome,
//                Telefone = telefone
//            };

//            clientes.Add(cliente);

//            Console.WriteLine("Cliente cadastrado com sucesso ...");
//            Thread.Sleep(1000);
//            break;
//        case "2":
//            Console.WriteLine("=== Lista de clientes =====");
//            foreach (var cli in clientes)
//            {
//                Console.WriteLine($"Nome: {cli.Nome}");
//                Console.WriteLine($"Telefone: {cli.Telefone}");
//                Console.WriteLine("------------------------------");
//            }

//            Console.WriteLine("Pressione Enter para continuar ...");
//            Console.ReadKey();
//            break;
//        default:
//            sair = true;
//            break;
//    }

//    if (sair) break;
//}
#endregion

#region
var clientes = new List<dynamic>();
var movimentacoesEntrada = new List<dynamic>();
var movimentacoesSaida = new List<dynamic>();
var precoMinuto = 1;
while (true)
{
    Console.Clear();
    Console.WriteLine("Digite uma das opções abaixo:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Listar Cliente");
    Console.WriteLine("3 - Movimentação - Entrada");
    Console.WriteLine("4 - Movimentação - Saída");
    Console.WriteLine("5 - Sair");

    var opcao = Console.ReadLine();
    var sair = false;

    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Digite o nome do cliente");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone do cliente");
            var telefone = Console.ReadLine();

            dynamic cliente = new
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Telefone = telefone
            };

            clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso ...");
            Thread.Sleep(1000);
            break;
        case "2":
            if(clientes.Count > 0)
            {
                Console.WriteLine("=== Lista de clientes =====");
                foreach (var cli in clientes)
                {
                    Console.WriteLine($"Nome: {cli.Nome}");
                    Console.WriteLine($"Telefone: {cli.Telefone}");
                    Console.WriteLine(" --------- "); 
                }
                Console.WriteLine(" --------------------------------- ");
                Console.WriteLine("Pressione Enter para continuar ...");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("Não possui nenhum cliente cadastrado");
                Console.WriteLine(" --------------------------------- ");
                Console.WriteLine("Pressione Enter para continuar ...");
                Console.ReadKey();
                break;
            }
            
        case "3":
            Console.WriteLine("=== Movimentação Entrada =====");
            Console.WriteLine("Escolha o número correspondente ao cliente: ");
            foreach(var cli in clientes)
            {
                int indice = clientes.IndexOf(cli);
                Console.WriteLine(indice + " - " + cli.Nome);
            }
            var indiceClienteEscolhido = Console.ReadLine();
            var idClienteEscolhido = clientes[Convert.ToInt32(indiceClienteEscolhido)].Id;
            var horaEntrada = DateTime.Now;
            Console.WriteLine("Digite a placa do carro");
            var placa = Console.ReadLine();
            dynamic movimentacaoEntrada = new
            {
                Id = Guid.NewGuid(),
                Placa = placa,
                IdCliente = idClienteEscolhido,
                HoraEntrada = horaEntrada,
            };
            movimentacoesEntrada.Add(movimentacaoEntrada);
            Console.WriteLine("Movimentação de Entrada Cadastrada com sucesso: ");
            Console.WriteLine(" --------------------------------- ");
            Console.WriteLine("IdMovimentação: " + movimentacaoEntrada.Id);
            Console.WriteLine("Cliente: " + movimentacaoEntrada.IdCliente);
            Console.WriteLine("Placa do Carro: " + movimentacaoEntrada.Placa);
            Console.WriteLine("Hora de Entrada: " + movimentacaoEntrada.HoraEntrada);
            Console.WriteLine(" --------------------------------- ");
            Console.WriteLine("Pressione Enter para continuar ...");
            Console.ReadKey();
            break;
        case "4":
            Console.WriteLine("=== Movimentação Saída =====");
            Console.WriteLine("=== Olá! Escolha o número correspondente à movimentação que deseja encerrar =====");
            foreach (var mov in movimentacoesEntrada)
            {
                int indice = movimentacoesEntrada.IndexOf(mov);
                Console.WriteLine(indice + " - " + mov.Id + " " + mov.Placa);
            }
            var indiceMovimentacaoEscolhido = Console.ReadLine();
            var idMovimentacaoEntrada = movimentacoesEntrada[Convert.ToInt32(indiceMovimentacaoEscolhido)].Id;
            var jaFaturado = movimentacoesSaida.Where(p => p.IdMovimentacaoEntrada == idMovimentacaoEntrada).FirstOrDefault();
            if(jaFaturado == null)
            {
                var horaSaida = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", null);
                var horaTotalEstacionado = (horaSaida - movimentacoesEntrada[Convert.ToInt32(indiceMovimentacaoEscolhido)].HoraEntrada).TotalMinutes;
                Console.WriteLine(horaTotalEstacionado);
                var precoTotal = horaTotalEstacionado * precoMinuto;
                Console.WriteLine($"Preço total: R${precoTotal:F2}");
                dynamic movimentacaoSaida = new
                {
                    Id = Guid.NewGuid(),
                    IdMovimentacaoEntrada = idMovimentacaoEntrada,
                    PrecoTotal = precoTotal
                };
                movimentacoesSaida.Add(movimentacaoSaida);
            }
            else
            {
                Console.WriteLine("Movimentação já foi encerrada");
            }
            
            Console.WriteLine(" --------------------------------- ");
            Console.WriteLine("Pressione Enter para continuar ...");
            Console.ReadKey();
            break;
        default:
            sair = true;
            break;
    }

    if (sair) break;
}
#endregion








