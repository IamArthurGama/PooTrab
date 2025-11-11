using PooTrab;

namespace TestePooTrab.TestesContas;

[TestClass]
public class ClienteTest
{
    [TestMethod]
    public void TesteDeEntradaCorreta()
    {
        Cliente cliente = new("Erick Ribeiro", "187.098.110-36", "24999215995", "Rua Domingos José Dantas, 127");

        Assert.AreEqual("Erick Ribeiro", cliente.Nome);
        Assert.AreEqual("187.098.110-36", cliente.Cpf);
        Assert.AreEqual("24999215995", cliente.Telefone);
        Assert.AreEqual("Rua Domingos José Dantas, 127", cliente.Endereco);
    }
    [TestMethod]
    public void TesteDeEntradaIncorreta()
    {
        //Nome inválido
        Assert.ThrowsException<ArgumentException>(() => new Cliente(null ,"187.098.110-36", "24999215995", "Rua Domingos José Dantas, 127"));//Nome nulo
        Assert.ThrowsException<ArgumentException>(() => new Cliente("", "187.098.110-36", "24999215995", "Rua Domingos José Dantas, 127"));//Nome vazio
        Assert.ThrowsException<ArgumentException>(() => new Cliente("   ", "187.098.110-36", "24999215995", "Rua Domingos José Dantas, 127"));//Nome só espaços

        //CPF inválido
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", null, "24999215995", "Rua Domingos José Dantas, 127"));//CPF nulo
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "", "24999215995", "Rua Domingos José Dantas, 127"));//CPF vazio
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "   ", "24999215995", "Rua Domingos José Dantas, 127"));//CPF só espaços
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "123", "24999215995", "Rua Domingos José Dantas, 127"));//CPF com menos de 11 dígitos
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "187.098.110-36123", "24999215995", "Rua Domingos José Dantas, 127"));//CPF com mais de 11 dígitos
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick RIbeiro", "187.098.110-36123A", "24999215995", "Rua Domingos José Dantas, 127"));//CPF com letra

        //Telefone inválido
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "187.098.110-36", null, "Rua Domingos José Dantas, 127"));//Telefone nulo
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro" , "187.098.110-36", "", "Rua Domingos José Dantas, 127"));//Telefone vazio
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "187.098.110-36", "   ", "Rua Domingos José Dantas, 127"));//Telefone só espaços
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "187.098.110-36","249999215995A" , "Rua Domingos José Dantas, 127"));//Telefone com letra
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "187.098.110-36", "2499921", "Rua Domingos José Dantas, 127"));//Telefone com menos de 8 dígitos

        //Endereço inválido
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "187.098.110-36", "24999215995", null));//Endereço nulo
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "187.098.110-36", "24999215995", ""));//Endereço vazio
        Assert.ThrowsException<ArgumentException>(() => new Cliente("Erick Ribeiro", "187.098.110-36", "24999215995", "   "));//Endereço só espaços
    }
}