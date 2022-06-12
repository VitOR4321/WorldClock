using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;

namespace WebApplication1.Pages
{
    public class America_New_YorkModel : PageModel
    {
        public string abbreviation { get; set; }
        public string client_ip { get; set; }
        public string datetime { get; set; }
        public string day_of_week { get; set; }
        public string day_of_year { get; set; }
        public string dst { get; set; }
        public string dst_from { get; set; }
        public string dst_offset { get; set; }
        public string dst_until { get; set; }
        public string raw_offset { get; set; }
        public string timezone { get; set; }
        public string unixtime { get; set; }
        public string utc_datetime { get; set; }
        public string utc_offset { get; set; }
        public string week_number { get; set; }


        public void OnGet()
        {
            abbreviation = Abbreviation();
            client_ip = Client_ip();
            datetime = Datetime();
            day_of_week = Day_of_week();
            day_of_year = Day_of_year();
            dst = Dst();
            dst_from = Dst_from();
            dst_offset = Dst_offset();
            dst_until = Dst_until();
            raw_offset = Raw_offset();
            timezone = Timezone();
            unixtime = Unixtime();
            utc_datetime = Utc_datetime();
            utc_offset = Utc_offset();
            week_number = Week_number();
        }


        public string API()
        {

            var url = "https://worldtimeapi.org/api/timezone/America/New_York";


            var request = WebRequest.Create(url);
            request.Method = "GET";

            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            return data;
        }
        public string Abbreviation()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["abbreviation"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }

        public string Client_ip()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["client_ip"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Datetime()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["datetime"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Day_of_week()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["day_of_week"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Day_of_year()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["day_of_year"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Dst()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["dst"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Dst_from()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["dst_from"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Dst_offset()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["dst_offset"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Dst_until()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["dst_until"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Raw_offset()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["raw_offset"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Timezone()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["timezone"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Unixtime()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["unixtime"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Utc_datetime()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            var jsonString = JsonSerializer.Serialize(" " + jsonObject["utc_datetime"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
        public string Utc_offset()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            string jsonString = JsonSerializer.Serialize(" " + jsonObject["utc_offset"]);
            string result = jsonString.Substring(2);
            return result;
        }
        public string Week_number()
        {
            string data = API();
            JObject jsonObject = JObject.Parse(data);
            string jsonString = JsonSerializer.Serialize(" " + jsonObject["week_number"]);
            string result = jsonString.Substring(1, jsonString.Length - 2);
            return result;
        }
    }
}
