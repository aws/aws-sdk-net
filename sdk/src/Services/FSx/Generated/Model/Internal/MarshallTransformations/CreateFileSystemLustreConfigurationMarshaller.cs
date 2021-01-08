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
            if(requestObject.IsSetAutoImportPolicy())
            {
                context.Writer.WritePropertyName("AutoImportPolicy");
                context.Writer.Write(requestObject.AutoImportPolicy);
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

            if(requestObject.IsSetDriveCacheType())
            {
                context.Writer.WritePropertyName("DriveCacheType");
                context.Writer.Write(requestObject.DriveCacheType);
            }

            if(requestObject.IsSetExportPath())
            {
                context.Writer.WritePropertyName("ExportPath");
                context.Writer.Write(requestObject.ExportPath);
            }

            if(requestObject.IsSetImportedFileChunkSize())
            {
                context.Writer.WritePropertyName("ImportedFileChunkSize");
                context.Writer.Write(requestObject.ImportedFileChunkSize);
            }

            if(requestObject.IsSetImportPath())
            {
                context.Writer.WritePropertyName("ImportPath");
                context.Writer.Write(requestObject.ImportPath);
            }

            if(requestObject.IsSetPerUnitStorageThroughput())
            {
                context.Writer.WritePropertyName("PerUnitStorageThroughput");
                context.Writer.Write(requestObject.PerUnitStorageThroughput);
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
        public readonly static CreateFileSystemLustreConfigurationMarshaller Instance = new CreateFileSystemLustreConfigurationMarshaller();

    }
}