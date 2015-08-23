using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WXTester.BusinessModel;
using WXTester.Model.Api;

namespace WXTester.Api.Controllers
{
    [RoutePrefix("sns")]
    public class SnsController : ApiController
    {
        private AuthModel authModel = new AuthModel();

        /// <summary>
        /// Mock https://api.weixin.qq.com/sns/oauth2/access_token?appid=APPID&secret=SECRET&code=CODE&grant_type=authorization_code
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="appSecret"></param>
        /// <param name="code"></param>
        /// <param name="grantType"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("oauth2/access_token")]
        public AccessTokenReturnObject AccessToken([FromUri(Name = "appid")]string appId,
            [FromUri(Name = "secret")]string appSecret,
            [FromUri(Name = "code")]string code,
            [FromUri(Name = "grant_type")]string grantType)
        {

            var accessTokenResult = authModel.GenerateAccessToken(appId, appSecret, code, grantType);

            return accessTokenResult;
        }
    }
}
