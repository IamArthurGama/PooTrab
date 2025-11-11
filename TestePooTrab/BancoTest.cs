using PooTrab;

namespace TestePooTrab.TestesContas;

[TestClass]
public class BancoTest
{
    [TestMethod]
    public void TesteDeEntradaCorreta()
    {
        Banco banco = new("Nubank", "123", "51.678.618/0001-46");
        Assert.AreEqual("Nubank", banco.Nome);
        Assert.AreEqual("123", banco.CodigoBanco);
        Assert.AreEqual("51.678.618/0001-46", banco.Cnpj);
    }
    [TestMethod]
    public void TesteDeEntradaIncorreta()
    {
        // nome invalido
        Assert.ThrowsException<ArgumentException>(() => new Banco(null, "123", "51.678.618/0001-46")); // nome nulo
        Assert.ThrowsException<ArgumentException>(() => new Banco("", "123", "51.678.618/0001-46")); // nome vazio
        Assert.ThrowsException<ArgumentException>(() => new Banco("   ", "123", "51.678.618/0001-46")); // nome só espaços

        // codigo do banco inválido
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", "", "51.678.618/0001-46")); // código vazio
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", "12", "51.678.618/0001-46")); // código com 2 dígitos
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", "1234", "51.678.618/0001-46")); // código com 4 dígitos
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", " 23", "51.678.618/0001-46")); // código com espaço
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", "1A3", "51.678.618/0001-46")); // código com letra

        // cnpj inválido
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", "123", ""));                      // cnpj vazio
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", "123", null));                   // cnpj nulo
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", "123", "5167861800014"));        // cnpj com 13 dígitos
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", "123", "516786180001461233"));   // cnpj com mais de 14 dígitos
        Assert.ThrowsException<ArgumentException>(() => new Banco("Nubank", "123", "51.678.618/0001-AA"));   // cnpj com letras
    }
}

