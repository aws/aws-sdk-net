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
    /// Response Unmarshaller for VerifiedAccessTrustProvider Object
    /// </summary>  
    public class VerifiedAccessTrustProviderUnmarshaller : IUnmarshaller<VerifiedAccessTrustProvider, XmlUnmarshallerContext>, IUnmarshaller<VerifiedAccessTrustProvider, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VerifiedAccessTrustProvider Unmarshall(XmlUnmarshallerContext context)
        {
            VerifiedAccessTrustProvider unmarshalledObject = new VerifiedAccessTrustProvider();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("creationTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deviceOptions", targetDepth))
                    {
                        var unmarshaller = DeviceOptionsUnmarshaller.Instance;
                        unmarshalledObject.DeviceOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deviceTrustProviderType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeviceTrustProviderType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastUpdatedTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("oidcOptions", targetDepth))
                    {
                        var unmarshaller = OidcOptionsUnmarshaller.Instance;
                        unmarshalledObject.OidcOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("policyReferenceName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PolicyReferenceName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sseSpecification", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessSseSpecificationResponseUnmarshaller.Instance;
                        unmarshalledObject.SseSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("trustProviderType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrustProviderType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("userTrustProviderType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UserTrustProviderType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("verifiedAccessTrustProviderId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VerifiedAccessTrustProviderId = unmarshaller.Unmarshall(context);
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
        public VerifiedAccessTrustProvider Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static VerifiedAccessTrustProviderUnmarshaller _instance = new VerifiedAccessTrustProviderUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VerifiedAccessTrustProviderUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}