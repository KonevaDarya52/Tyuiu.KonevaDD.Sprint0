 

   namespace Tyuiu.KonevaDD.Sprint0.Task2.V0.Text
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVaild()
        {
            var name = "�����";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������, �����", res);

        
        
        
        }   
        
       
    }
}