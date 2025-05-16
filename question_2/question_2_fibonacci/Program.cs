/*

2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre 
será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem
 que desejar onde, informado um número, ele calcule a sequência
 de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

*/

var fibonacciList = new List<int>();
fibonacciList.Add(0);//first  step 
fibonacciList.Add(1);//second step
fibonacciList.Add(1);//third  step

var inputUserNumber = "";

Console.WriteLine("Escolheu um número: ");
Console.WriteLine("=====================");

try
{
    inputUserNumber = Console.ReadLine().ToString();
    Console.WriteLine("Você escolheu o número: " + inputUserNumber.ToString());

    int inputUser = int.Parse(inputUserNumber.ToString());
    FillFinabocciListUntillInput(inputUser);
    ShowFibonacciList();

    int positionNumber = fibonacciList.FirstOrDefault((x) => x == inputUser);

    if (positionNumber == 0 && inputUser != 0)
        Console.WriteLine("Resultado Final n° {" + inputUser + "}: " + "Não petence à sequência de FIBONACCI");
    else
        Console.WriteLine("Resultado Final n° {" + inputUser + "}: " + "Pertence à sequência de FIBONACCI");

    Console.ReadLine();
    Console.Clear();
}
catch (System.Exception)
{
    throw;
}


void FillFinabocciListUntillInput(int input)
{
    for (int i = 3; fibonacciList[i - 1] <= input; i++)
    {
        fibonacciList.Add(fibonacciList[i - 1] + fibonacciList[i - 2]);//fourth or other upper step
    }
}

void ShowFibonacciList()
{
    var counter = 1;
    foreach (var fib in fibonacciList)
    {
        Console.WriteLine($"Etapa === {counter} > + {fib.ToString()}");
        counter = counter + 1;
    }
}