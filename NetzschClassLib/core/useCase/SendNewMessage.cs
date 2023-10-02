using Core.Entities;
using Repository;

namespace Core.UseCase
{
    public class SendNewMessage
    {
        public void execute(MessageModel message, IMessageRepository messageRepository)
        {
            messageRepository.SendNewMessage(message);
        }
    }
}