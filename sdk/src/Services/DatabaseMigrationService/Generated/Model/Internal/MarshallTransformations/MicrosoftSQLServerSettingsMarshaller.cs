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
            if(requestObject.IsSetBcpPacketSize())
            {
                context.Writer.WritePropertyName("BcpPacketSize");
                context.Writer.Write(requestObject.BcpPacketSize);
            }

            if(requestObject.IsSetControlTablesFileGroup())
            {
                context.Writer.WritePropertyName("ControlTablesFileGroup");
                context.Writer.Write(requestObject.ControlTablesFileGroup);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetForceLobLookup())
            {
                context.Writer.WritePropertyName("ForceLobLookup");
                context.Writer.Write(requestObject.ForceLobLookup);
            }

            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.Write(requestObject.Password);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.Write(requestObject.Port);
            }

            if(requestObject.IsSetQuerySingleAlwaysOnNode())
            {
                context.Writer.WritePropertyName("QuerySingleAlwaysOnNode");
                context.Writer.Write(requestObject.QuerySingleAlwaysOnNode);
            }

            if(requestObject.IsSetReadBackupOnly())
            {
                context.Writer.WritePropertyName("ReadBackupOnly");
                context.Writer.Write(requestObject.ReadBackupOnly);
            }

            if(requestObject.IsSetSafeguardPolicy())
            {
                context.Writer.WritePropertyName("SafeguardPolicy");
                context.Writer.Write(requestObject.SafeguardPolicy);
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

            if(requestObject.IsSetTlogAccessMode())
            {
                context.Writer.WritePropertyName("TlogAccessMode");
                context.Writer.Write(requestObject.TlogAccessMode);
            }

            if(requestObject.IsSetTrimSpaceInChar())
            {
                context.Writer.WritePropertyName("TrimSpaceInChar");
                context.Writer.Write(requestObject.TrimSpaceInChar);
            }

            if(requestObject.IsSetUseBcpFullLoad())
            {
                context.Writer.WritePropertyName("UseBcpFullLoad");
                context.Writer.Write(requestObject.UseBcpFullLoad);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.Write(requestObject.Username);
            }

            if(requestObject.IsSetUseThirdPartyBackupDevice())
            {
                context.Writer.WritePropertyName("UseThirdPartyBackupDevice");
                context.Writer.Write(requestObject.UseThirdPartyBackupDevice);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MicrosoftSQLServerSettingsMarshaller Instance = new MicrosoftSQLServerSettingsMarshaller();

    }
}