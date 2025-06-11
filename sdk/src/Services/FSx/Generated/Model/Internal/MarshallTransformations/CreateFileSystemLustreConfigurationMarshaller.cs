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
    /// CreateFileSystemLustreConfiguration Marshaller
    /// </summary>
    public class CreateFileSystemLustreConfigurationMarshaller : IRequestMarshaller<CreateFileSystemLustreConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateFileSystemLustreConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutoImportPolicy())
            {
                context.Writer.WritePropertyName("AutoImportPolicy");
                context.Writer.WriteStringValue(requestObject.AutoImportPolicy);
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

            if(requestObject.IsSetDataCompressionType())
            {
                context.Writer.WritePropertyName("DataCompressionType");
                context.Writer.WriteStringValue(requestObject.DataCompressionType);
            }

            if(requestObject.IsSetDataReadCacheConfiguration())
            {
                context.Writer.WritePropertyName("DataReadCacheConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LustreReadCacheConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DataReadCacheConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeploymentType())
            {
                context.Writer.WritePropertyName("DeploymentType");
                context.Writer.WriteStringValue(requestObject.DeploymentType);
            }

            if(requestObject.IsSetDriveCacheType())
            {
                context.Writer.WritePropertyName("DriveCacheType");
                context.Writer.WriteStringValue(requestObject.DriveCacheType);
            }

            if(requestObject.IsSetEfaEnabled())
            {
                context.Writer.WritePropertyName("EfaEnabled");
                context.Writer.WriteBooleanValue(requestObject.EfaEnabled.Value);
            }

            if(requestObject.IsSetExportPath())
            {
                context.Writer.WritePropertyName("ExportPath");
                context.Writer.WriteStringValue(requestObject.ExportPath);
            }

            if(requestObject.IsSetImportedFileChunkSize())
            {
                context.Writer.WritePropertyName("ImportedFileChunkSize");
                context.Writer.WriteNumberValue(requestObject.ImportedFileChunkSize.Value);
            }

            if(requestObject.IsSetImportPath())
            {
                context.Writer.WritePropertyName("ImportPath");
                context.Writer.WriteStringValue(requestObject.ImportPath);
            }

            if(requestObject.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("LogConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LustreLogCreateConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMetadataConfiguration())
            {
                context.Writer.WritePropertyName("MetadataConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CreateFileSystemLustreMetadataConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MetadataConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPerUnitStorageThroughput())
            {
                context.Writer.WritePropertyName("PerUnitStorageThroughput");
                context.Writer.WriteNumberValue(requestObject.PerUnitStorageThroughput.Value);
            }

            if(requestObject.IsSetRootSquashConfiguration())
            {
                context.Writer.WritePropertyName("RootSquashConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LustreRootSquashConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RootSquashConfiguration, context);

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
        public readonly static CreateFileSystemLustreConfigurationMarshaller Instance = new CreateFileSystemLustreConfigurationMarshaller();

    }
}