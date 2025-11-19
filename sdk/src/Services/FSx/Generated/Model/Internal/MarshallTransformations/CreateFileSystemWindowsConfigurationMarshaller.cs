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
                context.Writer.Write(requestObject.ActiveDirectoryId);
            }

            if(requestObject.IsSetAliases())
            {
                context.Writer.WritePropertyName("Aliases");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAliasesListValue in requestObject.Aliases)
                {
                        context.Writer.Write(requestObjectAliasesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAuditLogConfiguration())
            {
                context.Writer.WritePropertyName("AuditLogConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = WindowsAuditLogCreateConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AuditLogConfiguration, context);

                context.Writer.WriteObjectEnd();
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

            if(requestObject.IsSetDailyAutomaticBackupStartTime())
            {
                context.Writer.WritePropertyName("DailyAutomaticBackupStartTime");
                context.Writer.Write(requestObject.DailyAutomaticBackupStartTime);
            }

            if(requestObject.IsSetDeploymentType())
            {
                context.Writer.WritePropertyName("DeploymentType");
                context.Writer.Write(requestObject.DeploymentType);
            }

            if(requestObject.IsSetDiskIopsConfiguration())
            {
                context.Writer.WritePropertyName("DiskIopsConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DiskIopsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DiskIopsConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFsrmConfiguration())
            {
                context.Writer.WritePropertyName("FsrmConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = WindowsFsrmConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FsrmConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPreferredSubnetId())
            {
                context.Writer.WritePropertyName("PreferredSubnetId");
                context.Writer.Write(requestObject.PreferredSubnetId);
            }

            if(requestObject.IsSetSelfManagedActiveDirectoryConfiguration())
            {
                context.Writer.WritePropertyName("SelfManagedActiveDirectoryConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = SelfManagedActiveDirectoryConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SelfManagedActiveDirectoryConfiguration, context);

                context.Writer.WriteObjectEnd();
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
        public readonly static CreateFileSystemWindowsConfigurationMarshaller Instance = new CreateFileSystemWindowsConfigurationMarshaller();

    }
}