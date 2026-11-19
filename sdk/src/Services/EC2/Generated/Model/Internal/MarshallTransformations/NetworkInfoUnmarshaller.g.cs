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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkInfo Object
    /// </summary>
    public partial class NetworkInfoUnmarshaller : IXmlUnmarshaller<NetworkInfo, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public NetworkInfo Unmarshall(XmlUnmarshallerContext context)
        {
            NetworkInfo unmarshalledObject = new NetworkInfo();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("bandwidthWeightings/item", targetDepth))
                    {
                        if (unmarshalledObject.BandwidthWeightings == null)
                        {
                            unmarshalledObject.BandwidthWeightings = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BandwidthWeightings.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("connectionTrackingConfiguration", targetDepth))
                    {
                        var unmarshaller = DefaultConnectionTrackingConfigurationUnmarshaller.Instance;
                        unmarshalledObject.ConnectionTrackingConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }

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

                    if (context.TestExpression("flexibleEnaQueuesSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FlexibleEnaQueuesSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipv4AddressesPerInterface", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Ipv4AddressesPerInterface = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipv4AddressesPerSecondaryInterface", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Ipv4AddressesPerSecondaryInterface = unmarshaller.Unmarshall(context);
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

                    if (context.TestExpression("maximumSecondaryNetworkInterfaces", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaximumSecondaryNetworkInterfaces = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("networkCards/item", targetDepth))
                    {
                        if (unmarshalledObject.NetworkCards == null)
                        {
                            unmarshalledObject.NetworkCards = new List<NetworkCardInfo>();
                        }
                        var unmarshaller = NetworkCardInfoUnmarshaller.Instance;
                        unmarshalledObject.NetworkCards.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("networkPerformance", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkPerformance = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("secondaryNetworkSupported", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SecondaryNetworkSupported = unmarshaller.Unmarshall(context);
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
        public static NetworkInfoUnmarshaller Instance => _instance;
    }
}
