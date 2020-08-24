using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using UserApiTest.Requests;
using UserApiTest.Responses;

namespace UserApiTest
{
    [TestFixture]
    public class Tests
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
        
        [Test]
        public async Task GetUserTest()
        {
            _client.BaseAddress = new Uri("https://reqres.in");
            var response = await _client.SendAsync(new GetUserRequest("2").CreateRequestMessage());
            var user = await response.ConvertToResponse<GetUserResponse>();
            
            Assert.NotNull(user);
            Assert.NotNull(user.Data);
            Assert.NotNull(user.CompanyData);
            
            Assert.Equals("Janet", user.Data.FirstName);
            Assert.Equals("", user.Data.Email);
                //дописати ассерти
        }
        
        [Test]
        public async Task UpdateUserTest()
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