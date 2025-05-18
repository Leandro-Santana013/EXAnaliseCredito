
/* Exercício `AnaliseCredito`  Um cliente quer solicitar um empréstimo. Receba o valor solicitado, a quantidade de parcelas desejada e a renda mensal comprovada. Só autorize empréstimos cuja parcela não ultrapasse 30% da renda (desconsidere os juros). */
int valorSolicitado, quantidadeParcela, rendaMensal, valorParcela;
Console.Write("Digite o valor solicitado: ");
valorSolicitado = int.Parse(Console.ReadLine()!);

Console.Write("Digite a quantidade de parcelas: ");
quantidadeParcela = int.Parse(Console.ReadLine()!);

Console.Write("Digite a renda mensal: ");
rendaMensal = int.Parse(Console.ReadLine()!);

valorParcela = valorSolicitado / quantidadeParcela;

if (valorParcela <= (rendaMensal * 0.3))
{
    Console.WriteLine($"Empréstimo autorizado! O valor da parcela é {valorParcela}");
}
else
{
    Console.WriteLine($"Empréstimo não autorizado! O valor da parcela é {valorParcela}");
}
