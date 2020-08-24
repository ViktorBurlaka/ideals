using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace UserApiTest.Requests
{
    public class CreateUserRequest : RequestBase
    {
        public CreateUserRequest()
        {
        }

        public CreateUserRequest(string name, string job)
        {
            Name = name;
            Job = job;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("job")]
        public string Job { get; set; }
        
        public override HttpRequestMessage CreateRequestMessage()
        {
            return base.CreateRequest(this, "/api/users", HttpMethod.Post);
        }
    }
}