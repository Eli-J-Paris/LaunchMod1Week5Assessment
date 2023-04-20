using UserNameSpace;
namespace UserTests
{
    public class UserTest
    {
        [Fact]
        public void IsCreated()
        {
            User user1 = new User("Eli", "123@gmail.com");

            Assert.Equal("Eli", user1.Name);
            Assert.Equal("123@gmail.com", user1.Email);

        }

        [Fact]
        public void Check_IsSetupCompleteMethod_ReturnsTrueBool()
        {
            User user1 = new User("Eli", "123@gmail.com");
            
            user1.CreatePassword("123@gmail.com", "abc");
            bool setup = user1.IsSetupComplete();

            Assert.True(setup);

        }

        [Fact]
        public void Check_CreatePasswordMethod_AssignsAPasswordToPasswordProperty()
        {
            User user1 = new User("Eli", "123@gmail.com");
            user1.CreatePassword("123@gmail.com", "abc");

            Assert.True(user1.PasswordCreated);
        }

        [Fact]
        public void Check_LogInMethod_ReturnsAStringBasedOnIfPasswordsMatch()
        {
            User user1 = new User("Eli", "123@gmail.com");
            user1.CreatePassword("123@gmail.com", "abc");

            User user2 = new User("Eli2", "1234@gmail.com");
            user2.CreatePassword("abc@gmail.com", "123");

            string loggedIn = user1.LogIn("abc");
            string notLoggedIn = user2.LogIn("efg");

            Assert.Equal("Logged In", loggedIn);
            Assert.Equal("Not Logged In", notLoggedIn);
        }
    }
}