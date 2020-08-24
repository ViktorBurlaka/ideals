using System.Net.Http;

namespace UserApiTest.Requests
{
    public class DeleteUserRequest : RequestBase
    {
        public DeleteUserRequest(string id)
        {
            Id = id;
        }

        public string Id { get; }
        public override HttpRequestMessage CreateRequestMessage()
        {
            return base.CreateRequest(this, $"/api/users/{Id}", HttpMethod.Delete);
        }
    }
}