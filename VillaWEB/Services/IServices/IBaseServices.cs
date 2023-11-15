using VillaWEB.Models;

namespace VillaWEB.Services.IServices
{
    public interface IBaseServices
    {
         APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
