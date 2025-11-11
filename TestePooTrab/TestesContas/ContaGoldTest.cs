using PooTrab;

namespace TestePooTrab.TestesContas;

[TestClass]
public class ContaGoldTest
{
    [TestMethod]
    public void TesteDeEntradaCorreta()
    {
        Banco banco1 = new("Caixa Econômica", "555", "12.345.678/0001-99");
        Cliente cliente1 = new("João", "123.456.789-00", "21999998888", "Rua das Palmeiras, 45");
        ContaGold conta1 = new(cliente1, banco1, "101");


        Banco banco2 = new("Banco do Brasil", "444", "22.333.444/0001-11");
        Cliente cliente2 = new("Lucas", "987.654.321-00", "21988887777", "Avenida do Sol, 99");
        ContaGold conta2 = new(cliente2, banco2, "202", 500m);

        decimal saldoEsperado;
 
        conta1.Depositar(1000m);
        saldoEsperado = 1000m;
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Sacar(200m);
        saldoEsperado = 798m; 
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Depositar(50m);
        saldoEsperado = 848m; 
        Assert.AreEqual(saldoEsperado, conta1.Saldo);

        conta1.Transferir(conta2, 150m);
        saldoEsperado = 694m; 
        Assert.AreEqual(saldoEsperado, conta1.Saldo);
   
        saldoEsperado = 650m; 
        Assert.AreEqual(saldoEsperado, conta2.Saldo);
    }
    [TestMethod]
    public void TesteDeEntradaIncorreta()
    {
        Banco banco = new("Nubank", "987", "86.569.122/0001-19");
        Cliente cliente = new("Erick", "187.098.110-36", "24999215995", "Rua Domingos José Dantas");
        ContaGold conta = new(cliente, banco, "234", 200m);
        ContaGold destino = new(cliente, banco, "345", 100m);

        //Deposito inválido
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Depositar(-20m)); // negativo
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Depositar(0m));   // zero

        //Saque inválido
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Sacar(-10m)); // negativo
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Sacar(0m));   // zero
        Assert.ThrowsException<ArgumentException>(() => conta.Sacar(199m)); // maior que saldo

        //Transferência inválida
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Transferir(destino, -5m)); // negativo
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => conta.Transferir(destino, 0m));  // zero
        Assert.ThrowsException<ArgumentException>(() => conta.Transferir(destino, 197m));          // maior que saldo
        Assert.ThrowsException<ArgumentException>(() => conta.Transferir(null, 50m));              // conta de destino nula
    }
}

