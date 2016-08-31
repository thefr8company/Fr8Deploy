using System;
using System.Threading.Tasks;
using System.Web.Http;
using Fr8.Infrastructure.Data.DataTransferObjects;
using Fr8.TerminalBase.Services;

namespace $safeprojectname$.Controllers
{
    [RoutePrefix("authentication")]
    public class AuthenticationController : ApiController
    {
        private readonly IHubLoggerService _loggerService;

        public AuthenticationController()
        {
        }

        [HttpPost]
        [Route("request_url")]
        public ExternalAuthUrlDTO GenerateOAuthInitiationURL()
        {

            // paste here auth logic code

            var externalAuthUrlDTO = new ExternalAuthUrlDTO()
            {
            };

            return externalAuthUrlDTO;
        }

        [HttpPost]
        [Route("token")]
        public async Task<AuthorizationTokenDTO> GenerateOAuthToken(ExternalAuthenticationDTO externalAuthDTO)
        {
            try
            {
                string code;
                string state;
                
                // paste here auth logic code

                return new AuthorizationTokenDTO
                {
                    //Token = oauthToken,
                    //ExternalAccountId = userInfo.UserId,
                    //ExternalAccountName = userInfo.UserName,
                    //ExternalStateToken = state,
                };
            }
            catch (Exception ex)
            {
                await _loggerService.ReportTerminalError(ex, externalAuthDTO.Fr8UserId);

                return new AuthorizationTokenDTO()
                {
                    Error = "An error occurred while trying to authorize, please try again later."
                };
            }
        }
        
    }
}