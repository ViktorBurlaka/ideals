using System;
using Newtonsoft.Json;

namespace UserApiTest.Responses
{
    public class UpdateUserResponse
    {
        
            [JsonProperty("name")]
            public string Name { get; set; }
        
            [JsonProperty("job")]
            public string Job { get; set; }
        
            [JsonProperty("updatedAt")]
            public DateTime UpdateDate { get; set; }
        
    }
}