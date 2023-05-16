namespace TestProject1
{
    public class Tests
    {       

        [Test]
        public void Test1()
        {
            
           Assert.AreEqual(Algorytm1.Repleace("ci¹gnik", '¹', 'u'), "ciugnik");
        }
    }
}