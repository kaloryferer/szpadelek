using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Szpadelek
{
    public class WApi
    {
        private const string appKey = "sugQ0NCMqb";
        private const string appSecret = "NtsFPAaQKJ";
        private int mainPageNumber = 1;

        HttpClient client;

        public WApi()
        {
            client = new HttpClient();
        }

        public async Task<List<ResLinks>> GetGlowna()
        {
            List<ResLinks> Glowna = null;

            string url = "http://a.wykop.pl/links/promoted/appkey/" + appKey + "/page/"+mainPageNumber+"/";
            string hashString = string.Format(appSecret + url);
            string hash = MD5.GetMd5String(hashString);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("apisign", hash);


            string result = await client.GetStringAsync(url);
            Glowna = JsonConvert.DeserializeObject<List<ResLinks>>(result);


            return Glowna;
        }

        public async Task<ResLinks> GetLink(string id)
        {
            ResLinks link = null;

            string url = "http://a.wykop.pl/link/index/"+id+"/appkey/" + appKey + "/";
            string hashString = string.Format(appSecret + url);
            string hash = MD5.GetMd5String(hashString);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("apisign", hash);


            string result = await client.GetStringAsync(url);
            link = JsonConvert.DeserializeObject<ResLinks>(result);


            return link;
        }

        public async void F()
        {

            string url = "http://a.wykop.pl/links/promoted/appkey/" + appKey + "/page/1/";
            string hashString = string.Format(appSecret + url);
            string hash = MD5.GetMd5String(hashString);
            client.DefaultRequestHeaders.Add("apisign", hash);


            string result = await client.GetStringAsync(url);
            List<ResLinks> respond = JsonConvert.DeserializeObject<List<ResLinks>>(result);
        }    
    }
}
