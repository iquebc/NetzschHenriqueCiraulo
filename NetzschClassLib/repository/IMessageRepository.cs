using Core.Entities;
using Core.UseCase;

namespace Repository
{
    public interface IMessageRepository
    {
        void SendNewMessage(MessageModel message);

        List<MessageModel> ListAllMessages();
    }
}