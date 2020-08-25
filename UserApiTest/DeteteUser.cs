using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using UserApiTest.Requests;

namespace UserApiTest
{
    [TestFixture]
    public class DeteteUser
    {
        private System.Net.Http.HttpClient _client = new HttpClient();
        
        [Test]
        public async Task DeleteUserTest()
        {
            var deleteUserRequest = new DeleteUserRequest("2");
            
            _client.BaseAddress = new Uri("https://reqres.in");
            var response = await _client.SendAsync(deleteUserRequest.CreateRequestMessage());
            
            Assert.NotNull(response);
            Assert.IsTrue(response.StatusCode == HttpStatusCode.NoContent);
        }
    }
}