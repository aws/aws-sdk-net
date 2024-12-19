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
    /// Response Unmarshaller for IpamDiscoveredResourceCidr Object
    /// </summary>  
    public class IpamDiscoveredResourceCidrUnmarshaller : IXmlUnmarshaller<IpamDiscoveredResourceCidr, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public IpamDiscoveredResourceCidr Unmarshall(XmlUnmarshallerContext context)
        {
            IpamDiscoveredResourceCidr unmarshalledObject = new IpamDiscoveredResourceCidr();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("availabilityZoneId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZoneId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipamResourceDiscoveryId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamResourceDiscoveryId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipSource", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpSource = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipUsage", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.IpUsage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceAttachmentStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaceAttachmentStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceCidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceCidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceOwnerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceOwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceTagSet/item", targetDepth))
                    {
                        var unmarshaller = IpamResourceTagUnmarshaller.Instance;
                        if (unmarshalledObject.ResourceTags == null)
                        {
                            unmarshalledObject.ResourceTags = new List<IpamResourceTag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ResourceTags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("resourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sampleTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.SampleTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
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

        private static IpamDiscoveredResourceCidrUnmarshaller _instance = new IpamDiscoveredResourceCidrUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IpamDiscoveredResourceCidrUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}