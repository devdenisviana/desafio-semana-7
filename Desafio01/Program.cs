static double CalcularMedia(double nota1, double nota2)
{
    return (nota1 + nota2) / 2;
}

static string VerificarSituacao(double media)
{
    if (media >= 7)
        return "Aprovado";
    else if (media >= 5)
        return "Recuperação";
    else
        return "Reprovado";
}

Console.Write("Nome do aluno: ");
string nome = Console.ReadLine();

Console.Write("Nota 1: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
double nota2 = double.Parse(Console.ReadLine());

double media = CalcularMedia(nota1, nota2);
string situacao = VerificarSituacao(media);

Console.WriteLine($"\nAluno: {nome}");
Console.WriteLine($"Média: {media:F1}");
Console.WriteLine($"Situação: {situacao}");