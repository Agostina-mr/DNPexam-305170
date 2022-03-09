using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Blazor.Models;

namespace Blazor.Data
{
    public class KinderGardenServices
    {
        private readonly HttpClient client;
        private string uri;

        public KinderGardenServices()
        {
            uri = "https://localhost:5001";
            client = new HttpClient();
        }
        
        public async Task<Child> AddChild(Child child)
        {
            var childAsJson = JsonSerializer.Serialize(child);
            var content = new StringContent(childAsJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{uri}/Children", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }

            var childAsJsonResponse = await response.Content.ReadAsStringAsync();
            var newChild = JsonSerializer.Deserialize<Child>(childAsJsonResponse);
            return newChild;
        }

        public async Task<List<Child>> GetAllChildren()
        {
            var responseMessage =
                await client.GetAsync($"{uri}/Children");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
            var result = await responseMessage.Content.ReadAsStringAsync();
            var children = JsonSerializer.Deserialize<List<Child>>(result);
            return children;
        }

        public async Task<Toy> AddToy(int childId, Toy toy)
        {
            var toyAsJson = JsonSerializer.Serialize(toy);
            var content = new StringContent(toyAsJson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{uri}/Owner/{childId}", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception();
            }

            var bookAsJsonResponse = await response.Content.ReadAsStringAsync();
            var newToy = JsonSerializer.Deserialize<Toy>(bookAsJsonResponse);
            return newToy; 
        }

        public async Task RemoveToy(int toyId)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{uri}/Children/Toys/{toyId}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
            
        }
    }
}