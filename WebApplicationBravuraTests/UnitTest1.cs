//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace WebApplicationBravuraTests
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//            var resultMessages = WebApplicationBravura.Business.Message.GetAllMessages();
//            Assert.IsTrue(resultMessages.Count > 0);

//            int countBeforeSave = resultMessages[0].messageItemList.Count;
//            resultMessages[0].SaveNewMessage("Message! test");
//            resultMessages = WebApplicationBravura.Business.Message.GetAllMessages();
//            int countAfterSave = resultMessages[0].messageItemList.Count;

//            Assert.IsTrue(countBeforeSave < countAfterSave);

//        }
//    }
//}
