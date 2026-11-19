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
    /// Response Unmarshaller for SpotFleetLaunchSpecification Object
    /// </summary>
    public partial class SpotFleetLaunchSpecificationUnmarshaller : IXmlUnmarshaller<SpotFleetLaunchSpecification, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public SpotFleetLaunchSpecification Unmarshall(XmlUnmarshallerContext context)
        {
            SpotFleetLaunchSpecification unmarshalledObject = new SpotFleetLaunchSpecification();
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
                    if (context.TestExpression("addressingType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AddressingType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        if (unmarshalledObject.BlockDeviceMappings == null)
                        {
                            unmarshalledObject.BlockDeviceMappings = new List<BlockDeviceMapping>();
                        }
                        var unmarshaller = BlockDeviceMappingUnmarshaller.Instance;
                        unmarshalledObject.BlockDeviceMappings.Add(unmarshaller.Unmarshall(context));
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
                        if (unmarshalledObject.NetworkInterfaces == null)
                        {
                            unmarshalledObject.NetworkInterfaces = new List<InstanceNetworkInterfaceSpecification>();
                        }
                        var unmarshaller = InstanceNetworkInterfaceSpecificationUnmarshaller.Instance;
                        unmarshalledObject.NetworkInterfaces.Add(unmarshaller.Unmarshall(context));
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
                        if (unmarshalledObject.SecurityGroups == null)
                        {
                            unmarshalledObject.SecurityGroups = new List<GroupIdentifier>();
                        }
                        var unmarshaller = GroupIdentifierUnmarshaller.Instance;
                        unmarshalledObject.SecurityGroups.Add(unmarshaller.Unmarshall(context));
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
                        if (unmarshalledObject.TagSpecifications == null)
                        {
                            unmarshalledObject.TagSpecifications = new List<SpotFleetTagSpecification>();
                        }
                        var unmarshaller = SpotFleetTagSpecificationUnmarshaller.Instance;
                        unmarshalledObject.TagSpecifications.Add(unmarshaller.Unmarshall(context));
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
        public static SpotFleetLaunchSpecificationUnmarshaller Instance => _instance;
    }
}
