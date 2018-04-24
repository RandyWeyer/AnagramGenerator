using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramGenerator;

namespace AnagramGenerator.Tests
{
  [TestClass]
  public class AnagramGeneratorTest
  {
    [TestMethod]
    public void AreCharactersGreaterThanEachOther()
    {
      AnagramGenerator testAnagramGenerator = new AnagramGenerator();
      Assert.AreEqual(true, testAnagramGenerator.BIsGreaterThanA('a', 'b'));
    }
    [TestMethod]
    public void AreCharactersLessThanEachOther()
    {
      AnagramGenerator testAnagramGenerator = new AnagramGenerator();
      Assert.AreEqual(true, testAnagramGenerator.AIsLessThanA('a', 'b'));
    }


  }
}
