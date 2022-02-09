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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAssociatePublicIpAddress())
            {
                context.Writer.WritePropertyName("AssociatePublicIpAddress");
                context.Writer.Write(requestObject.AssociatePublicIpAddress);
            }

            if(requestObject.IsSetBlockDeviceMappings())
            {
                context.Writer.WritePropertyName("BlockDeviceMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBlockDeviceMappingsListValue in requestObject.BlockDeviceMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsAutoScalingLaunchConfigurationBlockDeviceMappingsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlockDeviceMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetClassicLinkVpcId())
            {
                context.Writer.WritePropertyName("ClassicLinkVpcId");
                context.Writer.Write(requestObject.ClassicLinkVpcId);
            }

            if(requestObject.IsSetClassicLinkVpcSecurityGroups())
            {
                context.Writer.WritePropertyName("ClassicLinkVpcSecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectClassicLinkVpcSecurityGroupsListValue in requestObject.ClassicLinkVpcSecurityGroups)
                {
                        context.Writer.Write(requestObjectClassicLinkVpcSecurityGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCreatedTime())
            {
                context.Writer.WritePropertyName("CreatedTime");
                context.Writer.Write(requestObject.CreatedTime);
            }

            if(requestObject.IsSetEbsOptimized())
            {
                context.Writer.WritePropertyName("EbsOptimized");
                context.Writer.Write(requestObject.EbsOptimized);
            }

            if(requestObject.IsSetIamInstanceProfile())
            {
                context.Writer.WritePropertyName("IamInstanceProfile");
                context.Writer.Write(requestObject.IamInstanceProfile);
            }

            if(requestObject.IsSetImageId())
            {
                context.Writer.WritePropertyName("ImageId");
                context.Writer.Write(requestObject.ImageId);
            }

            if(requestObject.IsSetInstanceMonitoring())
            {
                context.Writer.WritePropertyName("InstanceMonitoring");
                context.Writer.WriteObjectStart();

                var marshaller = AwsAutoScalingLaunchConfigurationInstanceMonitoringDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceMonitoring, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.Write(requestObject.InstanceType);
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

            if(requestObject.IsSetLaunchConfigurationName())
            {
                context.Writer.WritePropertyName("LaunchConfigurationName");
                context.Writer.Write(requestObject.LaunchConfigurationName);
            }

            if(requestObject.IsSetMetadataOptions())
            {
                context.Writer.WritePropertyName("MetadataOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsAutoScalingLaunchConfigurationMetadataOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.MetadataOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPlacementTenancy())
            {
                context.Writer.WritePropertyName("PlacementTenancy");
                context.Writer.Write(requestObject.PlacementTenancy);
            }

            if(requestObject.IsSetRamdiskId())
            {
                context.Writer.WritePropertyName("RamdiskId");
                context.Writer.Write(requestObject.RamdiskId);
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

            if(requestObject.IsSetSpotPrice())
            {
                context.Writer.WritePropertyName("SpotPrice");
                context.Writer.Write(requestObject.SpotPrice);
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
        public readonly static AwsAutoScalingLaunchConfigurationDetailsMarshaller Instance = new AwsAutoScalingLaunchConfigurationDetailsMarshaller();

    }
}