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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFileSystemOntapConfiguration Marshaller
    /// </summary>
    public class CreateFileSystemOntapConfigurationMarshaller : IRequestMarshaller<CreateFileSystemOntapConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateFileSystemOntapConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutomaticBackupRetentionDays())
            {
                context.Writer.WritePropertyName("AutomaticBackupRetentionDays");
                context.Writer.WriteNumberValue(requestObject.AutomaticBackupRetentionDays.Value);
            }

            if(requestObject.IsSetDailyAutomaticBackupStartTime())
            {
                context.Writer.WritePropertyName("DailyAutomaticBackupStartTime");
                context.Writer.WriteStringValue(requestObject.DailyAutomaticBackupStartTime);
            }

            if(requestObject.IsSetDeploymentType())
            {
                context.Writer.WritePropertyName("DeploymentType");
                context.Writer.WriteStringValue(requestObject.DeploymentType);
            }

            if(requestObject.IsSetDiskIopsConfiguration())
            {
                context.Writer.WritePropertyName("DiskIopsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DiskIopsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DiskIopsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEndpointIpAddressRange())
            {
                context.Writer.WritePropertyName("EndpointIpAddressRange");
                context.Writer.WriteStringValue(requestObject.EndpointIpAddressRange);
            }

            if(requestObject.IsSetEndpointIpv6AddressRange())
            {
                context.Writer.WritePropertyName("EndpointIpv6AddressRange");
                context.Writer.WriteStringValue(requestObject.EndpointIpv6AddressRange);
            }

            if(requestObject.IsSetFsxAdminPassword())
            {
                context.Writer.WritePropertyName("FsxAdminPassword");
                context.Writer.WriteStringValue(requestObject.FsxAdminPassword);
            }

            if(requestObject.IsSetHAPairs())
            {
                context.Writer.WritePropertyName("HAPairs");
                context.Writer.WriteNumberValue(requestObject.HAPairs.Value);
            }

            if(requestObject.IsSetPreferredSubnetId())
            {
                context.Writer.WritePropertyName("PreferredSubnetId");
                context.Writer.WriteStringValue(requestObject.PreferredSubnetId);
            }

            if(requestObject.IsSetRouteTableIds())
            {
                context.Writer.WritePropertyName("RouteTableIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRouteTableIdsListValue in requestObject.RouteTableIds)
                {
                        context.Writer.WriteStringValue(requestObjectRouteTableIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThroughputCapacity())
            {
                context.Writer.WritePropertyName("ThroughputCapacity");
                context.Writer.WriteNumberValue(requestObject.ThroughputCapacity.Value);
            }

            if(requestObject.IsSetThroughputCapacityPerHAPair())
            {
                context.Writer.WritePropertyName("ThroughputCapacityPerHAPair");
                context.Writer.WriteNumberValue(requestObject.ThroughputCapacityPerHAPair.Value);
            }

            if(requestObject.IsSetWeeklyMaintenanceStartTime())
            {
                context.Writer.WritePropertyName("WeeklyMaintenanceStartTime");
                context.Writer.WriteStringValue(requestObject.WeeklyMaintenanceStartTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateFileSystemOntapConfigurationMarshaller Instance = new CreateFileSystemOntapConfigurationMarshaller();

    }
}