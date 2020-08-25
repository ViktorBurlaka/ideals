using System;
using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using UserApiTest.Requests;
using UserApiTest.Responses;

namespace UserApiTest
{
    [TestFixture]
    public class CreateUser
    {
        private System.Net.Http.HttpClient _client = new HttpClient();
        
        [Test]
        public async Task CreateUserTest()
        {
            var user = new CreateUserRequest("User1", "Manager");
            
            _client.BaseAddress = new Uri("https://reqres.in");
            var response = await _client.SendAsync(user.CreateRequestMessage());
            var createdUser = await response.ConvertToResponse<CreateUserResponse>();
            
            Assert.NotNull(createdUser);
            Assert.Equals(user.Name, createdUser.Name);
            Assert.Equals(user.Job, createdUser.Job);
            Assert.NotNull(createdUser.CreatedAt);
            Assert.True(!string.IsNullOrWhiteSpace(createdUser.Id));
        }
        
    }
}