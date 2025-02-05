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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GcpMySQLSettings Marshaller
    /// </summary>
    public class GcpMySQLSettingsMarshaller : IRequestMarshaller<GcpMySQLSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GcpMySQLSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAfterConnectScript())
            {
                context.Writer.WritePropertyName("AfterConnectScript");
                context.Writer.WriteStringValue(requestObject.AfterConnectScript);
            }

            if(requestObject.IsSetCleanSourceMetadataOnMismatch())
            {
                context.Writer.WritePropertyName("CleanSourceMetadataOnMismatch");
                context.Writer.WriteBooleanValue(requestObject.CleanSourceMetadataOnMismatch.Value);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetEventsPollInterval())
            {
                context.Writer.WritePropertyName("EventsPollInterval");
                context.Writer.WriteNumberValue(requestObject.EventsPollInterval.Value);
            }

            if(requestObject.IsSetMaxFileSize())
            {
                context.Writer.WritePropertyName("MaxFileSize");
                context.Writer.WriteNumberValue(requestObject.MaxFileSize.Value);
            }

            if(requestObject.IsSetParallelLoadThreads())
            {
                context.Writer.WritePropertyName("ParallelLoadThreads");
                context.Writer.WriteNumberValue(requestObject.ParallelLoadThreads.Value);
            }

            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.WriteStringValue(requestObject.Password);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetSecretsManagerAccessRoleArn())
            {
                context.Writer.WritePropertyName("SecretsManagerAccessRoleArn");
                context.Writer.WriteStringValue(requestObject.SecretsManagerAccessRoleArn);
            }

            if(requestObject.IsSetSecretsManagerSecretId())
            {
                context.Writer.WritePropertyName("SecretsManagerSecretId");
                context.Writer.WriteStringValue(requestObject.SecretsManagerSecretId);
            }

            if(requestObject.IsSetServerName())
            {
                context.Writer.WritePropertyName("ServerName");
                context.Writer.WriteStringValue(requestObject.ServerName);
            }

            if(requestObject.IsSetServerTimezone())
            {
                context.Writer.WritePropertyName("ServerTimezone");
                context.Writer.WriteStringValue(requestObject.ServerTimezone);
            }

            if(requestObject.IsSetTargetDbType())
            {
                context.Writer.WritePropertyName("TargetDbType");
                context.Writer.WriteStringValue(requestObject.TargetDbType);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.WriteStringValue(requestObject.Username);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GcpMySQLSettingsMarshaller Instance = new GcpMySQLSettingsMarshaller();

    }
}