using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScheduleApi
{
    public interface IScheduleApi
    {
        Task<List<T>> GetListObjectsAsync<T>();
        Task<T> GetObjectAsync<T>(int id);
    }
}