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
            var result = IndexOf.Indexof("dupa", 'd');
            Assert.AreEqual(result, 0);
            Assert.AreEqual(IndexOf.Indexof("klocek", 'o'), 2);
            Assert.AreEqual(IndexOf.Indexof("minus", '2'), -1);          
        }

        [Test]
        public void Test_Is_MoreVowels()
        {
            //aaa
            //arrange
            var ini = new Vowels_and_consonants();
            //act
            var result = ini.IsMoreVowels("aaab");
            var result2 = ini.IsMoreVowels("bbbba");
            //assert
            Assert.IsTrue(result);
            Assert.IsFalse(result2);
        }
    }
}