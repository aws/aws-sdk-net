/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AuthenticationResultType Object
    /// </summary>  
    public class AuthenticationResultTypeUnmarshaller : IUnmarshaller<AuthenticationResultType, XmlUnmarshallerContext>, IUnmarshaller<AuthenticationResultType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AuthenticationResultType IUnmarshaller<AuthenticationResultType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AuthenticationResultType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AuthenticationResultType unmarshalledObject = new AuthenticationResultType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpiresIn", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ExpiresIn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IdToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NewDeviceMetadata", targetDepth))
                {
                    var unmarshaller = NewDeviceMetadataTypeUnmarshaller.Instance;
                    unmarshalledObject.NewDeviceMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RefreshToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RefreshToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TokenType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TokenType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AuthenticationResultTypeUnmarshaller _instance = new AuthenticationResultTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthenticationResultTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}