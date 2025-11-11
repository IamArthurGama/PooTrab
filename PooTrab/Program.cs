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

Terminal.Narrador($"A primeira Conta a partir da classe abstrata será ContaFree, suas particularidades são suas taxas de saque e de transferencias.\n");

ContaFree conta1 = new(cliente1, banco1, "2134");
Console.WriteLine(
    $"Conta Free criada com sucesso!~\n" +
    $"Cliente: {cliente1.Nome}\n" +
    $"Banco: {banco1.Nome}\n" +
    $"Codigo Da Conta: {conta1.CodigoConta}\n" +
    $"Saldo: {conta1.Saldo:C2}\n"
    );

Terminal.Narrador(
    "Como não definimos o saldo na hora da criação ele ficou sem saldo no final da criação da conta.\n" +
    "Para resolver isso vamos realizar um deposito na conta gratuita.\n");

decimal valorDeposito;

Console.Write("Por favor, digite o valor que deseja depositar: ");

while (true)
{
    string entradaDoUsuario = Console.ReadLine();

    
    if (decimal.TryParse(entradaDoUsuario, out valorDeposito))
    {
        break;
    }
    else
    { 
        Console.WriteLine($"Valor '{entradaDoUsuario}' é inválido. Por favor, digite um número decimal válido:");
    }
}

Console.Clear();

conta1.Depositar(valorDeposito);
Console.WriteLine($"Deposito de {valorDeposito:C2} realizado na conta {conta1.CodigoConta}\n");

Terminal.Narrador($"Agora se verificarmos o saldo veremos que o deposito já está na conta.\n");
Console.WriteLine(conta1.VerificarSaldo());



Console.WriteLine("\n");

Terminal.Narrador(
    $"Vamos agora demonstrar o Saque.\n" +
    $"A sua 'ContaFree' (conta1) possui uma taxa de saque de {conta1.TaxaSaque:C2}.\n" +
    $"(Este valor é lido da propriedade 'TaxaSaque')."
    );

Terminal.Narrador($"\nSeu saldo atual é: {conta1.Saldo:C2}\n");
Console.Write("Por favor, digite o valor que deseja SACAR (ou '0' para cancelar): ");

while (true)
{
    string entradaSaque = Console.ReadLine();
    decimal valorSacar;

    if (decimal.TryParse(entradaSaque, out valorSacar))
    {
        if (valorSacar == 0)
        {
            Terminal.Narrador("Operação de saque cancelada.");
            break;
        }

        try
        {
            string resultadoSaque = conta1.Sacar(valorSacar);

            Console.Clear();
            Terminal.Narrador("Saque realizado com sucesso!");
            Console.WriteLine(resultadoSaque);
            break;
        }
        catch (ArgumentException ex)
        {
            Terminal.Narrador($"Erro: {ex.Message}");
            Terminal.Narrador($"Seu saldo é {conta1.Saldo:C2}. Tente um valor menor (ou '0' para cancelar):");
            Console.Write("> ");
        }
    }
    else
    {
        Terminal.Narrador($"Valor '{entradaSaque}' é inválido. Por favor, digite um número (ou '0' para cancelar):");
        Console.Write("> ");
    }
}

Terminal.Narrador($"\nSaldo atualizado da conta {conta1.CodigoConta}:");
Console.WriteLine(conta1.VerificarSaldo());
Console.WriteLine("\n");

Terminal.Narrador(
    "Vamos agora demonstrar a Transferência.\n\n" +
    "Vamos criar a 'conta2' como uma ContaGold."
    );

ContaGold conta2 = new(cliente1, banco1, "9876", 100m);

Terminal.Narrador(
    $"Criamos a 'conta2' (cód: {conta2.CodigoConta}) com um saldo inicial de {conta2.Saldo:C2}.\n\n" +
    $"A 'ContaFree' (conta1) possui uma taxa de transferência de {conta1.TaxaTransferencia:C2}.\n"
    );

Terminal.Narrador($"Saldo da conta1 (origem): {conta1.Saldo:C2}\n");
Console.Write($"Quanto você deseja TRANSFERIR da conta1 (Free) para a conta2 (Gold)? (ou '0' para cancelar): ");

while (true)
{
    string entradaTransf = Console.ReadLine();
    decimal valorTransferir;

    if (decimal.TryParse(entradaTransf, out valorTransferir))
    {
        if (valorTransferir == 0)
        {
            Terminal.Narrador("Operação de transferência cancelada.");
            break;
        }

        try
        {
            string resultadoTransf = conta1.Transferir(conta2, valorTransferir);

            Console.Clear();
            Terminal.Narrador("Transferência realizada com sucesso!");
            Console.WriteLine(resultadoTransf);
            break;
        }
        catch (ArgumentException ex)
        {
            Terminal.Narrador($"Erro: {ex.Message}");
            Terminal.Narrador($"Seu saldo é {conta1.Saldo:C2}. Tente um valor menor (ou '0' para cancelar):");
            Console.Write("> ");
        }
    }
    else
    {
        Terminal.Narrador($"Valor '{entradaTransf}' é inválido. Por favor, digite um número (ou '0' para cancelar):");
        Console.Write("> ");
    }
}

