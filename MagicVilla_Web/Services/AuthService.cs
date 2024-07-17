using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;
using MagicVilla_Utility;
using System;

namespace MagicVilla_Web.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<AuthService> _logger;
        private string villaUrl;
        public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration, ILogger<AuthService> logger) : base(clientFactory, logger)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
            _logger = logger;
        }

        public Task<T> LoginAsync<T>(LoginRequestDTO objToCreate)
        {
            string url = villaUrl + "api/UserAuth/login";
            _logger.LogInformation("LoginAsync started with URL: {Url}", url);
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = objToCreate,
                Url = villaUrl + "api/v1/UserAuth/login"
            });
        }

        public Task<T> RegisterAsync<T>(RegisterationRequestDTO objToCreate)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = objToCreate,
                Url = villaUrl + "api/v1/UserAuth/register"
            });
        }
    }
}
