 

   namespace Tyuiu.KonevaDD.Sprint0.Task2.V0.Text
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVaild()
        {
            var name = "Дарья";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Дарья", res);

        
        
        
        }   
        
       
    }
}