using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXTester.Model.Api;

namespace WXTester.BusinessModel
{
    public class AuthModel
    {
        public AccessTokenReturnObject GenerateAccessToken(string appId, string appSecret, string code, string grantType)
        {
            string scope = "snsapi_base";
            if (code.Equals("codeforsnsapi_userinfo"))
            {
                scope = "snsapi_userinfo";
            }

            var accessTokenReturnObject = new AccessTokenReturnObject() 
            { 
                OpenId = "123456",
                AccessToken = "YFUhZldLGg3FIQI6wV7fxculjnCX28C6jXTWY_xhwy98pBTy2Uia_eLAaz05Jp4veAa96d0IBEDfU-Q8yaMEVfMvLl1rJiWMSOACt3ClgOo",
                ExpiresIn = 7200,
                RefreshToken = "dwefwe",
                Scope = scope,
                UnionId = "unionidtest"
            };

            return accessTokenReturnObject;
        }
    }
}
