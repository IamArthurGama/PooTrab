using PooTrab;

namespace TestePooTrab;

[TestClass]
public class ContaDiamondTest
{
    [TestMethod]
    public void TesteDeEntradaCorreta()
    {
        Banco banco1 = new("Itaú", "777", "60.701.190/0001-04");
        Cliente cliente1 = new("Thales", "123.456.789-00", "21999998888", "Rua das Palmeiras, 45");
        ContaDiamond conta1 = new(cliente1, banco1, "101");

        Banco banco2 = new("Santander", "888", "90.400.888/0001-77");
        Cliente cliente2 = new("Gabriel", "987.654.321-00", "21988887777", "Avenida do Sol, 99");
        ContaDiamond conta2 = new(cliente2, banco2, "202", 500m);

        decimal saldoEsperado;

        conta1.Depositar(1000m);
        saldoEsperado = 1000m;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Sacar(200m); 
        saldoEsperado = 800m;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Depositar(50m);
        saldoEsperado = 850m;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Transferir(conta2, 150m); 

        saldoEsperado = 700m; 
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        saldoEsperado = 650m; 
        Assert.AreEqual(saldoEsperado, conta2.Saldo);
    }

}

