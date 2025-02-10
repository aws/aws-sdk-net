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
    /// AwsAutoScalingLaunchConfigurationDetails Marshaller
    /// </summary>
    public class AwsAutoScalingLaunchConfigurationDetailsMarshaller : IRequestMarshaller<AwsAutoScalingLaunchConfigurationDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsAutoScalingLaunchConfigurationDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssociatePublicIpAddress())
            {
                context.Writer.WritePropertyName("AssociatePublicIpAddress");
                context.Writer.WriteBooleanValue(requestObject.AssociatePublicIpAddress.Value);
            }

            if(requestObject.IsSetBlockDeviceMappings())
            {
                context.Writer.WritePropertyName("BlockDeviceMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBlockDeviceMappingsListValue in requestObject.BlockDeviceMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsAutoScalingLaunchConfigurationBlockDeviceMappingsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlockDeviceMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetClassicLinkVpcId())
            {
                context.Writer.WritePropertyName("ClassicLinkVpcId");
                context.Writer.WriteStringValue(requestObject.ClassicLinkVpcId);
            }

            if(requestObject.IsSetClassicLinkVpcSecurityGroups())
            {
                context.Writer.WritePropertyName("ClassicLinkVpcSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClassicLinkVpcSecurityGroupsListValue in requestObject.ClassicLinkVpcSecurityGroups)
                {
                        context.Writer.WriteStringValue(requestObjectClassicLinkVpcSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCreatedTime())
            {
                context.Writer.WritePropertyName("CreatedTime");
                context.Writer.WriteStringValue(requestObject.CreatedTime);
            }

            if(requestObject.IsSetEbsOptimized())
            {
                context.Writer.WritePropertyName("EbsOptimized");
                context.Writer.WriteBooleanValue(requestObject.EbsOptimized.Value);
            }

            if(requestObject.IsSetIamInstanceProfile())
            {
                context.Writer.WritePropertyName("IamInstanceProfile");
                context.Writer.WriteStringValue(requestObject.IamInstanceProfile);
            }

            if(requestObject.IsSetImageId())
            {
                context.Writer.WritePropertyName("ImageId");
                context.Writer.WriteStringValue(requestObject.ImageId);
            }

            if(requestObject.IsSetInstanceMonitoring())
            {
                context.Writer.WritePropertyName("InstanceMonitoring");
                context.Writer.WriteStartObject();

                var marshaller = AwsAutoScalingLaunchConfigurationInstanceMonitoringDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceMonitoring, context);

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

            if(requestObject.IsSetLaunchConfigurationName())
            {
                context.Writer.WritePropertyName("LaunchConfigurationName");
                context.Writer.WriteStringValue(requestObject.LaunchConfigurationName);
            }

            if(requestObject.IsSetMetadataOptions())
            {
                context.Writer.WritePropertyName("MetadataOptions");
                context.Writer.WriteStartObject();

                var marshaller = AwsAutoScalingLaunchConfigurationMetadataOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.MetadataOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPlacementTenancy())
            {
                context.Writer.WritePropertyName("PlacementTenancy");
                context.Writer.WriteStringValue(requestObject.PlacementTenancy);
            }

            if(requestObject.IsSetRamdiskId())
            {
                context.Writer.WritePropertyName("RamdiskId");
                context.Writer.WriteStringValue(requestObject.RamdiskId);
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

            if(requestObject.IsSetSpotPrice())
            {
                context.Writer.WritePropertyName("SpotPrice");
                context.Writer.WriteStringValue(requestObject.SpotPrice);
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
        public readonly static AwsAutoScalingLaunchConfigurationDetailsMarshaller Instance = new AwsAutoScalingLaunchConfigurationDetailsMarshaller();

    }
}