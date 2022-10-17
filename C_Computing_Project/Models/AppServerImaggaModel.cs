using RestSharp;

namespace C_Computing_Project.Models
{
    public class AppServerImaggaModel
    {
        public string GetImaggaService(string imageS)
        {
            var result = string.Empty;
            string Url = $"http://localhost:5152/api/Imagga?ImageSource={imageS}";
            var client = new RestClient(Url);
            var request = new RestRequest(new Uri(Url), Method.Get);
            RestResponse response = client.Execute(request);
            return "hi";
        }
    }
}
