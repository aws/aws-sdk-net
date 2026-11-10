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
    /// Response Unmarshaller for IpPermission Object
    /// </summary>
    public partial class IpPermissionUnmarshaller : IXmlUnmarshaller<IpPermission, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public IpPermission Unmarshall(XmlUnmarshallerContext context)
        {
            IpPermission unmarshalledObject = new IpPermission();
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
                    if (context.TestExpression("fromPort", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.FromPort = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipProtocol", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpProtocol = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ipRanges/item", targetDepth))
                    {
                        if (unmarshalledObject.Ipv4Ranges == null)
                        {
                            unmarshalledObject.Ipv4Ranges = new List<IpRange>();
                        }
                        var unmarshaller = IpRangeUnmarshaller.Instance;
                        unmarshalledObject.Ipv4Ranges.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ipv6Ranges/item", targetDepth))
                    {
                        if (unmarshalledObject.Ipv6Ranges == null)
                        {
                            unmarshalledObject.Ipv6Ranges = new List<Ipv6Range>();
                        }
                        var unmarshaller = Ipv6RangeUnmarshaller.Instance;
                        unmarshalledObject.Ipv6Ranges.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("prefixListIds/item", targetDepth))
                    {
                        if (unmarshalledObject.PrefixListIds == null)
                        {
                            unmarshalledObject.PrefixListIds = new List<PrefixListId>();
                        }
                        var unmarshaller = PrefixListIdUnmarshaller.Instance;
                        unmarshalledObject.PrefixListIds.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("toPort", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.ToPort = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("groups/item", targetDepth))
                    {
                        if (unmarshalledObject.UserIdGroupPairs == null)
                        {
                            unmarshalledObject.UserIdGroupPairs = new List<UserIdGroupPair>();
                        }
                        var unmarshaller = UserIdGroupPairUnmarshaller.Instance;
                        unmarshalledObject.UserIdGroupPairs.Add(unmarshaller.Unmarshall(context));
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

        private static IpPermissionUnmarshaller _instance = new IpPermissionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static IpPermissionUnmarshaller Instance => _instance;
    }
}
