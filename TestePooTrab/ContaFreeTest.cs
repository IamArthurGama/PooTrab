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


    }
}
