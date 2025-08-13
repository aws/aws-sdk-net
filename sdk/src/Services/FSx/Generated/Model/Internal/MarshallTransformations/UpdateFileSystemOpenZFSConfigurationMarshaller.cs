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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFileSystemOpenZFSConfiguration Marshaller
    /// </summary>
    public class UpdateFileSystemOpenZFSConfigurationMarshaller : IRequestMarshaller<UpdateFileSystemOpenZFSConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateFileSystemOpenZFSConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddRouteTableIds())
            {
                context.Writer.WritePropertyName("AddRouteTableIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAddRouteTableIdsListValue in requestObject.AddRouteTableIds)
                {
                        context.Writer.Write(requestObjectAddRouteTableIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAutomaticBackupRetentionDays())
            {
                context.Writer.WritePropertyName("AutomaticBackupRetentionDays");
                context.Writer.Write(requestObject.AutomaticBackupRetentionDays);
            }

            if(requestObject.IsSetCopyTagsToBackups())
            {
                context.Writer.WritePropertyName("CopyTagsToBackups");
                context.Writer.Write(requestObject.CopyTagsToBackups);
            }

            if(requestObject.IsSetCopyTagsToVolumes())
            {
                context.Writer.WritePropertyName("CopyTagsToVolumes");
                context.Writer.Write(requestObject.CopyTagsToVolumes);
            }

            if(requestObject.IsSetDailyAutomaticBackupStartTime())
            {
                context.Writer.WritePropertyName("DailyAutomaticBackupStartTime");
                context.Writer.Write(requestObject.DailyAutomaticBackupStartTime);
            }

            if(requestObject.IsSetDiskIopsConfiguration())
            {
                context.Writer.WritePropertyName("DiskIopsConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DiskIopsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DiskIopsConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEndpointIpv6AddressRange())
            {
                context.Writer.WritePropertyName("EndpointIpv6AddressRange");
                context.Writer.Write(requestObject.EndpointIpv6AddressRange);
            }

            if(requestObject.IsSetReadCacheConfiguration())
            {
                context.Writer.WritePropertyName("ReadCacheConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = OpenZFSReadCacheConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ReadCacheConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRemoveRouteTableIds())
            {
                context.Writer.WritePropertyName("RemoveRouteTableIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRemoveRouteTableIdsListValue in requestObject.RemoveRouteTableIds)
                {
                        context.Writer.Write(requestObjectRemoveRouteTableIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetThroughputCapacity())
            {
                context.Writer.WritePropertyName("ThroughputCapacity");
                context.Writer.Write(requestObject.ThroughputCapacity);
            }

            if(requestObject.IsSetWeeklyMaintenanceStartTime())
            {
                context.Writer.WritePropertyName("WeeklyMaintenanceStartTime");
                context.Writer.Write(requestObject.WeeklyMaintenanceStartTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateFileSystemOpenZFSConfigurationMarshaller Instance = new UpdateFileSystemOpenZFSConfigurationMarshaller();

    }
}