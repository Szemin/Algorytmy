namespace TestProject1
{
    public class Tests
    {       

        [Test]
        public void Test_Repleace()
        {            
            Assert.AreEqual(Algorytm1.Repleace("ci¹gnik", '¹', 'u'), "ciugnik");
            Assert.AreEqual(Algorytm1.Repleace("grzyb", 'y', '6'), "grz6b");
            Assert.AreEqual(Algorytm1.Repleace("fotowoltaika", 'o', ' '), "f t w ltaika");
            
        }
        [Test]
        public void Test_IndexOf()
        {
            Assert.AreEqual(IndexOf.Indexof("dupa", 'd'), 0);
            Assert.AreEqual(IndexOf.Indexof("klocek", 'o'), 2);
            Assert.AreEqual(IndexOf.Indexof("minus", '2'), -1);
        }
    }
}