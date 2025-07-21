using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Recent_Games_Stats_Outputter
{
    public class QueryExecutor
    {

        private string url;
        private readonly string API_KEY = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9" +
            ".eyJqdGkiOiJlZGYwZTE4MC03YWI3LTAxMzgtZDM1YS0wMDFlODhkODU2NjAiLCJpc" +
            "3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTg5NzUyOTA4LCJwdWIiOiJibHVlaG9sZSI" +
            "sInRpdGxlIjoicHViZyIsImFwcCI6ImFsZXgtbXlzdGVyeW1hIn0.eImkcaol-TKjn" +
            "nNMq1JXaNgFOTtXYMVbLaE_97q3FaI";
        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
            }
        }

        public async Task<string> ExecuteQuery()
        {
            if (url != null)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.url);
                request.Method = "GET";
                request.Headers["Authorization"] = "Bearer " + this.API_KEY;
                request.Accept = "application/vnd.api+json";
                StreamReader reader;
                HttpWebResponse response = null;
                HttpStatusCode statusCode;


                try
                {
                    var res = await Task.Run(() => request.GetResponseAsync());
                    response = (HttpWebResponse)res;
                }
                catch (WebException webException)
                {
                    response = (HttpWebResponse)webException.Response;
                }

                statusCode = response.StatusCode;

                Stream receiveStream = await Task.Run(() => response.GetResponseStream());
                reader = new StreamReader(receiveStream, Encoding.GetEncoding("utf-8"));

                if (reader != null)
                {

                    Console.WriteLine("Response Code: " + (int)statusCode + " - " + statusCode.ToString());

                    if ((int)statusCode == 200)
                    {
                        string json = reader.ReadToEnd();
                        Console.WriteLine("json object receieved: " + json);
                        return json;
                    }
                    
                }
            }
  
            return null;
        }
    }
}
