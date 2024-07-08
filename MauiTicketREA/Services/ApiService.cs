using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MauiTicketREA.Models;

namespace MauiTicketREA.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7164/api/") };
        }

        public async Task<List<DetailEvent>> GetEventsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<DetailEvent>>("DetailEvents");
        }

        // Add methods to interact with other endpoints as needed
    }
}

