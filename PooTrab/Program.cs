using PooTrab;

Terminal.Narrador("Inicio do exemplo de abstração!\n\n");

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

Terminal.Narrador(
    $"Banco e Cliente são requisitos para o nosso exemplo de abstração acontecer.\n\n" +
    $"Conta será nossa classe abstrata, nela que teremos um molde de onde todas as outras derivadas vão se basear.\n\n"
);

Terminal.Narrador(
    $"Conta sempre pede como padrão os seguintes parâmetros:\n" +
    $"- Cliente\n" +
    $"- Banco\n" +
    $"- Codigo da Conta\n" +
    $"- Saldo (Sendo Opcional)\n" +
    $"(Cada parametro possui suas propriedades.)\n\n" +
    $"Possue os seguintes métodos:\n" +
    $"- Sacar()\n" +
    $"- Transferir()\n" +
    $"- Depositar()\n" +
    $"- VerificarSaldo()\n\n"
);

Terminal.Narrador($"A primeira Conta a partir da classe abstrata será ContaFree, suas particularidades são suas taxas de saque e de transferencias.");

ContaFree conta1 = new(cliente1, banco1, "2134");
Console.WriteLine();









