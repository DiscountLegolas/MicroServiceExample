using Newtonsoft.Json;
using RestSharp;

namespace Mvc.Models
{
    public class ClientCred
    {
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string grant_type { get; set; }
        public string scope { get; set; }

    }
    public class Token
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
        public string scope { get; set; }
        public static Token GetToken()
        {
            var client = new RestClient("https://localhost:44351");
            var req = new RestRequest("gettoken", method: Method.Post);
            var config = new ClientCred() { client_id = "m2m.client", client_secret = "511536EF-F270-4058-80CA-1C89C192F69A", grant_type = "client_credentials", scope = "scope1" };
            req.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            req.AddObject(config);
            //req.AddBody(config);
            var a = client.Execute(req).Content;
            Token token = JsonConvert.DeserializeObject<Token>(a);
            return token;
        }
    }
}
