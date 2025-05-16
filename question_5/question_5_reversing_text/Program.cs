
Console.WriteLine("Inverter texto digitado");
string input = Console.ReadLine();
var inputToReverse = "";


char[] arrayOfInput = input.ToCharArray();


for (int i = arrayOfInput.Length - 1; i >= 0; i--)
{
    //Console.Write(arrayOfInput[i]);
    inputToReverse = inputToReverse + arrayOfInput[i];    
}

Console.WriteLine("Texto reverso: " + inputToReverse);

Console.ReadLine();
Console.Clear();