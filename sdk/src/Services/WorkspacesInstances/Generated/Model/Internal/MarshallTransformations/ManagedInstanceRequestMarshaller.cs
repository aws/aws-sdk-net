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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkspacesInstances.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ManagedInstanceRequest Marshaller
    /// </summary>
    public class ManagedInstanceRequestMarshaller : IRequestMarshaller<ManagedInstanceRequest, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ManagedInstanceRequest requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetBlockDeviceMappings())
            {
                context.Writer.WriteTextString("BlockDeviceMappings");
                context.Writer.WriteStartArray(requestObject.BlockDeviceMappings.Count);
                foreach(var requestObjectBlockDeviceMappingsListValue in requestObject.BlockDeviceMappings)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = BlockDeviceMappingRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlockDeviceMappingsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetCapacityReservationSpecification())
            {
                context.Writer.WriteTextString("CapacityReservationSpecification");
                context.Writer.WriteStartMap(null);

                var marshaller = CapacityReservationSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CapacityReservationSpecification, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetCpuOptions())
            {
                context.Writer.WriteTextString("CpuOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = CpuOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.CpuOptions, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetCreditSpecification())
            {
                context.Writer.WriteTextString("CreditSpecification");
                context.Writer.WriteStartMap(null);

                var marshaller = CreditSpecificationRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.CreditSpecification, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDisableApiStop())
            {
                context.Writer.WriteTextString("DisableApiStop");
                context.Writer.WriteBoolean(requestObject.DisableApiStop.Value);
            }
            if (requestObject.IsSetEbsOptimized())
            {
                context.Writer.WriteTextString("EbsOptimized");
                context.Writer.WriteBoolean(requestObject.EbsOptimized.Value);
            }
            if (requestObject.IsSetEnablePrimaryIpv6())
            {
                context.Writer.WriteTextString("EnablePrimaryIpv6");
                context.Writer.WriteBoolean(requestObject.EnablePrimaryIpv6.Value);
            }
            if (requestObject.IsSetEnclaveOptions())
            {
                context.Writer.WriteTextString("EnclaveOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = EnclaveOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.EnclaveOptions, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetHibernationOptions())
            {
                context.Writer.WriteTextString("HibernationOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = HibernationOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.HibernationOptions, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetIamInstanceProfile())
            {
                context.Writer.WriteTextString("IamInstanceProfile");
                context.Writer.WriteStartMap(null);

                var marshaller = IamInstanceProfileSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.IamInstanceProfile, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetImageId())
            {
                context.Writer.WriteTextString("ImageId");
                context.Writer.WriteTextString(requestObject.ImageId);
            }
            if (requestObject.IsSetInstanceMarketOptions())
            {
                context.Writer.WriteTextString("InstanceMarketOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = InstanceMarketOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceMarketOptions, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetInstanceType())
            {
                context.Writer.WriteTextString("InstanceType");
                context.Writer.WriteTextString(requestObject.InstanceType);
            }
            if (requestObject.IsSetIpv6AddressCount())
            {
                context.Writer.WriteTextString("Ipv6AddressCount");
                context.Writer.WriteInt32(requestObject.Ipv6AddressCount.Value);
            }
            if (requestObject.IsSetIpv6Addresses())
            {
                context.Writer.WriteTextString("Ipv6Addresses");
                context.Writer.WriteStartArray(requestObject.Ipv6Addresses.Count);
                foreach(var requestObjectIpv6AddressesListValue in requestObject.Ipv6Addresses)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = InstanceIpv6AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6AddressesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetKernelId())
            {
                context.Writer.WriteTextString("KernelId");
                context.Writer.WriteTextString(requestObject.KernelId);
            }
            if (requestObject.IsSetKeyName())
            {
                context.Writer.WriteTextString("KeyName");
                context.Writer.WriteTextString(requestObject.KeyName);
            }
            if (requestObject.IsSetLicenseSpecifications())
            {
                context.Writer.WriteTextString("LicenseSpecifications");
                context.Writer.WriteStartArray(requestObject.LicenseSpecifications.Count);
                foreach(var requestObjectLicenseSpecificationsListValue in requestObject.LicenseSpecifications)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = LicenseConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectLicenseSpecificationsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetMaintenanceOptions())
            {
                context.Writer.WriteTextString("MaintenanceOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = InstanceMaintenanceOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MaintenanceOptions, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetMetadataOptions())
            {
                context.Writer.WriteTextString("MetadataOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = InstanceMetadataOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MetadataOptions, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetMonitoring())
            {
                context.Writer.WriteTextString("Monitoring");
                context.Writer.WriteStartMap(null);

                var marshaller = RunInstancesMonitoringEnabledMarshaller.Instance;
                marshaller.Marshall(requestObject.Monitoring, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetNetworkInterfaces())
            {
                context.Writer.WriteTextString("NetworkInterfaces");
                context.Writer.WriteStartArray(requestObject.NetworkInterfaces.Count);
                foreach(var requestObjectNetworkInterfacesListValue in requestObject.NetworkInterfaces)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = InstanceNetworkInterfaceSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkInterfacesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetNetworkPerformanceOptions())
            {
                context.Writer.WriteTextString("NetworkPerformanceOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = InstanceNetworkPerformanceOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkPerformanceOptions, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetPlacement())
            {
                context.Writer.WriteTextString("Placement");
                context.Writer.WriteStartMap(null);

                var marshaller = PlacementMarshaller.Instance;
                marshaller.Marshall(requestObject.Placement, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetPrivateDnsNameOptions())
            {
                context.Writer.WriteTextString("PrivateDnsNameOptions");
                context.Writer.WriteStartMap(null);

                var marshaller = PrivateDnsNameOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.PrivateDnsNameOptions, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetPrivateIpAddress())
            {
                context.Writer.WriteTextString("PrivateIpAddress");
                context.Writer.WriteTextString(requestObject.PrivateIpAddress);
            }
            if (requestObject.IsSetRamdiskId())
            {
                context.Writer.WriteTextString("RamdiskId");
                context.Writer.WriteTextString(requestObject.RamdiskId);
            }
            if (requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WriteTextString("SecurityGroupIds");
                context.Writer.WriteStartArray(requestObject.SecurityGroupIds.Count);
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.WriteTextString(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSecurityGroups())
            {
                context.Writer.WriteTextString("SecurityGroups");
                context.Writer.WriteStartArray(requestObject.SecurityGroups.Count);
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.WriteTextString(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSubnetId())
            {
                context.Writer.WriteTextString("SubnetId");
                context.Writer.WriteTextString(requestObject.SubnetId);
            }
            if (requestObject.IsSetTagSpecifications())
            {
                context.Writer.WriteTextString("TagSpecifications");
                context.Writer.WriteStartArray(requestObject.TagSpecifications.Count);
                foreach(var requestObjectTagSpecificationsListValue in requestObject.TagSpecifications)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = TagSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagSpecificationsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetUserData())
            {
                context.Writer.WriteTextString("UserData");
                context.Writer.WriteTextString(requestObject.UserData);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ManagedInstanceRequestMarshaller Instance = new ManagedInstanceRequestMarshaller();

    }
}