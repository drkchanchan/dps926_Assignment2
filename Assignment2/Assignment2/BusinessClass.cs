using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Assignment2
{
    //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Category
    {
        public string Alias { get; set; }
        public string Title { get; set; }
    }

    public class Coordinates
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Location
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public List<string> DisplayAddress { get; set; }
    }

    public class Business
    {

        [PrimaryKey, AutoIncrement]
        public int primeKey { get; set; }
        public string Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        [JsonProperty(PropertyName = "image_url")]
        public string ImageUrl { get; set; }
        public bool IsClosed { get; set; }
        public string Url { get; set; }
        public int ReviewCount { get; set; }
        [Ignore]
        public List<Category> Categories { get; set; }
        public double Rating { get; set; }
        [Ignore]
        public Coordinates Coordinates { get; set; }
        [Ignore]
        public List<object> Transactions { get; set; }
        public string Price { get; set; }
        [Ignore]
        public Location Location { get; set; }
        public string Phone { get; set; }
        public string DisplayPhone { get; set; }
        public double Distance { get; set; }
    }

    public class Center
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

    public class Region
    {
        public Center Center { get; set; }
    }

    public class Root
    {
        public List<Business> Businesses { get; set; }
        public int Total { get; set; }
        public Region Region { get; set; }
    }


}
