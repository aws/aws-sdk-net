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
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MutualAuthenticationAttributes Object
    /// </summary>  
    public class MutualAuthenticationAttributesUnmarshaller : IUnmarshaller<MutualAuthenticationAttributes, XmlUnmarshallerContext>, IUnmarshaller<MutualAuthenticationAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MutualAuthenticationAttributes Unmarshall(XmlUnmarshallerContext context)
        {
            MutualAuthenticationAttributes unmarshalledObject = new MutualAuthenticationAttributes();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AdvertiseTrustStoreCaNames", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AdvertiseTrustStoreCaNames = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IgnoreClientCertificateExpiry", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.IgnoreClientCertificateExpiry = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Mode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Mode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TrustStoreArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrustStoreArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TrustStoreAssociationStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrustStoreAssociationStatus = unmarshaller.Unmarshall(context);
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
        public MutualAuthenticationAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static MutualAuthenticationAttributesUnmarshaller _instance = new MutualAuthenticationAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MutualAuthenticationAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}