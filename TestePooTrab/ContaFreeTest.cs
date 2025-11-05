using PooTrab;

namespace TestePooTrab;

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
        saldoEsperado = 250;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Depositar(10m);
        saldoEsperado = 260;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Transferir(conta2, 10m);

        saldoEsperado = 210;
        Assert.AreEqual(saldoEsperado, conta2.Saldo);

        saldoEsperado = 250;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

    }
}
