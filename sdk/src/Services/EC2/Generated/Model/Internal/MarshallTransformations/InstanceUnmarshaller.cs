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
    /// Response Unmarshaller for Instance Object
    /// </summary>  
    public class InstanceUnmarshaller : IXmlUnmarshaller<Instance, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Instance Unmarshall(XmlUnmarshallerContext context)
        {
            Instance unmarshalledObject = new Instance();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("amiLaunchIndex", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AmiLaunchIndex = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("architecture", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Architecture = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("blockDeviceMapping/item", targetDepth))
                    {
                        var unmarshaller = InstanceBlockDeviceMappingUnmarshaller.Instance;
                        if (unmarshalledObject.BlockDeviceMappings == null)
                        {
                            unmarshalledObject.BlockDeviceMappings = new List<InstanceBlockDeviceMapping>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.BlockDeviceMappings.Add(item);
                        continue;
                    }
                    if (context.TestExpression("bootMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BootMode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityReservationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CapacityReservationId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityReservationSpecification", targetDepth))
                    {
                        var unmarshaller = CapacityReservationSpecificationResponseUnmarshaller.Instance;
                        unmarshalledObject.CapacityReservationSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("clientToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("cpuOptions", targetDepth))
                    {
                        var unmarshaller = CpuOptionsUnmarshaller.Instance;
                        unmarshalledObject.CpuOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("currentInstanceBootMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CurrentInstanceBootMode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ebsOptimized", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EbsOptimized = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("elasticGpuAssociationSet/item", targetDepth))
                    {
                        var unmarshaller = ElasticGpuAssociationUnmarshaller.Instance;
                        if (unmarshalledObject.ElasticGpuAssociations == null)
                        {
                            unmarshalledObject.ElasticGpuAssociations = new List<ElasticGpuAssociation>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ElasticGpuAssociations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("elasticInferenceAcceleratorAssociationSet/item", targetDepth))
                    {
                        var unmarshaller = ElasticInferenceAcceleratorAssociationUnmarshaller.Instance;
                        if (unmarshalledObject.ElasticInferenceAcceleratorAssociations == null)
                        {
                            unmarshalledObject.ElasticInferenceAcceleratorAssociations = new List<ElasticInferenceAcceleratorAssociation>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ElasticInferenceAcceleratorAssociations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("enaSupport", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EnaSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enclaveOptions", targetDepth))
                    {
                        var unmarshaller = EnclaveOptionsUnmarshaller.Instance;
                        unmarshalledObject.EnclaveOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("hibernationOptions", targetDepth))
                    {
                        var unmarshaller = HibernationOptionsUnmarshaller.Instance;
                        unmarshalledObject.HibernationOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("hypervisor", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Hypervisor = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("iamInstanceProfile", targetDepth))
                    {
                        var unmarshaller = IamInstanceProfileUnmarshaller.Instance;
                        unmarshalledObject.IamInstanceProfile = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImageId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceLifecycle", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceLifecycle = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipv6Address", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Ipv6Address = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("launchTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LaunchTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("licenseSet/item", targetDepth))
                    {
                        var unmarshaller = LicenseConfigurationUnmarshaller.Instance;
                        if (unmarshalledObject.Licenses == null)
                        {
                            unmarshalledObject.Licenses = new List<LicenseConfiguration>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Licenses.Add(item);
                        continue;
                    }
                    if (context.TestExpression("maintenanceOptions", targetDepth))
                    {
                        var unmarshaller = InstanceMaintenanceOptionsUnmarshaller.Instance;
                        unmarshalledObject.MaintenanceOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("metadataOptions", targetDepth))
                    {
                        var unmarshaller = InstanceMetadataOptionsResponseUnmarshaller.Instance;
                        unmarshalledObject.MetadataOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("monitoring", targetDepth))
                    {
                        var unmarshaller = MonitoringUnmarshaller.Instance;
                        unmarshalledObject.Monitoring = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInterfaceSet/item", targetDepth))
                    {
                        var unmarshaller = InstanceNetworkInterfaceUnmarshaller.Instance;
                        if (unmarshalledObject.NetworkInterfaces == null)
                        {
                            unmarshalledObject.NetworkInterfaces = new List<InstanceNetworkInterface>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NetworkInterfaces.Add(item);
                        continue;
                    }
                    if (context.TestExpression("outpostArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OutpostArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("placement", targetDepth))
                    {
                        var unmarshaller = PlacementUnmarshaller.Instance;
                        unmarshalledObject.Placement = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("platform", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("platformDetails", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PlatformDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateDnsName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateDnsNameOptions", targetDepth))
                    {
                        var unmarshaller = PrivateDnsNameOptionsResponseUnmarshaller.Instance;
                        unmarshalledObject.PrivateDnsNameOptions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("privateIpAddress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PrivateIpAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("productCodes/item", targetDepth))
                    {
                        var unmarshaller = ProductCodeUnmarshaller.Instance;
                        if (unmarshalledObject.ProductCodes == null)
                        {
                            unmarshalledObject.ProductCodes = new List<ProductCode>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ProductCodes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("dnsName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublicDnsName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipAddress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublicIpAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ramdiskId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RamdiskId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("rootDeviceName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RootDeviceName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("rootDeviceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RootDeviceType = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("sourceDestCheck", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SourceDestCheck = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("spotInstanceRequestId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SpotInstanceRequestId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sriovNetSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SriovNetSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceState", targetDepth))
                    {
                        var unmarshaller = InstanceStateUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("stateReason", targetDepth))
                    {
                        var unmarshaller = StateReasonUnmarshaller.Instance;
                        unmarshalledObject.StateReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("reason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StateTransitionReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("tpmSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TpmSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("usageOperation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UsageOperation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("usageOperationUpdateTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.UsageOperationUpdateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("virtualizationType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VirtualizationType = unmarshaller.Unmarshall(context);
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

        private static InstanceUnmarshaller _instance = new InstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}