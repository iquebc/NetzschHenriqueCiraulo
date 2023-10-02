using Core.Entities;
using Repository;

namespace Core.UseCase
{
    public class ListAllMessages
    {
        public List<MessageModel> execute(IMessageRepository messageRepository)
        {
            return messageRepository.ListAllMessages();
        }
    }
}