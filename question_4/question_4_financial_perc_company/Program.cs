/*

4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
• SP – R$67.836,43
• RJ – R$36.678,66
• MG – R$29.229,88
• ES – R$27.165,48
• Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  

*/

State sp = new State("SP", 67836.43);
State rj = new State("RJ", 36678.66);
State mg = new State("MG", 29229.88);
State es = new State("ES", 27165.48);
State others = new State("Outros", 19849.53);
Console.WriteLine(sp.Value);

var totalStatesValue = sp.Value + rj.Value + mg.Value + es.Value + others.Value;
Console.WriteLine(totalStatesValue);

var statesList = new List<State>();
statesList.Add(sp);
statesList.Add(rj);
statesList.Add(mg);
statesList.Add(es);
statesList.Add(others);

//statesList.Add(sp); statesList.Add(rj); statesList.Add(mg); statesList.Add(es); statesList.Add(others);

foreach (State state in statesList)
{
    state.percent = Math.Round(state.Value / totalStatesValue * 100, 2);
    Console.WriteLine($"Estado nome - {state.Name} | Estado valor - {state.Value} | Estado percentual - {state.percent} | Total Estados Soma - {totalStatesValue}");
}

Console.ReadLine();
Console.Clear();


public class State
{

    public State(string name, double value)
    {
        Name = name;
        Value = value;
    }

    public string Name;
    public double Value;
    public double percent;
}