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
    /// CreateFileSystemWindowsConfiguration Marshaller
    /// </summary>
    public class CreateFileSystemWindowsConfigurationMarshaller : IRequestMarshaller<CreateFileSystemWindowsConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateFileSystemWindowsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActiveDirectoryId())
            {
                context.Writer.WritePropertyName("ActiveDirectoryId");
                context.Writer.WriteStringValue(requestObject.ActiveDirectoryId);
            }

            if(requestObject.IsSetAliases())
            {
                context.Writer.WritePropertyName("Aliases");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAliasesListValue in requestObject.Aliases)
                {
                        context.Writer.WriteStringValue(requestObjectAliasesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAuditLogConfiguration())
            {
                context.Writer.WritePropertyName("AuditLogConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = WindowsAuditLogCreateConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AuditLogConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAutomaticBackupRetentionDays())
            {
                context.Writer.WritePropertyName("AutomaticBackupRetentionDays");
                context.Writer.WriteNumberValue(requestObject.AutomaticBackupRetentionDays.Value);
            }

            if(requestObject.IsSetCopyTagsToBackups())
            {
                context.Writer.WritePropertyName("CopyTagsToBackups");
                context.Writer.WriteBooleanValue(requestObject.CopyTagsToBackups.Value);
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

            if(requestObject.IsSetPreferredSubnetId())
            {
                context.Writer.WritePropertyName("PreferredSubnetId");
                context.Writer.WriteStringValue(requestObject.PreferredSubnetId);
            }

            if(requestObject.IsSetSelfManagedActiveDirectoryConfiguration())
            {
                context.Writer.WritePropertyName("SelfManagedActiveDirectoryConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SelfManagedActiveDirectoryConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SelfManagedActiveDirectoryConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetThroughputCapacity())
            {
                context.Writer.WritePropertyName("ThroughputCapacity");
                context.Writer.WriteNumberValue(requestObject.ThroughputCapacity.Value);
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
        public readonly static CreateFileSystemWindowsConfigurationMarshaller Instance = new CreateFileSystemWindowsConfigurationMarshaller();

    }
}