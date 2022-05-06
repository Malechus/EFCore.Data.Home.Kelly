using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;

namespace EntityFrameworkCore.Data.Home.Kelly
{
    public class Translate
    {
        public static async Task<Item> GetItemFromBarcode(string apiRoot, string barcode)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    UriBuilder builder = new UriBuilder(apiRoot + "/item/query/");
                    builder.Query = "barcode=" + barcode;
                    string url = builder.ToString();
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Item fetchedItem = JsonSerializer.Deserialize<Item>(responseBody);

                    return fetchedItem;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
