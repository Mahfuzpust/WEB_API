﻿using VillaWEB.Models;

namespace VillaWEB.Services.IServices
{
    public interface IBaseService
    {
		// APIResponse responseModel { get; set; }
		//Task<T> SendAsync<T>(APIRequest apiRequest);


		APIResponse responseModel { get; set; }
		Task<T> SendAsync<T>(APIRequest apiRequest);
	}
}
