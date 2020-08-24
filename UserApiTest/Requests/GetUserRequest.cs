using System.Net.Http;

namespace UserApiTest.Requests
{
    public class GetUserRequest : RequestBase
    {
        public GetUserRequest(string id)
        {
            Id = id;
        }

        public string Id { get; }

        public override HttpRequestMessage CreateRequestMessage()
        {
            return base.CreateRequest(this, $"/api/users/{Id}", HttpMethod.Get);
        }
    }
}