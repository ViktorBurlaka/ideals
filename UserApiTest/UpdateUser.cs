using System;
using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using UserApiTest.Requests;
using UserApiTest.Responses;

namespace UserApiTest
{
    [TestFixture]
    public class UpdateUser
    {
        private System.Net.Http.HttpClient _client = new HttpClient();
        
        [Test]
        public async Task UpdateUserTest()
        {
            var user = new UpdateUserRequest("morpheus", "zion resident", "2");
            
            _client.BaseAddress = new Uri("https://reqres.in");
            var response = await _client.SendAsync(user.CreateRequestMessage());
            var updateUser = await response.ConvertToResponse<UpdateUserResponse>();
            
            
            Assert.NotNull(updateUser);
            Assert.Equals(user.Name, updateUser.Name);
            Assert.Equals(user.Job, updateUser.Job);
            Assert.Equals(DateTime.Now, updateUser.UpdateDate);
        }
    }
}