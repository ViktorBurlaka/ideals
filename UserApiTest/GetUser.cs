using System;
using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using UserApiTest.Requests;
using UserApiTest.Responses;

namespace UserApiTest
{
    [TestFixture]
    public class GetUser
    {
        private System.Net.Http.HttpClient _client = new HttpClient();
        
        [Test]
        public async Task GetUserTest()
        {
            _client.BaseAddress = new Uri("https://reqres.in");
            var response = await _client.SendAsync(new GetUserRequest("2").CreateRequestMessage());
            var user = await response.ConvertToResponse<GetUserResponse>();
            
            Assert.NotNull(user);
            Assert.NotNull(user.Data);
            Assert.NotNull(user.CompanyData);
            
            Assert.IsTrue(user.Data.FirstName.Contains("Janet"));
            Assert.IsTrue(user.Data.LastName.Contains("Weaver"));
            Assert.IsTrue(user.Data.Email.Contains("janet.weaver@reqres.in"));
            Assert.IsTrue(user.Data.Avatar.Contains("https://s3.amazonaws.com/uifaces/faces/twitter/josephstein/128.jpg"));
            Assert.IsTrue(user.CompanyData.Company.Contains("StatusCode Weekly"));
            Assert.IsTrue(user.CompanyData.Url.Contains("http://statuscode.org/"));
            Assert.IsTrue(user.CompanyData.Text.Contains("A weekly newsletter focusing on software development, infrastructure, the server, performance, and the stack end of things."));

        }
    }
}