Terminal.Narrador($"\n--- Verificação Final dos Saldos ---\n");
Terminal.Narrador($"Saldo da Conta 1 (Free - Origem - {conta1.CodigoConta}):");
Console.WriteLine(conta1.VerificarSaldo());
Terminal.Narrador($"\nSaldo da Conta 2 (Gold - Destino - {conta2.CodigoConta}):");
Console.WriteLine(conta2.VerificarSaldo());

Terminal.Narrador("\n\n--- DEMONSTRAÇÃO CONTA DIAMOND (TAXA ZERO) ---\n");

Terminal.Narrador("Vamos criar uma 'ContaDiamond' (conta3) para o nosso Cliente 1.");

ContaDiamond conta3 = new(cliente1, banco1, "1111-DIAMOND", 10000m);

Terminal.Narrador(
    $"ContaDiamond (conta3) criada com saldo inicial de {conta3.Saldo:C2}.\n" +
    $"Vamos testar o saque da conta diamond, por ela ser uma conta exlusiva a taxa é zerada.\n"
    );

Console.Write("Por favor, digite o valor que deseja SACAR da conta3 (Diamond): ");

while (true)
{
    string entradaSaque = Console.ReadLine();
    decimal valorSacar;

    if (decimal.TryParse(entradaSaque, out valorSacar))
    {
        if (valorSacar == 0)
        {
            Terminal.Narrador("Operação de saque cancelada.");
            break;
        }

        try
        {

            string resultadoSaque = conta3.Sacar(valorSacar);

            Console.Clear();
            Terminal.Narrador("Saque da ContaDiamond realizado com sucesso!");
            Console.WriteLine(resultadoSaque);
            break;
        }
        catch (ArgumentException ex)
        {
            Terminal.Narrador($"Erro: {ex.Message}");
            Console.Write($"Seu saldo é {conta3.Saldo:C2}. Tente um valor menor (ou '0' para cancelar): ");
        }
    }
    else
    {
        Console.Write($"Valor '{entradaSaque}' é inválido. Digite um número (ou '0' para cancelar): ");
    }
}

Terminal.Narrador($"\nSaldo atualizado da conta3 (Diamond):");
Console.WriteLine(conta3.VerificarSaldo());
Console.WriteLine("\n");


Terminal.Narrador(
    $"Agora vamos transferir da 'ContaDiamond' (conta3) de volta para a 'ContaFree' (conta1).\n" +
    $"A taxa de transferência da Diamond também é ZERO."
    );

Terminal.Narrador($"Saldo atual da conta3 (Diamond) é: {conta3.Saldo:C2}\n");
Console.Write("Quanto deseja transferir da conta3 para a conta1? (ou '0' para cancelar): ");

while (true)
{
    string entradaTransf = Console.ReadLine();
    decimal valorTransferir;

    if (decimal.TryParse(entradaTransf, out valorTransferir))
    {
        if (valorTransferir == 0)
        {
            Terminal.Narrador("Operação de transferência cancelada.");
            break;
        }

        try
        {

            string resultadoTransf = conta3.Transferir(conta1, valorTransferir);

            Console.Clear();
            Terminal.Narrador("Transferência da ContaDiamond realizada com sucesso!");
            Console.WriteLine(resultadoTransf);
            break;
        }
        catch (ArgumentException ex)
        {
            Terminal.Narrador($"Erro: {ex.Message}");
            Terminal.Narrador($"Seu saldo é {conta3.Saldo:C2}. Tente um valor menor (ou '0' para cancelar):");
            Console.Write("> ");
        }
    }
    else
    {
        Terminal.Narrador($"Valor '{entradaTransf}' é inválido. Digite um número (ou '0' para cancelar):");
        Console.Write("> ");
    }
}

Terminal.Narrador($"\n--- Verificação Final dos Saldos ---");
Terminal.Narrador($"Saldo da Conta 1 (Free - {conta1.CodigoConta}):");
Console.WriteLine(conta1.VerificarSaldo());
Terminal.Narrador($"Saldo da Conta 2 (Gold - {conta2.CodigoConta}):");
Console.WriteLine(conta2.VerificarSaldo());
Terminal.Narrador($"Saldo da Conta 3 (Diamond - {conta3.CodigoConta}):");
Console.WriteLine(conta3.VerificarSaldo());











