using PooTrab;

Banco banco1 = new ("Nubank", "1", "123");

Console.WriteLine(banco1.Nome);

Cliente cliente1 = new("Arthur", "123", "123", "abcd");

Console.WriteLine(cliente1.Nome);

ContaFree conta1 = new(cliente1, banco1, "1", 5000m);

Console.WriteLine(conta1.Saldo);
Console.WriteLine(conta1.Sacar(4m));
