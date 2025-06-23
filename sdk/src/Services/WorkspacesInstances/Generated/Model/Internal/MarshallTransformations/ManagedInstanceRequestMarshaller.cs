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
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ManagedInstanceRequest Marshaller
    /// </summary>
    public class ManagedInstanceRequestMarshaller : IRequestMarshaller<ManagedInstanceRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ManagedInstanceRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlockDeviceMappings())
            {
                context.Writer.WritePropertyName("BlockDeviceMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBlockDeviceMappingsListValue in requestObject.BlockDeviceMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BlockDeviceMappingRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlockDeviceMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCapacityReservationSpecification())
            {
                context.Writer.WritePropertyName("CapacityReservationSpecification");
                context.Writer.WriteStartObject();

                var marshaller = CapacityReservationSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CapacityReservationSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCpuOptions())
            {
                context.Writer.WritePropertyName("CpuOptions");
                context.Writer.WriteStartObject();

                var marshaller = CpuOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.CpuOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreditSpecification())
            {
                context.Writer.WritePropertyName("CreditSpecification");
                context.Writer.WriteStartObject();

                var marshaller = CreditSpecificationRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.CreditSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDisableApiStop())
            {
                context.Writer.WritePropertyName("DisableApiStop");
                context.Writer.WriteBooleanValue(requestObject.DisableApiStop.Value);
            }

            if(requestObject.IsSetEbsOptimized())
            {
                context.Writer.WritePropertyName("EbsOptimized");
                context.Writer.WriteBooleanValue(requestObject.EbsOptimized.Value);
            }

            if(requestObject.IsSetEnablePrimaryIpv6())
            {
                context.Writer.WritePropertyName("EnablePrimaryIpv6");
                context.Writer.WriteBooleanValue(requestObject.EnablePrimaryIpv6.Value);
            }

            if(requestObject.IsSetEnclaveOptions())
            {
                context.Writer.WritePropertyName("EnclaveOptions");
                context.Writer.WriteStartObject();

                var marshaller = EnclaveOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.EnclaveOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHibernationOptions())
            {
                context.Writer.WritePropertyName("HibernationOptions");
                context.Writer.WriteStartObject();

                var marshaller = HibernationOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.HibernationOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIamInstanceProfile())
            {
                context.Writer.WritePropertyName("IamInstanceProfile");
                context.Writer.WriteStartObject();

                var marshaller = IamInstanceProfileSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.IamInstanceProfile, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImageId())
            {
                context.Writer.WritePropertyName("ImageId");
                context.Writer.WriteStringValue(requestObject.ImageId);
            }

            if(requestObject.IsSetInstanceMarketOptions())
            {
                context.Writer.WritePropertyName("InstanceMarketOptions");
                context.Writer.WriteStartObject();

                var marshaller = InstanceMarketOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceMarketOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(requestObject.InstanceType);
            }

            if(requestObject.IsSetIpv6AddressCount())
            {
                context.Writer.WritePropertyName("Ipv6AddressCount");
                context.Writer.WriteNumberValue(requestObject.Ipv6AddressCount.Value);
            }

            if(requestObject.IsSetIpv6Addresses())
            {
                context.Writer.WritePropertyName("Ipv6Addresses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpv6AddressesListValue in requestObject.Ipv6Addresses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceIpv6AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6AddressesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKernelId())
            {
                context.Writer.WritePropertyName("KernelId");
                context.Writer.WriteStringValue(requestObject.KernelId);
            }

            if(requestObject.IsSetKeyName())
            {
                context.Writer.WritePropertyName("KeyName");
                context.Writer.WriteStringValue(requestObject.KeyName);
            }

            if(requestObject.IsSetLicenseSpecifications())
            {
                context.Writer.WritePropertyName("LicenseSpecifications");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLicenseSpecificationsListValue in requestObject.LicenseSpecifications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LicenseConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectLicenseSpecificationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaintenanceOptions())
            {
                context.Writer.WritePropertyName("MaintenanceOptions");
                context.Writer.WriteStartObject();

                var marshaller = InstanceMaintenanceOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MaintenanceOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMetadataOptions())
            {
                context.Writer.WritePropertyName("MetadataOptions");
                context.Writer.WriteStartObject();

                var marshaller = InstanceMetadataOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MetadataOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMonitoring())
            {
                context.Writer.WritePropertyName("Monitoring");
                context.Writer.WriteStartObject();

                var marshaller = RunInstancesMonitoringEnabledMarshaller.Instance;
                marshaller.Marshall(requestObject.Monitoring, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkInterfaces())
            {
                context.Writer.WritePropertyName("NetworkInterfaces");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkInterfacesListValue in requestObject.NetworkInterfaces)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceNetworkInterfaceSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkInterfacesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkPerformanceOptions())
            {
                context.Writer.WritePropertyName("NetworkPerformanceOptions");
                context.Writer.WriteStartObject();

                var marshaller = InstanceNetworkPerformanceOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkPerformanceOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPlacement())
            {
                context.Writer.WritePropertyName("Placement");
                context.Writer.WriteStartObject();

                var marshaller = PlacementMarshaller.Instance;
                marshaller.Marshall(requestObject.Placement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrivateDnsNameOptions())
            {
                context.Writer.WritePropertyName("PrivateDnsNameOptions");
                context.Writer.WriteStartObject();

                var marshaller = PrivateDnsNameOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.PrivateDnsNameOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrivateIpAddress())
            {
                context.Writer.WritePropertyName("PrivateIpAddress");
                context.Writer.WriteStringValue(requestObject.PrivateIpAddress);
            }

            if(requestObject.IsSetRamdiskId())
            {
                context.Writer.WritePropertyName("RamdiskId");
                context.Writer.WriteStringValue(requestObject.RamdiskId);
            }

            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("SecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.WriteStringValue(requestObject.SubnetId);
            }

            if(requestObject.IsSetTagSpecifications())
            {
                context.Writer.WritePropertyName("TagSpecifications");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagSpecificationsListValue in requestObject.TagSpecifications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagSpecificationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUserData())
            {
                context.Writer.WritePropertyName("UserData");
                context.Writer.WriteStringValue(requestObject.UserData);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ManagedInstanceRequestMarshaller Instance = new ManagedInstanceRequestMarshaller();

    }
}