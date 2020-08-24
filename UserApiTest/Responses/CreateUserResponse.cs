using System;
using Newtonsoft.Json;

namespace UserApiTest.Responses
{
    public class CreateUserResponse        
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("job")]
        public string Job { get; set; }
        
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}