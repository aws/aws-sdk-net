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
    /// MicrosoftSQLServerSettings Marshaller
    /// </summary>
    public class MicrosoftSQLServerSettingsMarshaller : IRequestMarshaller<MicrosoftSQLServerSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MicrosoftSQLServerSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthenticationMethod())
            {
                context.Writer.WritePropertyName("AuthenticationMethod");
                context.Writer.WriteStringValue(requestObject.AuthenticationMethod);
            }

            if(requestObject.IsSetBcpPacketSize())
            {
                context.Writer.WritePropertyName("BcpPacketSize");
                context.Writer.WriteNumberValue(requestObject.BcpPacketSize.Value);
            }

            if(requestObject.IsSetControlTablesFileGroup())
            {
                context.Writer.WritePropertyName("ControlTablesFileGroup");
                context.Writer.WriteStringValue(requestObject.ControlTablesFileGroup);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetForceLobLookup())
            {
                context.Writer.WritePropertyName("ForceLobLookup");
                context.Writer.WriteBooleanValue(requestObject.ForceLobLookup.Value);
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

            if(requestObject.IsSetQuerySingleAlwaysOnNode())
            {
                context.Writer.WritePropertyName("QuerySingleAlwaysOnNode");
                context.Writer.WriteBooleanValue(requestObject.QuerySingleAlwaysOnNode.Value);
            }

            if(requestObject.IsSetReadBackupOnly())
            {
                context.Writer.WritePropertyName("ReadBackupOnly");
                context.Writer.WriteBooleanValue(requestObject.ReadBackupOnly.Value);
            }

            if(requestObject.IsSetSafeguardPolicy())
            {
                context.Writer.WritePropertyName("SafeguardPolicy");
                context.Writer.WriteStringValue(requestObject.SafeguardPolicy);
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

            if(requestObject.IsSetTlogAccessMode())
            {
                context.Writer.WritePropertyName("TlogAccessMode");
                context.Writer.WriteStringValue(requestObject.TlogAccessMode);
            }

            if(requestObject.IsSetTrimSpaceInChar())
            {
                context.Writer.WritePropertyName("TrimSpaceInChar");
                context.Writer.WriteBooleanValue(requestObject.TrimSpaceInChar.Value);
            }

            if(requestObject.IsSetUseBcpFullLoad())
            {
                context.Writer.WritePropertyName("UseBcpFullLoad");
                context.Writer.WriteBooleanValue(requestObject.UseBcpFullLoad.Value);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.WriteStringValue(requestObject.Username);
            }

            if(requestObject.IsSetUseThirdPartyBackupDevice())
            {
                context.Writer.WritePropertyName("UseThirdPartyBackupDevice");
                context.Writer.WriteBooleanValue(requestObject.UseThirdPartyBackupDevice.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MicrosoftSQLServerSettingsMarshaller Instance = new MicrosoftSQLServerSettingsMarshaller();

    }
}