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
    /// Response Unmarshaller for IpPermission Object
    /// </summary>  
    public class IpPermissionUnmarshaller : IXmlUnmarshaller<IpPermission, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public IpPermission Unmarshall(XmlUnmarshallerContext context)
        {
            IpPermission unmarshalledObject = new IpPermission();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
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
                        var unmarshaller = IpRangeUnmarshaller.Instance;
                        if (unmarshalledObject.Ipv4Ranges == null)
                        {
                            unmarshalledObject.Ipv4Ranges = new List<IpRange>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Ipv4Ranges.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ipv6Ranges/item", targetDepth))
                    {
                        var unmarshaller = Ipv6RangeUnmarshaller.Instance;
                        if (unmarshalledObject.Ipv6Ranges == null)
                        {
                            unmarshalledObject.Ipv6Ranges = new List<Ipv6Range>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Ipv6Ranges.Add(item);
                        continue;
                    }
                    if (context.TestExpression("prefixListIds/item", targetDepth))
                    {
                        var unmarshaller = PrefixListIdUnmarshaller.Instance;
                        if (unmarshalledObject.PrefixListIds == null)
                        {
                            unmarshalledObject.PrefixListIds = new List<PrefixListId>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PrefixListIds.Add(item);
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
                        var unmarshaller = UserIdGroupPairUnmarshaller.Instance;
                        if (unmarshalledObject.UserIdGroupPairs == null)
                        {
                            unmarshalledObject.UserIdGroupPairs = new List<UserIdGroupPair>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.UserIdGroupPairs.Add(item);
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
        public static IpPermissionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}