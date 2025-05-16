/*
3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, 
faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
*/

using System.Text.Json;
using System.Threading.Tasks;

string json = File.ReadAllText(@"./dados.json");
List<FinancialDayly> list = JsonSerializer.Deserialize<List<FinancialDayly>>(json);

Console.WriteLine("===== Faturamento mensal super empresa =====");

/*
foreach (FinancialDayly dayly in list)
{
    Console.WriteLine("-----");
    Console.WriteLine($"Dia:   {dayly.dia}");
    Console.WriteLine($"Valor: {dayly.valor}");
    Console.WriteLine("-----");
}
*/

var ComercialDaysList = list.Where(x => x.valor != 0);

decimal betterValueDay = ComercialDaysList.Max((x) => x.valor);
decimal worseValueDay = ComercialDaysList.Min((x) => x.valor);

IEnumerable<FinancialDayly> betterDay = ComercialDaysList.Where(x => x.valor == betterValueDay);
IEnumerable<FinancialDayly> worseDay = ComercialDaysList.Where(x => x.valor == worseValueDay);

foreach (FinancialDayly day in betterDay)
{
    Console.WriteLine("Melhor dia : " + day.dia);
    Console.WriteLine("Melhor dia valor : " + day.valor);
}

foreach (FinancialDayly day in worseDay)
{
    Console.WriteLine("Pior dia : " + day.dia);
    Console.WriteLine("Pior dia valor : " + day.valor);

}

decimal totalDaysSum = ComercialDaysList.Sum(x => x.valor);
int countTotalDays = ComercialDaysList.Count();

Console.WriteLine("Média dos dias : " + totalDaysSum / countTotalDays);

Console.ReadLine();
Console.Clear();

public class FinancialDayly
{
    public int dia { get; set; }
    public decimal valor { get; set; }
}