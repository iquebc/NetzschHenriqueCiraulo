using Core.Entities;
using Core.UseCase;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetszchTest
{
    public class SendMessageUseCaseTest
    {
        readonly SendNewMessage _sendNewMessage = new SendNewMessage();
        readonly MessageMockRepository _messageMockRepository = new MessageMockRepository();

        [Fact]
        public void ShouldSendNewMessage()
        {
            User user = new User("Henrique");
            MessageModel messageModel = new MessageModel("Test Message", user);
            _sendNewMessage.execute(messageModel, _messageMockRepository);
            List<MessageModel> messages = _messageMockRepository.ListAllMessages();
            Assert.Single(messages);
        }
    }
}
