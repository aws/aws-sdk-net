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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OAuth2Defaults Object
    /// </summary>  
    public class OAuth2DefaultsUnmarshaller : IUnmarshaller<OAuth2Defaults, XmlUnmarshallerContext>, IUnmarshaller<OAuth2Defaults, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OAuth2Defaults IUnmarshaller<OAuth2Defaults, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OAuth2Defaults Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OAuth2Defaults unmarshalledObject = new OAuth2Defaults();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("authCodeUrls", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AuthCodeUrls = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("oauth2CustomProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OAuth2CustomParameter, OAuth2CustomParameterUnmarshaller>(OAuth2CustomParameterUnmarshaller.Instance);
                    unmarshalledObject.Oauth2CustomProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("oauth2GrantTypesSupported", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Oauth2GrantTypesSupported = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("oauthScopes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.OauthScopes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tokenUrls", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TokenUrls = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OAuth2DefaultsUnmarshaller _instance = new OAuth2DefaultsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OAuth2DefaultsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}