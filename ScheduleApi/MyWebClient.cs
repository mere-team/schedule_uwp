using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScheduleApi
{
    public static class MyWebClient 
    {
        public static async Task<string> GetWebRequest(string address)
        {
            var handler = new HttpClientHandler();

            if (handler.SupportsAutomaticDecompression)
            {
                handler.AutomaticDecompression = DecompressionMethods.GZip |
                                                 DecompressionMethods.Deflate;
            }
            var httpClient = new HttpClient(handler);
            var str = await httpClient.GetStringAsync(address);

            return str;
        }
    }
}
