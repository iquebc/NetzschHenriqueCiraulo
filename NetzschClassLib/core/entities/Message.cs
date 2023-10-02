using System.Text.Json.Serialization;

namespace Core.Entities
{
    public class MessageModel
    {
        private string message;

        private User sender;

        private DateTime sendAt;

        public string Message
        {
            get { return message; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Message");

                message = value;
            }
        }

        public User Sender
        {
            get { return sender; }
            private set
            {
                if (value == null)
                    throw new ArgumentNullException("Sender");

                sender = value;
            }
        }

        public string SendAt
        {
            get { return $"{sendAt.ToShortDateString()} {sendAt.ToShortTimeString()}"; }
            set
            {
                sendAt = new DateTime();
            }
        }

        public MessageModel(string message, User sender)
        {
            Message = message;
            Sender = sender;
        }

        public static MessageModel NewMessage(string message, User sender)
        {
            return new MessageModel(message, sender);
        }

    }

    internal class JsonPropertyAttribute : Attribute
    {
    }
}