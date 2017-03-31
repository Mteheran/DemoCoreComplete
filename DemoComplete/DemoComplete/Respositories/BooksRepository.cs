using DemoComplete.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DemoComplete.Repositories
{
    public static class BooksRepository
    {
        public static List<Book> GetBooks()
        { 
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000");
                MediaTypeWithQualityHeaderValue contentType =new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("/api/Books").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                List<Book> data = JsonConvert.DeserializeObject<List<Book>>(stringData);
                return data;
            }
        }

    }
}
