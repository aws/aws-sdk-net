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
    /// Response Unmarshaller for NetworkInfo Object
    /// </summary>  
    public class NetworkInfoUnmarshaller : IXmlUnmarshaller<NetworkInfo, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkInfo Unmarshall(XmlUnmarshallerContext context)
        {
            NetworkInfo unmarshalledObject = new NetworkInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("defaultNetworkCardIndex", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DefaultNetworkCardIndex = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("efaInfo", targetDepth))
                    {
                        var unmarshaller = EfaInfoUnmarshaller.Instance;
                        unmarshalledObject.EfaInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("efaSupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EfaSupported = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enaSrdSupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EnaSrdSupported = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enaSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EnaSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("encryptionInTransitSupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EncryptionInTransitSupported = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipv4AddressesPerInterface", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Ipv4AddressesPerInterface = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipv6AddressesPerInterface", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Ipv6AddressesPerInterface = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipv6Supported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Ipv6Supported = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maximumNetworkCards", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaximumNetworkCards = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maximumNetworkInterfaces", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaximumNetworkInterfaces = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkCards/item", targetDepth))
                    {
                        var unmarshaller = NetworkCardInfoUnmarshaller.Instance;
                        if (unmarshalledObject.NetworkCards == null)
                        {
                            unmarshalledObject.NetworkCards = new List<NetworkCardInfo>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NetworkCards.Add(item);
                        continue;
                    }
                    if (context.TestExpression("networkPerformance", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkPerformance = unmarshaller.Unmarshall(context);
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

        private static NetworkInfoUnmarshaller _instance = new NetworkInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}