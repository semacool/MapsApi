using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WorkMaps
{
    public class Client<T>
        where T : IService, new()
    {
        T service { get; set; }
        HttpClient http { get; set; }

        public Client()
        {
            service = new T();
            http = new HttpClient();

            http.DefaultRequestHeaders.Add("User-Agent", "C#App");
        }
        public async Task<string> Search(string address,byte limit, float polygons) 
        {
            string query = service.Convert(address, limit, polygons);   

            HttpResponseMessage Response = await http.GetAsync(query);
            if (!Response.IsSuccessStatusCode) throw new Exception($"StatusCode:{Response.StatusCode}");

            string answer = await Response.Content.ReadAsStringAsync();
            return answer;
        }
    }
}
