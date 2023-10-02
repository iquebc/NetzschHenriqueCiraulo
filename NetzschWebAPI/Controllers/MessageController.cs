using Core.Entities;
using Core.Entities.DTO;
using Core.UseCase;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace NetzschWebAPI.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private IMessageRepository _messageMockRepository;

        public MessageController(IMessageRepository messageRepository){
            _messageMockRepository = messageRepository;
        }

        [HttpGet(Name = "GetAllMessages")]
        public IActionResult GetAllMessages()
        {
            List<MessageModel> messages = new ListAllMessages().execute(_messageMockRepository);
            return Ok(messages);
        }

        [HttpPost(Name = "SendMessage")]
        public IActionResult SendMessage([FromBody] MessageDTO messageDTO)
        {
            User sender = new User(messageDTO.UserName);
            MessageModel message = MessageModel.NewMessage(messageDTO.Message, sender);
            new SendNewMessage().execute(message, _messageMockRepository);
            return Ok();
        }
    }
}