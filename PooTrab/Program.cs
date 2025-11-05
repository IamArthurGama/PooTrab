using PooTrab;

Banco banco1 = new ("Nubank", "123", "12345678912345");

Console.WriteLine(banco1.Nome);

Cliente cliente1 = new("Arthur", "12345678912", "123", "abcd");

Console.WriteLine(cliente1.Nome);

ContaFree conta1 = new(cliente1, banco1, "1", 5000m);

Console.WriteLine(conta1.Saldo);
Console.WriteLine(conta1.VerificarSaldo());
Console.WriteLine(conta1.Sacar(4m));
Console.WriteLine(banco1.Nome);
Console.WriteLine(banco1.CodigoBanco);
Console.WriteLine(banco1.Cnpj);



