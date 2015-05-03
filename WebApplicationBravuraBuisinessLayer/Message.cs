using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationBravura.Business.dsWebApplicationBravuraTableAdapters;
using WebApplicationBravura.Business;
using System.Data;

namespace WebApplicationBravura.Business
{
    public class Message
    {
        public List<MessageItem> messageItemList { get; set; }
        public string messageString { get; set; }
        public DateTime entryDate { get; set; }
        private int _databaseId;

        public Message()
        {
            messageItemList = new List<MessageItem>();

        }

        //Gets all the messages from the database and returns a list with them
        public static List<Message> GetAllMessages()
        {
            MessagesTableAdapter taMessages = new MessagesTableAdapter();
            var dtMessages = taMessages.GetData();
            List<Message> allMessages = new List<Message>();
            foreach (dsWebApplicationBravura.MessagesRow menuRow in dtMessages.Rows)
            {
                Message messages = new Message();
                messages.messageString = menuRow.message;
                messages.entryDate = menuRow.entry_date;
                messages._databaseId = menuRow.ID;
                allMessages.Add(messages);

            }

            return allMessages;
            
        }

        //Save a new message to the database
        public void SaveNewMessage(string message)
        {
            MessagesTableAdapter taMessages = new MessagesTableAdapter();
            taMessages.InsertNewMessage(message, DateTime.Now);

        }
    }
}
