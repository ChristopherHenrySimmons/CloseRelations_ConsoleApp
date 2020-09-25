using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;

namespace HelloWorldApplication
{
	class HelloWorld
	{
		static void Main(string[] args)
		{
			var client = new RestClient("https://localhost:44333/");

			var request = new RestRequest("api/v1/login/personnel", DataFormat.Json);

			request.AddHeader("Content-Type", "application/json");
			request.AddParameter("application/json", 
                    "{\r\n\r\n    \"email\": \"" + 
                         loginCredentals.email + 
                    "\",\r\n    \"password\": \"" + 
                         loginCredentals.password + "\"\r\n\r\n\r\n}",
                    ParameterType.RequestBody);

			var response = client.Post(request);

               Personnel personnel = JsonConvert.DeserializeObject<Personnel>(response.Content.ToString());

          }
	}

     public class loginCredentals
     {

          public static string email = "@protonmail.ch";
          public static string password = "Password123";
     
     }

     // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
     public class Personnel
     {
          public int PersonnelNumber { get; set; }
          public string LastName { get; set; }
          public string FirstName { get; set; }
          public string Email { get; set; }
          public string Password { get; set; }
          public string Mobile { get; set; }
          public string StationCode { get; set; }
          public int? ReportsTo { get; set; }
          public string JobTitle { get; set; }
          public bool Verified { get; set; }
     }



}
