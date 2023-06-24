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
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PostgreSQLSettings Marshaller
    /// </summary>
    public class PostgreSQLSettingsMarshaller : IRequestMarshaller<PostgreSQLSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PostgreSQLSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAfterConnectScript())
            {
                context.Writer.WritePropertyName("AfterConnectScript");
                context.Writer.Write(requestObject.AfterConnectScript);
            }

            if(requestObject.IsSetCaptureDdls())
            {
                context.Writer.WritePropertyName("CaptureDdls");
                context.Writer.Write(requestObject.CaptureDdls);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDdlArtifactsSchema())
            {
                context.Writer.WritePropertyName("DdlArtifactsSchema");
                context.Writer.Write(requestObject.DdlArtifactsSchema);
            }

            if(requestObject.IsSetExecuteTimeout())
            {
                context.Writer.WritePropertyName("ExecuteTimeout");
                context.Writer.Write(requestObject.ExecuteTimeout);
            }

            if(requestObject.IsSetFailTasksOnLobTruncation())
            {
                context.Writer.WritePropertyName("FailTasksOnLobTruncation");
                context.Writer.Write(requestObject.FailTasksOnLobTruncation);
            }

            if(requestObject.IsSetHeartbeatEnable())
            {
                context.Writer.WritePropertyName("HeartbeatEnable");
                context.Writer.Write(requestObject.HeartbeatEnable);
            }

            if(requestObject.IsSetHeartbeatFrequency())
            {
                context.Writer.WritePropertyName("HeartbeatFrequency");
                context.Writer.Write(requestObject.HeartbeatFrequency);
            }

            if(requestObject.IsSetHeartbeatSchema())
            {
                context.Writer.WritePropertyName("HeartbeatSchema");
                context.Writer.Write(requestObject.HeartbeatSchema);
            }

            if(requestObject.IsSetMapBooleanAsBoolean())
            {
                context.Writer.WritePropertyName("MapBooleanAsBoolean");
                context.Writer.Write(requestObject.MapBooleanAsBoolean);
            }

            if(requestObject.IsSetMaxFileSize())
            {
                context.Writer.WritePropertyName("MaxFileSize");
                context.Writer.Write(requestObject.MaxFileSize);
            }

            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.Write(requestObject.Password);
            }

            if(requestObject.IsSetPluginName())
            {
                context.Writer.WritePropertyName("PluginName");
                context.Writer.Write(requestObject.PluginName);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.Write(requestObject.Port);
            }

            if(requestObject.IsSetSecretsManagerAccessRoleArn())
            {
                context.Writer.WritePropertyName("SecretsManagerAccessRoleArn");
                context.Writer.Write(requestObject.SecretsManagerAccessRoleArn);
            }

            if(requestObject.IsSetSecretsManagerSecretId())
            {
                context.Writer.WritePropertyName("SecretsManagerSecretId");
                context.Writer.Write(requestObject.SecretsManagerSecretId);
            }

            if(requestObject.IsSetServerName())
            {
                context.Writer.WritePropertyName("ServerName");
                context.Writer.Write(requestObject.ServerName);
            }

            if(requestObject.IsSetSlotName())
            {
                context.Writer.WritePropertyName("SlotName");
                context.Writer.Write(requestObject.SlotName);
            }

            if(requestObject.IsSetTrimSpaceInChar())
            {
                context.Writer.WritePropertyName("TrimSpaceInChar");
                context.Writer.Write(requestObject.TrimSpaceInChar);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.Write(requestObject.Username);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PostgreSQLSettingsMarshaller Instance = new PostgreSQLSettingsMarshaller();

    }
}