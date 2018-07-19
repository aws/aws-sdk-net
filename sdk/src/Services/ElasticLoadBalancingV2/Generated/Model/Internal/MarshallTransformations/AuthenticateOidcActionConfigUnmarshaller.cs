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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AuthenticateOidcActionConfig Object
    /// </summary>  
    public class AuthenticateOidcActionConfigUnmarshaller : IUnmarshaller<AuthenticateOidcActionConfig, XmlUnmarshallerContext>, IUnmarshaller<AuthenticateOidcActionConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AuthenticateOidcActionConfig Unmarshall(XmlUnmarshallerContext context)
        {
            AuthenticateOidcActionConfig unmarshalledObject = new AuthenticateOidcActionConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AuthenticationRequestExtraParams/entry", targetDepth))
                    {
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AuthenticationRequestExtraParams.Add(item);
                        continue;
                    }
                    if (context.TestExpression("AuthorizationEndpoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AuthorizationEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClientId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClientSecret", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientSecret = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Issuer", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Issuer = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OnUnauthenticatedRequest", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OnUnauthenticatedRequest = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Scope", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Scope = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SessionCookieName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SessionCookieName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SessionTimeout", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        unmarshalledObject.SessionTimeout = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TokenEndpoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TokenEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UserInfoEndpoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UserInfoEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AuthenticateOidcActionConfig Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static AuthenticateOidcActionConfigUnmarshaller _instance = new AuthenticateOidcActionConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthenticateOidcActionConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}