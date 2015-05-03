using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationBravura.Business;

namespace WebApplicationBravura
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            List<Message> messagesFromDatabase = Message.GetAllMessages();

            foreach (Message messages in messagesFromDatabase)
            {
                foreach (MessageItem item in messages.Message)
                {
                    Console.WriteLine("Message is: " + item.message + " on Date: " + item.date);

                }
            }

            Console.ReadKey();

        }
    }
}
