namespace Library.Tests;
using TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string FechaPrueba = "26/07/2003";
        string Cambiado1 = DateFormatter.ChangeFormat(FechaPrueba);
        Assert.AreEqual(Cambiado1, "2003-07-26");

    }
    [Test]
    public void Test2()
    {
         string FechaPrueba1 = "05/2006/24";
        string Cambiado2 = DateFormatter.ChangeFormat(FechaPrueba1);
        Assert.AreEqual(Cambiado2, "Formato inválido");
    }
    [Test]
    public void Test3()
    {
        string FechaPrueba3 = "";
        string Cambiado3 = DateFormatter.ChangeFormat(FechaPrueba3);
        Assert.AreEqual(Cambiado3, "Formato inválido");
    }
}