using Clarivate.com.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Clarivate.com.Controllers
{
    [Route("api/[controller]/RandomUser")]
    [ApiController]
    public class RandomUserController : ControllerBase
    {
        [HttpGet]
        public async Task<HttpStatusCode> GetRandomUser()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://randomuser.me");
                client.DefaultRequestHeaders.Add("ContentType", "application/json");
                client.DefaultRequestHeaders.Authorization
                = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes($"{DataCheck.Username}:{DataCheck.Password}")));

                HttpResponseMessage response = client.GetAsync("https://randomuser.me").Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                    return HttpStatusCode.OK;
                }
                else
                {
                    Console.WriteLine(response.StatusCode.ToString());
                    return HttpStatusCode.NotFound;
                }
                
            }
        }


    }
}
