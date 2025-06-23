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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBlockDeviceMappingsListValue in requestObject.BlockDeviceMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = BlockDeviceMappingRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlockDeviceMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCapacityReservationSpecification())
            {
                context.Writer.WritePropertyName("CapacityReservationSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = CapacityReservationSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CapacityReservationSpecification, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCpuOptions())
            {
                context.Writer.WritePropertyName("CpuOptions");
                context.Writer.WriteObjectStart();

                var marshaller = CpuOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.CpuOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreditSpecification())
            {
                context.Writer.WritePropertyName("CreditSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = CreditSpecificationRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.CreditSpecification, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDisableApiStop())
            {
                context.Writer.WritePropertyName("DisableApiStop");
                context.Writer.Write(requestObject.DisableApiStop);
            }

            if(requestObject.IsSetEbsOptimized())
            {
                context.Writer.WritePropertyName("EbsOptimized");
                context.Writer.Write(requestObject.EbsOptimized);
            }

            if(requestObject.IsSetEnablePrimaryIpv6())
            {
                context.Writer.WritePropertyName("EnablePrimaryIpv6");
                context.Writer.Write(requestObject.EnablePrimaryIpv6);
            }

            if(requestObject.IsSetEnclaveOptions())
            {
                context.Writer.WritePropertyName("EnclaveOptions");
                context.Writer.WriteObjectStart();

                var marshaller = EnclaveOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.EnclaveOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHibernationOptions())
            {
                context.Writer.WritePropertyName("HibernationOptions");
                context.Writer.WriteObjectStart();

                var marshaller = HibernationOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.HibernationOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIamInstanceProfile())
            {
                context.Writer.WritePropertyName("IamInstanceProfile");
                context.Writer.WriteObjectStart();

                var marshaller = IamInstanceProfileSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.IamInstanceProfile, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImageId())
            {
                context.Writer.WritePropertyName("ImageId");
                context.Writer.Write(requestObject.ImageId);
            }

            if(requestObject.IsSetInstanceMarketOptions())
            {
                context.Writer.WritePropertyName("InstanceMarketOptions");
                context.Writer.WriteObjectStart();

                var marshaller = InstanceMarketOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceMarketOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetIpv6AddressCount())
            {
                context.Writer.WritePropertyName("Ipv6AddressCount");
                context.Writer.Write(requestObject.Ipv6AddressCount);
            }

            if(requestObject.IsSetIpv6Addresses())
            {
                context.Writer.WritePropertyName("Ipv6Addresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpv6AddressesListValue in requestObject.Ipv6Addresses)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InstanceIpv6AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6AddressesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKernelId())
            {
                context.Writer.WritePropertyName("KernelId");
                context.Writer.Write(requestObject.KernelId);
            }

            if(requestObject.IsSetKeyName())
            {
                context.Writer.WritePropertyName("KeyName");
                context.Writer.Write(requestObject.KeyName);
            }

            if(requestObject.IsSetLicenseSpecifications())
            {
                context.Writer.WritePropertyName("LicenseSpecifications");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLicenseSpecificationsListValue in requestObject.LicenseSpecifications)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = LicenseConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(requestObjectLicenseSpecificationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMaintenanceOptions())
            {
                context.Writer.WritePropertyName("MaintenanceOptions");
                context.Writer.WriteObjectStart();

                var marshaller = InstanceMaintenanceOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MaintenanceOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMetadataOptions())
            {
                context.Writer.WritePropertyName("MetadataOptions");
                context.Writer.WriteObjectStart();

                var marshaller = InstanceMetadataOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MetadataOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMonitoring())
            {
                context.Writer.WritePropertyName("Monitoring");
                context.Writer.WriteObjectStart();

                var marshaller = RunInstancesMonitoringEnabledMarshaller.Instance;
                marshaller.Marshall(requestObject.Monitoring, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNetworkInterfaces())
            {
                context.Writer.WritePropertyName("NetworkInterfaces");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkInterfacesListValue in requestObject.NetworkInterfaces)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InstanceNetworkInterfaceSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkInterfacesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkPerformanceOptions())
            {
                context.Writer.WritePropertyName("NetworkPerformanceOptions");
                context.Writer.WriteObjectStart();

                var marshaller = InstanceNetworkPerformanceOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkPerformanceOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPlacement())
            {
                context.Writer.WritePropertyName("Placement");
                context.Writer.WriteObjectStart();

                var marshaller = PlacementMarshaller.Instance;
                marshaller.Marshall(requestObject.Placement, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrivateDnsNameOptions())
            {
                context.Writer.WritePropertyName("PrivateDnsNameOptions");
                context.Writer.WriteObjectStart();

                var marshaller = PrivateDnsNameOptionsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.PrivateDnsNameOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrivateIpAddress())
            {
                context.Writer.WritePropertyName("PrivateIpAddress");
                context.Writer.Write(requestObject.PrivateIpAddress);
            }

            if(requestObject.IsSetRamdiskId())
            {
                context.Writer.WritePropertyName("RamdiskId");
                context.Writer.Write(requestObject.RamdiskId);
            }

            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("SecurityGroupIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.Write(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.Write(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.Write(requestObject.SubnetId);
            }

            if(requestObject.IsSetTagSpecifications())
            {
                context.Writer.WritePropertyName("TagSpecifications");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagSpecificationsListValue in requestObject.TagSpecifications)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagSpecificationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUserData())
            {
                context.Writer.WritePropertyName("UserData");
                context.Writer.Write(requestObject.UserData);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ManagedInstanceRequestMarshaller Instance = new ManagedInstanceRequestMarshaller();

    }
}