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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2LaunchTemplateDataDetails Marshaller
    /// </summary>
    public class AwsEc2LaunchTemplateDataDetailsMarshaller : IRequestMarshaller<AwsEc2LaunchTemplateDataDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2LaunchTemplateDataDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlockDeviceMappingSet())
            {
                context.Writer.WritePropertyName("BlockDeviceMappingSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBlockDeviceMappingSetListValue in requestObject.BlockDeviceMappingSet)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2LaunchTemplateDataBlockDeviceMappingSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlockDeviceMappingSetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCapacityReservationSpecification())
            {
                context.Writer.WritePropertyName("CapacityReservationSpecification");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CapacityReservationSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCpuOptions())
            {
                context.Writer.WritePropertyName("CpuOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataCpuOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CpuOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreditSpecification())
            {
                context.Writer.WritePropertyName("CreditSpecification");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataCreditSpecificationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CreditSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDisableApiStop())
            {
                context.Writer.WritePropertyName("DisableApiStop");
                context.Writer.WriteBooleanValue(requestObject.DisableApiStop.Value);
            }

            if(requestObject.IsSetDisableApiTermination())
            {
                context.Writer.WritePropertyName("DisableApiTermination");
                context.Writer.WriteBooleanValue(requestObject.DisableApiTermination.Value);
            }

            if(requestObject.IsSetEbsOptimized())
            {
                context.Writer.WritePropertyName("EbsOptimized");
                context.Writer.WriteBooleanValue(requestObject.EbsOptimized.Value);
            }

            if(requestObject.IsSetElasticGpuSpecificationSet())
            {
                context.Writer.WritePropertyName("ElasticGpuSpecificationSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectElasticGpuSpecificationSetListValue in requestObject.ElasticGpuSpecificationSet)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2LaunchTemplateDataElasticGpuSpecificationSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectElasticGpuSpecificationSetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetElasticInferenceAcceleratorSet())
            {
                context.Writer.WritePropertyName("ElasticInferenceAcceleratorSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectElasticInferenceAcceleratorSetListValue in requestObject.ElasticInferenceAcceleratorSet)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2LaunchTemplateDataElasticInferenceAcceleratorSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectElasticInferenceAcceleratorSetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnclaveOptions())
            {
                context.Writer.WritePropertyName("EnclaveOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataEnclaveOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.EnclaveOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHibernationOptions())
            {
                context.Writer.WritePropertyName("HibernationOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataHibernationOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.HibernationOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIamInstanceProfile())
            {
                context.Writer.WritePropertyName("IamInstanceProfile");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataIamInstanceProfileDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.IamInstanceProfile, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImageId())
            {
                context.Writer.WritePropertyName("ImageId");
                context.Writer.WriteStringValue(requestObject.ImageId);
            }

            if(requestObject.IsSetInstanceInitiatedShutdownBehavior())
            {
                context.Writer.WritePropertyName("InstanceInitiatedShutdownBehavior");
                context.Writer.WriteStringValue(requestObject.InstanceInitiatedShutdownBehavior);
            }

            if(requestObject.IsSetInstanceMarketOptions())
            {
                context.Writer.WritePropertyName("InstanceMarketOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceMarketOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceMarketOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInstanceRequirements())
            {
                context.Writer.WritePropertyName("InstanceRequirements");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceRequirements, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(requestObject.InstanceType);
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

            if(requestObject.IsSetLicenseSet())
            {
                context.Writer.WritePropertyName("LicenseSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLicenseSetListValue in requestObject.LicenseSet)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2LaunchTemplateDataLicenseSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectLicenseSetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaintenanceOptions())
            {
                context.Writer.WritePropertyName("MaintenanceOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataMaintenanceOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MaintenanceOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMetadataOptions())
            {
                context.Writer.WritePropertyName("MetadataOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataMetadataOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MetadataOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMonitoring())
            {
                context.Writer.WritePropertyName("Monitoring");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataMonitoringDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Monitoring, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkInterfaceSet())
            {
                context.Writer.WritePropertyName("NetworkInterfaceSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkInterfaceSetListValue in requestObject.NetworkInterfaceSet)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2LaunchTemplateDataNetworkInterfaceSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkInterfaceSetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPlacement())
            {
                context.Writer.WritePropertyName("Placement");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataPlacementDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Placement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrivateDnsNameOptions())
            {
                context.Writer.WritePropertyName("PrivateDnsNameOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.PrivateDnsNameOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRamDiskId())
            {
                context.Writer.WritePropertyName("RamDiskId");
                context.Writer.WriteStringValue(requestObject.RamDiskId);
            }

            if(requestObject.IsSetSecurityGroupIdSet())
            {
                context.Writer.WritePropertyName("SecurityGroupIdSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupIdSetListValue in requestObject.SecurityGroupIdSet)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupIdSetListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecurityGroupSet())
            {
                context.Writer.WritePropertyName("SecurityGroupSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupSetListValue in requestObject.SecurityGroupSet)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupSetListValue);
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
        public readonly static AwsEc2LaunchTemplateDataDetailsMarshaller Instance = new AwsEc2LaunchTemplateDataDetailsMarshaller();

    }
}