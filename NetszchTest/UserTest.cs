using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetszchTest
{
    public class UserTest
    {
        [Fact]
        public void ShouldCreateNewUser()
        {
            User user = new User("Henrique");
            Assert.Equal("Henrique", user.Name);
        }

        [Fact]
        public void ShouldValidadeInvalidUser()
        {
            Assert.Throws<ArgumentNullException>(() => new User(""));
        }
    }
}
