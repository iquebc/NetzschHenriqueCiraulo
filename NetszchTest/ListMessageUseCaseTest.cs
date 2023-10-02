using Core.Entities;
using Core.UseCase;
using Repository;

namespace NetszchTest
{
    public class ListMessageUseCaseTest
    {
        readonly SendNewMessage _sendNewMessage = new SendNewMessage();
        readonly ListAllMessages _listAllMessages = new ListAllMessages();
        readonly MessageMockRepository _messageMockRepository = new MessageMockRepository();

        [Fact]
        public void ShouldListAllMessages()
        {
            User user = new User("Henrique");
            MessageModel messageModel = new MessageModel("Test Message", user);
            _sendNewMessage.execute(messageModel, _messageMockRepository);

            user = new User("Henrique Ciraulo");
            messageModel = new MessageModel("Test Message 2", user);
            _sendNewMessage.execute(messageModel, _messageMockRepository);

            List<MessageModel> messages = _listAllMessages.execute(_messageMockRepository);
            Assert.Equal(2, messages.Count);
        }
    }
}
