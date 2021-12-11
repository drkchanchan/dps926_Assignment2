using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    static public class NetworkingManager
    {
        static private string url = "https://api.yelp.com/v3/businesses/search";
        static private string urlFood = "?term=";
        static private string urlLocation = "&location=";
        static private string urlLimit = "&limit=5";
        static private string urlSort = "&sort_by=rating";

        static private string headerKey = "VDTfNawD8xx-xPspxlYmk5TGuCDsyaTa3JZIzbBJryNFo1f9AG6YZKvdiVCETJwYtRFC9XqIi8F00Tl9BELi3LkwtBnYg-a6RZehzV-8V-fT2SZGRqlMP-qJZ1VbYXYx";

        static HttpClient client = new HttpClient();

        static public async Task<List<Business>> GetRestaurants(string city, string province, string food)
        {
            string completeURL = url + urlFood + food + urlLocation + city + "+" + province + urlLimit + urlSort;
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", headerKey);

            var response = await client.GetAsync(completeURL);
            if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new List<Business>();
            }
            else
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);

                var array = dic.ElementAt(0).Value;
                //Console.WriteLine(array);

                var finalList = JsonConvert.DeserializeObject<List<Business>>(array.ToString());
                
                return finalList;
            }
        }
        
    }
}
