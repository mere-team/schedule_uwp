using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;

namespace ScheduleApi
{
    public class TeacherScheduleApi : IScheduleApi
    {
        private readonly Dictionary<Type, string[]> _urlListDictionary; 

        public TeacherScheduleApi()
        {
            _urlListDictionary = new Dictionary<Type, string[]>
            {
                {typeof (Teacher), new[] { "http://ulstuschedule.azurewebsites.net/ulstu/teachers", "http://ulstuschedule.azurewebsites.net/ulstu/teacher/"}}
            };
        }

        public async Task<List<T>> GetListObjectsAsync<T>()
        {
            string url = _urlListDictionary[typeof(T)][0];

            var data = await MyWebClient.GetWebRequest(url);

            var list = new List<T>();
            try
            {
                list = JsonConvert.DeserializeObject<List<T>>(data);
            }
            catch (Exception)
            {
                // ignored
            }

            return list;
        }

        public async Task<T> GetObjectAsync<T>(int id)
        {
            string  url = _urlListDictionary[typeof(T)][1] + id;

            var data = await MyWebClient.GetWebRequest(url);

            var obj = JsonConvert.DeserializeObject<T>(data);

            return obj;
        }
    }
}