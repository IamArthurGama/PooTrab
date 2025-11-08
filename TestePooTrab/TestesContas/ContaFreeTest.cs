using PooTrab;

namespace TestePooTrab.TestesContas;

[TestClass]
public class ContaFreeTest
{
    [TestMethod]
    public void TesteDeEntradaCorreta()
    {
        Banco banco1 = new("Nubank", "123", "51.678.618/0001-46");
        Cliente cliente1 = new("Arthur", "046.283.430-12", "96991334564", "Rua unicornio verde");
        ContaFree conta1 = new(cliente1, banco1, "1");

        Banco banco2 = new("Bradesco", "321", "17.013.336/0001-91");
        Cliente cliente2 = new("Roberval", "984.526.620-76", "96991334564", "Rua dor na nuca");
        ContaFree conta2 = new(cliente2, banco2, "2", 200m);

        decimal saldoEsperado;

        conta1.Depositar(300m);
        saldoEsperado = 300;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Sacar(50m);
        saldoEsperado = 240;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Depositar(10m);
        saldoEsperado = 250;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);
        Console.WriteLine($"Antes: {conta1.Saldo}");

        conta1.Transferir(conta2, 10m);

        saldoEsperado = 210;
        Assert.AreEqual(saldoEsperado, conta2.Saldo);

        saldoEsperado = 235;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

    }
    [TestMethod]
    public void testeDeEntradaIncorreta()
    {
        Banco banco = new("Nubank", "987", "86.569.122/0001-19");
        Cliente cliente = new("Erick", "187.098.110-36", "24999215995", "Domingos José Dantas, ");
        ContaFree conta = new(cliente, banco, "234", 200m);
        ContaFree contaParaTransferencia = new(cliente, banco, "345", 100m);

        //Constructor
        Assert.ThrowsException<ArgumentException>(() => new ContaFree(cliente, banco, null, 100m)); // cod conta nulo
        Assert.ThrowsException<ArgumentException>(() => new ContaFree(cliente, banco, "", 100m)); // cod conta vazio
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ContaFree(cliente, banco, "303", -50m)); // saldo negativo na criação

        //Saque
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Sacar(-30m)); // saque negativo
        Assert.ThrowsException<ArgumentException>(() => conta.Sacar(196m)); // saque maior que saldo
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Sacar(0m)); // saque zero

        //Deposito
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Depositar(-20m)); // deposito negativo
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Depositar(0m)); // deposito zero

        //Transferencia
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Transferir(contaParaTransferencia, -100m)); // transferencia negativa
        Assert.ThrowsException<ArgumentException>(() => conta.Transferir(contaParaTransferencia, 196m)); // transferencia maior que saldo
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Transferir(contaParaTransferencia, 0m)); // transferencia zero
        Assert.ThrowsException<ArgumentException>(() => conta.Transferir(null, 50m)); // transferencia para conta nula
    }
}
