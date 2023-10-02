using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetzschDeskApp.Model
{
    public class MessageModel
    {
        public string message { get; set; }

        public User sender { get; set; }

        public string sendAt { get; set; }
    }
}
