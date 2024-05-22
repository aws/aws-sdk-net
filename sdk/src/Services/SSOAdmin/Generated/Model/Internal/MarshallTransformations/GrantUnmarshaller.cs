/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSOAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SSOAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Grant Object
    /// </summary>  
    public class GrantUnmarshaller : IUnmarshaller<Grant, XmlUnmarshallerContext>, IUnmarshaller<Grant, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Grant IUnmarshaller<Grant, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Grant Unmarshall(JsonUnmarshallerContext context)
        {
            Grant unmarshalledObject = new Grant();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AuthorizationCode", targetDepth))
                {
                    var unmarshaller = AuthorizationCodeGrantUnmarshaller.Instance;
                    unmarshalledObject.AuthorizationCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JwtBearer", targetDepth))
                {
                    var unmarshaller = JwtBearerGrantUnmarshaller.Instance;
                    unmarshalledObject.JwtBearer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RefreshToken", targetDepth))
                {
                    var unmarshaller = RefreshTokenGrantUnmarshaller.Instance;
                    unmarshalledObject.RefreshToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TokenExchange", targetDepth))
                {
                    var unmarshaller = TokenExchangeGrantUnmarshaller.Instance;
                    unmarshalledObject.TokenExchange = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GrantUnmarshaller _instance = new GrantUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GrantUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}