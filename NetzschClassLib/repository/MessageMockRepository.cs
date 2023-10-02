using Core.Entities;

namespace Repository
{
    public class MessageMockRepository : IMessageRepository
    {
        private readonly List<MessageModel> Messages;

        public MessageMockRepository(){
            Messages = new List<MessageModel>();
        }

        public List<MessageModel> ListAllMessages()
        {
            return Messages.OrderBy(x => x.SendAt).ToList();
        }

        public void SendNewMessage(MessageModel message)
        {
            Messages.Add(message);
        }
    }
}