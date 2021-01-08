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
    /// Response Unmarshaller for UserPoolClientType Object
    /// </summary>  
    public class UserPoolClientTypeUnmarshaller : IUnmarshaller<UserPoolClientType, XmlUnmarshallerContext>, IUnmarshaller<UserPoolClientType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UserPoolClientType IUnmarshaller<UserPoolClientType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public UserPoolClientType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            UserPoolClientType unmarshalledObject = new UserPoolClientType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessTokenValidity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AccessTokenValidity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AllowedOAuthFlows", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedOAuthFlows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AllowedOAuthFlowsUserPoolClient", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AllowedOAuthFlowsUserPoolClient = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AllowedOAuthScopes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AllowedOAuthScopes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AnalyticsConfiguration", targetDepth))
                {
                    var unmarshaller = AnalyticsConfigurationTypeUnmarshaller.Instance;
                    unmarshalledObject.AnalyticsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CallbackURLs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CallbackURLs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClientId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClientName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClientSecret", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientSecret = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultRedirectURI", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultRedirectURI = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExplicitAuthFlows", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExplicitAuthFlows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdTokenValidity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.IdTokenValidity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogoutURLs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LogoutURLs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreventUserExistenceErrors", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreventUserExistenceErrors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReadAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RefreshTokenValidity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RefreshTokenValidity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportedIdentityProviders", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedIdentityProviders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TokenValidityUnits", targetDepth))
                {
                    var unmarshaller = TokenValidityUnitsTypeUnmarshaller.Instance;
                    unmarshalledObject.TokenValidityUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserPoolId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserPoolId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WriteAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.WriteAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UserPoolClientTypeUnmarshaller _instance = new UserPoolClientTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserPoolClientTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}