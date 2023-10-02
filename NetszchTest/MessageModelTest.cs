using Core.Entities;

namespace NetszchTest
{
    public class MessageModelTest
    {
        [Fact]
        public void ShouldCreateNewMessage()
        {
            User user = new User("Henrique");
            MessageModel messageModel = new MessageModel("Test Message", user);
            Assert.Equal("Test Message", messageModel.Message);
            Assert.Equal("Henrique", messageModel.Sender.Name);
        }

        [Fact]
        public void ShouldValidadeInvalidMessage()
        {
            User user = new User("Henrique");
            Assert.Throws<ArgumentNullException>(() => new MessageModel("", user));
        }
    }
}