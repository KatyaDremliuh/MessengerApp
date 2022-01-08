using System;

namespace MyMessenger
{
    [Serializable] 
    public class Message // для сериализации класс должен быть public
    {
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message(string userName, string messageText, DateTime timeStamp)
        {
            UserName = userName;
            MessageText = messageText;
            TimeStamp = timeStamp;
        }

        // ctor по умолчанию
        public Message()
        {
            UserName = "System";
            MessageText = "Server is running...";
            TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            string output = $"{UserName} <{TimeStamp}>: {MessageText}";
            return output;
        }
    }
}
