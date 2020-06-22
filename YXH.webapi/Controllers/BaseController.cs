using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;

namespace YXH.webapi.Controllers
{
    public class BaseController : ControllerBase
    {
        protected StringValues JWT;

        /// <summary>
        /// 获取JWT的paload参数
        /// </summary>
        /// <returns></returns>
        //protected JWTToken GetJWTToken(ref RequestDto requestDto)
        //{
        //    JWTToken result = null;
        //    var json = GetJWT(false);
        //    if (json.success)
        //    {
        //        if (json.JWTToken.ExpireTime < DateTime.Now)
        //        {
        //            requestDto.Msg = "jwt已过期";
        //            requestDto.Code = "-1";
        //        }
        //        else
        //        {
        //            result = json.JWTToken;
        //        }
        //        //result = json.JWTToken;
        //    }
        //    else
        //    {
        //        requestDto.Msg = json.message;
        //        requestDto.Code = "-1";
        //    }
        //    return result;
        //}

        /// <summary>
        /// 获取JWT的后端消息体，redis对应数据
        /// </summary>
        /// <returns></returns>
        //protected JWTTokenEntity GetJWTTokenEntity(ref RequestDto requestDto, ref SortedDictionary<string, string> data)
        //{
        //    JWTTokenEntity result = null;
        //    var json = GetJWT(true);
        //    if (json.success)
        //    {
        //        if (Common.Common.ConvertStringToDateTime(json.TokenData.expired_time) < DateTime.Now)
        //        {
        //            requestDto.Msg = "jwt已过期";
        //            requestDto.Code = "-1";
        //        }
        //        else
        //        {
        //            result = json.TokenData;
        //            data = json.TokenDic;
        //        }
        //    }
        //    else
        //    {
        //        requestDto.Msg = json.message;
        //        requestDto.Code = "-1";
        //    }
        //    return result;
        //}

        /// <summary>
        /// JWT解码，获取用户信息
        /// </summary>
        /// <param name="tokenData">是否获取redis数据</param>
        /// <returns></returns>
        //private JWTDecryptData GetJWT(bool tokenData)
        //{
        //    JWTDecryptData result = new JWTDecryptData();
        //    if (HttpContext.Request.Headers.TryGetValue("Authorization", out JWT))
        //    {
        //        //解密jwt
        //        IJWTokenService ijwt = new JWTokenService();
        //        result = ijwt.DecodeTokenData(JWT, tokenData);
        //    }
        //    else
        //    {
        //        result.message = "无法获取JWT加密字符串";
        //    }

        //    return result;
        //}


    }
}
