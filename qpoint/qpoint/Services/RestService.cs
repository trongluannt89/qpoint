using qpoint.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Net.Http;
using System.Diagnostics;

namespace qpoint.Services
{
    public class RestService : IRestService
    {
        HttpClient client;

        public List<Language> Languages { get; private set; }

        public RestService()
        {
            client = new HttpClient();
        }        

        public async Task<List<Language>> RefreshLanguageDataAsync()
        {
            var sUrl = ConstantURL.RestUrl + "Languages";
            Languages = new List<Language>();
            Uri uri = new Uri(string.Format(sUrl, string.Empty));
            try {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode) { 
                    string content = await response.Content.ReadAsStringAsync();
                    Languages = JsonConvert.DeserializeObject<List<Language>>(content);
                }
            }
            catch (Exception ex) {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return Languages;
        }
        
        public Task SaveTodoItemAsync(Language item, bool isNewItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTodoItemAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
