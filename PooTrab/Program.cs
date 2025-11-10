using PooTrab;

Console.WriteLine("Inicio do exemplo de abstração!\n\n");

Banco banco1 = new ("Nubank", "123", "12345678912345");
Console.WriteLine(
    $"Banco 1 criado com sucessso!\n" +
    $"Nome: {banco1.Nome}\n" +
    $"Codigo Do Banco: {banco1.CodigoBanco}\n" +
    $"CNPJ: {banco1.Cnpj}\n\n");

Cliente cliente1 = new("Jorge", "077.545.900-34", "9926855615", "R. Berto Vargas, 654-732 - Xique-Xique, BA, 47400-000");
Console.WriteLine(
    $"Cliente 1 criado com sucesso!\n" +
    $"Nome: {cliente1.Nome}\n" +
    $"CPF: {cliente1.Cpf}\n" +
    $"Telefone: {cliente1.Telefone}\n" +
    $"Endereço: {cliente1.Endereco}\n\n");










