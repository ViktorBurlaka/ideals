using System.Net.Http;
using Newtonsoft.Json;

namespace UserApiTest.Requests
{
    public class UpdateUserRequest : RequestBase
    {
        public UpdateUserRequest()
        {
        }

        public UpdateUserRequest(string name, string job, string id)
        {
            Name = name;
            Job = job;
            Id = id;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("job")]
        public string Job { get; set; }
        
        public string Id { get; }

        public override HttpRequestMessage CreateRequestMessage()
        {
            return base.CreateRequest(this, $"/api/users{Id}", HttpMethod.Put);
        }
    }
}
