using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using YGOCardSearch.Models;

namespace YGOCardSearch.DataProviders
{
    public class YGOProvider : ICardsProvider
    {
        public async Task<ICollection<CardModel>> GetAllCardsAsync()
        {
            string url = "https://db.ygoprodeck.com/api/v7/cardinfo.php";
            var ygoClient = new HttpClient() { BaseAddress = new Uri(url) };
            try
            {
                var request = await ygoClient.GetAsync(ygoClient.BaseAddress);
                if (request.IsSuccessStatusCode)
                {
                    var content = await request.Content.ReadAsStringAsync();
                    var model = JsonSerializer.Deserialize<CardModel>(content, new JsonSerializerOptions());
                    Console.WriteLine("Cards found: " + model.Data.Length);
                    var data = model.Data;

                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw new Exception(message: "ërror");
            }

        }



        public async Task<CardModel> GetCardAsync(int id)
        {
            string url = "http://db.ygoprodeck.com/api/v7/cardinfo.php?id=" + id.ToString();
            var ygoClient= new HttpClient() { BaseAddress = new Uri(url) };
            try
            {
                var request = await ygoClient.GetAsync(url);
                if (request.IsSuccessStatusCode)
                {
                    var content = await request.Content.ReadAsStringAsync();
                    var model = JsonSerializer.Deserialize<CardModel>(content, new JsonSerializerOptions());
                    Console.Write("Card found");
                    var data = model.Data[0];

                    return data;
                }
                else 
                {
                    Console.WriteLine("Card not found");
                    return null;
                }
            }
            catch
            {
                throw new Exception(message: "error");
                
            }
        }

        async Task<ICollection<CardModel>> ICardsProvider.GetSearchAsync(string search)
        {
            string url = "https://db.ygoprodeck.com/api/v7/cardinfo.php?fname=" + search;
            var ygoClient = new HttpClient() { BaseAddress = new Uri(url) };

            try
            {
                var request = await ygoClient.GetAsync(url);
                if (request.IsSuccessStatusCode)
                {
                    var content = await request.Content.ReadAsStringAsync();
                    var model = JsonSerializer.Deserialize<CardModel>(content, new JsonSerializerOptions());
                    Console.WriteLine("Cards found: " + model.Data.Length);
                    var data = model.Data;

                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw new Exception(message: "ërror");
            }

        }
    }
}