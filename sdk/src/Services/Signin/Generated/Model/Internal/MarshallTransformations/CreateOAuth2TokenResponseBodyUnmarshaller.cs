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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Signin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Signin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateOAuth2TokenResponseBody Object
    /// </summary>  
    public class CreateOAuth2TokenResponseBodyUnmarshaller : IUnmarshaller<CreateOAuth2TokenResponseBody, XmlUnmarshallerContext>, IUnmarshaller<CreateOAuth2TokenResponseBody, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CreateOAuth2TokenResponseBody IUnmarshaller<CreateOAuth2TokenResponseBody, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CreateOAuth2TokenResponseBody Unmarshall(JsonUnmarshallerContext context)
        {
            CreateOAuth2TokenResponseBody unmarshalledObject = new CreateOAuth2TokenResponseBody();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accessToken", targetDepth))
                {
                    var unmarshaller = AccessTokenUnmarshaller.Instance;
                    unmarshalledObject.AccessToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("expiresIn", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ExpiresIn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("idToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IdToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("refreshToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RefreshToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tokenType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TokenType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CreateOAuth2TokenResponseBodyUnmarshaller _instance = new CreateOAuth2TokenResponseBodyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOAuth2TokenResponseBodyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}