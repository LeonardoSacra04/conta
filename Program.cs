Console.Clear();
Conta contaDoDiego = new Conta();

contaDoDiego.Cpf = "1213412123";
contaDoDiego.Nome = "Diego";
contaDoDiego.Saldo = 1000m;

Console.WriteLine($"Saldo: {contaDoDiego.Saldo:C2}");
contaDoDiego.Depositar(-300m);
Console.WriteLine($"Saldo após depósito: {contaDoDiego.Saldo:C2}");

Conta contaDoJose = new Conta()
{
    Cpf = "23112532523",
    Nome = "José",
    Saldo = 100m
};
Console.WriteLine($"Saldo: {contaDoJose.Saldo:C2}");
contaDoJose.Sacar(70m);
Console.WriteLine($"Saldo após saque: {contaDoJose.Saldo:C2}");

class Conta
{
    public string Nome;
    public string Cpf;
    public decimal Saldo;

    public void Depositar(decimal valorADepositar)
    {
        if (valorADepositar > 0)
        {
            Saldo = Saldo + valorADepositar;
        }
    }

    public void Sacar(decimal valorASacar)
    {
        if (valorASacar <= Saldo)
        {
            Saldo = Saldo - valorASacar;
        }
    }
}
