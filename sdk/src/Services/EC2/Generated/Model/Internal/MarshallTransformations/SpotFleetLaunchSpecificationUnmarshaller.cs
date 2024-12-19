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
    /// Response Unmarshaller for SpotFleetLaunchSpecification Object
    /// </summary>  
    public class SpotFleetLaunchSpecificationUnmarshaller : IXmlUnmarshaller<SpotFleetLaunchSpecification, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SpotFleetLaunchSpecification Unmarshall(XmlUnmarshallerContext context)
        {
            SpotFleetLaunchSpecification unmarshalledObject = new SpotFleetLaunchSpecification();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("addressingType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AddressingType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        var unmarshaller = BlockDeviceMappingUnmarshaller.Instance;
                        if (unmarshalledObject.BlockDeviceMappings == null)
                        {
                            unmarshalledObject.BlockDeviceMappings = new List<BlockDeviceMapping>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.BlockDeviceMappings.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ebsOptimized", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EbsOptimized = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("iamInstanceProfile", targetDepth))
                    {
                        var unmarshaller = IamInstanceProfileSpecificationUnmarshaller.Instance;
                        unmarshalledObject.IamInstanceProfile = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImageId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceRequirements", targetDepth))
                    {
                        var unmarshaller = InstanceRequirementsUnmarshaller.Instance;
                        unmarshalledObject.InstanceRequirements = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("kernelId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KernelId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("keyName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KeyName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("monitoring", targetDepth))
                    {
                        var unmarshaller = SpotFleetMonitoringUnmarshaller.Instance;
                        unmarshalledObject.Monitoring = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceSet/item", targetDepth))
                    {
                        var unmarshaller = InstanceNetworkInterfaceSpecificationUnmarshaller.Instance;
                        if (unmarshalledObject.NetworkInterfaces == null)
                        {
                            unmarshalledObject.NetworkInterfaces = new List<InstanceNetworkInterfaceSpecification>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NetworkInterfaces.Add(item);
                        continue;
                    }
                    if (context.TestExpression("placement", targetDepth))
                    {
                        var unmarshaller = SpotPlacementUnmarshaller.Instance;
                        unmarshalledObject.Placement = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ramdiskId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RamdiskId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("groupSet/item", targetDepth))
                    {
                        var unmarshaller = GroupIdentifierUnmarshaller.Instance;
                        if (unmarshalledObject.SecurityGroups == null)
                        {
                            unmarshalledObject.SecurityGroups = new List<GroupIdentifier>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SecurityGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("spotPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SpotPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSpecificationSet/item", targetDepth))
                    {
                        var unmarshaller = SpotFleetTagSpecificationUnmarshaller.Instance;
                        if (unmarshalledObject.TagSpecifications == null)
                        {
                            unmarshalledObject.TagSpecifications = new List<SpotFleetTagSpecification>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TagSpecifications.Add(item);
                        continue;
                    }
                    if (context.TestExpression("userData", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UserData = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("weightedCapacity", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.WeightedCapacity = unmarshaller.Unmarshall(context);
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

        private static SpotFleetLaunchSpecificationUnmarshaller _instance = new SpotFleetLaunchSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SpotFleetLaunchSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}