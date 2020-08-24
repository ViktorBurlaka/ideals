using Newtonsoft.Json;

namespace UserApiTest.Responses
{
    public class GetUserResponse
    {
        [JsonProperty("data")]
        public UserData Data { get; set; }
        [JsonProperty("ad")]
        public CompanyData CompanyData { get; set; }
    }

    public class UserData
    {
        public string Id { get; set; }
        public string Email { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        public string Avatar { get; set; }
    }

    public class CompanyData
    {
        public string Company { get; set; }
        public string Url { get; set; }
        public string Text { get; set; }
    }
}