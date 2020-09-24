using RestSharp;
using RestSharp.Authenticators;
namespace HelloWorldApplication
{
	class HelloWorld
	{
		static void Main(string[] args)
		{
			var client = new RestClient("https://localhost:44333/");

			var request = new RestRequest("api/v1/login/personnel", DataFormat.Json);

			request.AddHeader("Content-Type", "application/json");
			request.AddParameter("application/json", "{\r\n\r\n    \"email\": \"@protonmail.ch\",\r\n    \"password\": \"Password123\"\r\n\r\n\r\n}", ParameterType.RequestBody);

			var response = client.Post(request);
		}
	}
}
