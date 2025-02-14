﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment1.Models;

namespace Assignment1.Data {
    public class CloudAdultService : IAdultService {

        private string uri1 = "https://localhost:44350/api";
        private string uri = "http://dnp.metamate.me";
        private readonly HttpClient client;

        public CloudAdultService() {
            client = new HttpClient();
        }

        public async Task<IList<Adult>> GetAdults()
        {
            Task<string> stringAsync = client.GetStringAsync(uri1+"/Adults");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
           return result;
        }

        public async Task AddAdultAsync(Adult adult) {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PutAsync(uri1+"/Adults", content);
        }

        public async Task EditAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PatchAsync($"{uri1}/Adults/{adult.Id}", content);
        }

        public async Task<Adult> GetById(int Id)
        {
            Task<string> stringAsync = client.GetStringAsync(uri1+$"/Adults/{Id}");
            string message = await stringAsync;
            Adult result = JsonSerializer.Deserialize<Adult>(message);
            return result;
        }

        public async Task RemoveAdultAsync(int adultId) {
            await client.DeleteAsync($"{uri1}/Adults/{adultId}");
        }

        public async Task UpdateAdultAsync(Adult adult) {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync($"{uri1}/Adults/{adult.Id}", content);
        }

    }
}