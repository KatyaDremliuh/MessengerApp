using System;
using Newtonsoft.Json;

namespace MyMessenger
{
    class Program
    {

        static void Main(string[] args)
        {
            Message msg = new Message("RR", "Privet!", DateTime.UtcNow);
            //Console.WriteLine(msg.ToString());
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);

            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
        }
    }
}
