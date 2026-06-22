static string VerificarEstoque(int quantidade)
{
    if (quantidade < 5)
        return "Estoque Crítico";
    else if (quantidade <= 10)
        return "Estoque Baixo";
    else
        return "Estoque OK";
}

Console.Write("Nome do produto: ");
string produto = Console.ReadLine();

Console.Write("Quantidade atual: ");
int quantidade = int.Parse(Console.ReadLine());

string status = VerificarEstoque(quantidade);

Console.WriteLine($"\nProduto: {produto}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Status: {status}");