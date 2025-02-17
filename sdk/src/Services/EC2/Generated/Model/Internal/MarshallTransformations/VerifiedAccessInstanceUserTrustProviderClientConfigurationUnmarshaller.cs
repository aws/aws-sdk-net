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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VerifiedAccessInstanceUserTrustProviderClientConfiguration Object
    /// </summary>  
    public class VerifiedAccessInstanceUserTrustProviderClientConfigurationUnmarshaller : IUnmarshaller<VerifiedAccessInstanceUserTrustProviderClientConfiguration, XmlUnmarshallerContext>, IUnmarshaller<VerifiedAccessInstanceUserTrustProviderClientConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VerifiedAccessInstanceUserTrustProviderClientConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            VerifiedAccessInstanceUserTrustProviderClientConfiguration unmarshalledObject = new VerifiedAccessInstanceUserTrustProviderClientConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("authorizationEndpoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AuthorizationEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("clientId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("clientSecret", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientSecret = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("issuer", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Issuer = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("pkceEnabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.PkceEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("publicSigningKeyEndpoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublicSigningKeyEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("scopes", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Scopes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tokenEndpoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TokenEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("userInfoEndpoint", targetDepth))
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
        public VerifiedAccessInstanceUserTrustProviderClientConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static VerifiedAccessInstanceUserTrustProviderClientConfigurationUnmarshaller _instance = new VerifiedAccessInstanceUserTrustProviderClientConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VerifiedAccessInstanceUserTrustProviderClientConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}