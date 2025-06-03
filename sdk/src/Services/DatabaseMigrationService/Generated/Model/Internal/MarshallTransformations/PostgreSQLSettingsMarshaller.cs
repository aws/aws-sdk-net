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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAfterConnectScript())
            {
                context.Writer.WritePropertyName("AfterConnectScript");
                context.Writer.WriteStringValue(requestObject.AfterConnectScript);
            }

            if(requestObject.IsSetAuthenticationMethod())
            {
                context.Writer.WritePropertyName("AuthenticationMethod");
                context.Writer.WriteStringValue(requestObject.AuthenticationMethod);
            }

            if(requestObject.IsSetBabelfishDatabaseName())
            {
                context.Writer.WritePropertyName("BabelfishDatabaseName");
                context.Writer.WriteStringValue(requestObject.BabelfishDatabaseName);
            }

            if(requestObject.IsSetCaptureDdls())
            {
                context.Writer.WritePropertyName("CaptureDdls");
                context.Writer.WriteBooleanValue(requestObject.CaptureDdls.Value);
            }

            if(requestObject.IsSetDatabaseMode())
            {
                context.Writer.WritePropertyName("DatabaseMode");
                context.Writer.WriteStringValue(requestObject.DatabaseMode);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDdlArtifactsSchema())
            {
                context.Writer.WritePropertyName("DdlArtifactsSchema");
                context.Writer.WriteStringValue(requestObject.DdlArtifactsSchema);
            }

            if(requestObject.IsSetDisableUnicodeSourceFilter())
            {
                context.Writer.WritePropertyName("DisableUnicodeSourceFilter");
                context.Writer.WriteBooleanValue(requestObject.DisableUnicodeSourceFilter.Value);
            }

            if(requestObject.IsSetExecuteTimeout())
            {
                context.Writer.WritePropertyName("ExecuteTimeout");
                context.Writer.WriteNumberValue(requestObject.ExecuteTimeout.Value);
            }

            if(requestObject.IsSetFailTasksOnLobTruncation())
            {
                context.Writer.WritePropertyName("FailTasksOnLobTruncation");
                context.Writer.WriteBooleanValue(requestObject.FailTasksOnLobTruncation.Value);
            }

            if(requestObject.IsSetHeartbeatEnable())
            {
                context.Writer.WritePropertyName("HeartbeatEnable");
                context.Writer.WriteBooleanValue(requestObject.HeartbeatEnable.Value);
            }

            if(requestObject.IsSetHeartbeatFrequency())
            {
                context.Writer.WritePropertyName("HeartbeatFrequency");
                context.Writer.WriteNumberValue(requestObject.HeartbeatFrequency.Value);
            }

            if(requestObject.IsSetHeartbeatSchema())
            {
                context.Writer.WritePropertyName("HeartbeatSchema");
                context.Writer.WriteStringValue(requestObject.HeartbeatSchema);
            }

            if(requestObject.IsSetMapBooleanAsBoolean())
            {
                context.Writer.WritePropertyName("MapBooleanAsBoolean");
                context.Writer.WriteBooleanValue(requestObject.MapBooleanAsBoolean.Value);
            }

            if(requestObject.IsSetMapJsonbAsClob())
            {
                context.Writer.WritePropertyName("MapJsonbAsClob");
                context.Writer.WriteBooleanValue(requestObject.MapJsonbAsClob.Value);
            }

            if(requestObject.IsSetMapLongVarcharAs())
            {
                context.Writer.WritePropertyName("MapLongVarcharAs");
                context.Writer.WriteStringValue(requestObject.MapLongVarcharAs);
            }

            if(requestObject.IsSetMaxFileSize())
            {
                context.Writer.WritePropertyName("MaxFileSize");
                context.Writer.WriteNumberValue(requestObject.MaxFileSize.Value);
            }

            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.WriteStringValue(requestObject.Password);
            }

            if(requestObject.IsSetPluginName())
            {
                context.Writer.WritePropertyName("PluginName");
                context.Writer.WriteStringValue(requestObject.PluginName);
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

            if(requestObject.IsSetServiceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ServiceAccessRoleArn");
                context.Writer.WriteStringValue(requestObject.ServiceAccessRoleArn);
            }

            if(requestObject.IsSetSlotName())
            {
                context.Writer.WritePropertyName("SlotName");
                context.Writer.WriteStringValue(requestObject.SlotName);
            }

            if(requestObject.IsSetTrimSpaceInChar())
            {
                context.Writer.WritePropertyName("TrimSpaceInChar");
                context.Writer.WriteBooleanValue(requestObject.TrimSpaceInChar.Value);
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
        public readonly static PostgreSQLSettingsMarshaller Instance = new PostgreSQLSettingsMarshaller();

    }
}