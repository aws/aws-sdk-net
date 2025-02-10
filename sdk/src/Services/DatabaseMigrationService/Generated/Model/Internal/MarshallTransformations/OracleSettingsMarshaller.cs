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
    /// OracleSettings Marshaller
    /// </summary>
    public class OracleSettingsMarshaller : IRequestMarshaller<OracleSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OracleSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessAlternateDirectly())
            {
                context.Writer.WritePropertyName("AccessAlternateDirectly");
                context.Writer.WriteBooleanValue(requestObject.AccessAlternateDirectly.Value);
            }

            if(requestObject.IsSetAdditionalArchivedLogDestId())
            {
                context.Writer.WritePropertyName("AdditionalArchivedLogDestId");
                context.Writer.WriteNumberValue(requestObject.AdditionalArchivedLogDestId.Value);
            }

            if(requestObject.IsSetAddSupplementalLogging())
            {
                context.Writer.WritePropertyName("AddSupplementalLogging");
                context.Writer.WriteBooleanValue(requestObject.AddSupplementalLogging.Value);
            }

            if(requestObject.IsSetAllowSelectNestedTables())
            {
                context.Writer.WritePropertyName("AllowSelectNestedTables");
                context.Writer.WriteBooleanValue(requestObject.AllowSelectNestedTables.Value);
            }

            if(requestObject.IsSetArchivedLogDestId())
            {
                context.Writer.WritePropertyName("ArchivedLogDestId");
                context.Writer.WriteNumberValue(requestObject.ArchivedLogDestId.Value);
            }

            if(requestObject.IsSetArchivedLogsOnly())
            {
                context.Writer.WritePropertyName("ArchivedLogsOnly");
                context.Writer.WriteBooleanValue(requestObject.ArchivedLogsOnly.Value);
            }

            if(requestObject.IsSetAsmPassword())
            {
                context.Writer.WritePropertyName("AsmPassword");
                context.Writer.WriteStringValue(requestObject.AsmPassword);
            }

            if(requestObject.IsSetAsmServer())
            {
                context.Writer.WritePropertyName("AsmServer");
                context.Writer.WriteStringValue(requestObject.AsmServer);
            }

            if(requestObject.IsSetAsmUser())
            {
                context.Writer.WritePropertyName("AsmUser");
                context.Writer.WriteStringValue(requestObject.AsmUser);
            }

            if(requestObject.IsSetAuthenticationMethod())
            {
                context.Writer.WritePropertyName("AuthenticationMethod");
                context.Writer.WriteStringValue(requestObject.AuthenticationMethod);
            }

            if(requestObject.IsSetCharLengthSemantics())
            {
                context.Writer.WritePropertyName("CharLengthSemantics");
                context.Writer.WriteStringValue(requestObject.CharLengthSemantics);
            }

            if(requestObject.IsSetConvertTimestampWithZoneToUTC())
            {
                context.Writer.WritePropertyName("ConvertTimestampWithZoneToUTC");
                context.Writer.WriteBooleanValue(requestObject.ConvertTimestampWithZoneToUTC.Value);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDirectPathNoLog())
            {
                context.Writer.WritePropertyName("DirectPathNoLog");
                context.Writer.WriteBooleanValue(requestObject.DirectPathNoLog.Value);
            }

            if(requestObject.IsSetDirectPathParallelLoad())
            {
                context.Writer.WritePropertyName("DirectPathParallelLoad");
                context.Writer.WriteBooleanValue(requestObject.DirectPathParallelLoad.Value);
            }

            if(requestObject.IsSetEnableHomogenousTablespace())
            {
                context.Writer.WritePropertyName("EnableHomogenousTablespace");
                context.Writer.WriteBooleanValue(requestObject.EnableHomogenousTablespace.Value);
            }

            if(requestObject.IsSetExtraArchivedLogDestIds())
            {
                context.Writer.WritePropertyName("ExtraArchivedLogDestIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExtraArchivedLogDestIdsListValue in requestObject.ExtraArchivedLogDestIds)
                {
                        context.Writer.WriteNumberValue(requestObjectExtraArchivedLogDestIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFailTasksOnLobTruncation())
            {
                context.Writer.WritePropertyName("FailTasksOnLobTruncation");
                context.Writer.WriteBooleanValue(requestObject.FailTasksOnLobTruncation.Value);
            }

            if(requestObject.IsSetNumberDatatypeScale())
            {
                context.Writer.WritePropertyName("NumberDatatypeScale");
                context.Writer.WriteNumberValue(requestObject.NumberDatatypeScale.Value);
            }

            if(requestObject.IsSetOpenTransactionWindow())
            {
                context.Writer.WritePropertyName("OpenTransactionWindow");
                context.Writer.WriteNumberValue(requestObject.OpenTransactionWindow.Value);
            }

            if(requestObject.IsSetOraclePathPrefix())
            {
                context.Writer.WritePropertyName("OraclePathPrefix");
                context.Writer.WriteStringValue(requestObject.OraclePathPrefix);
            }

            if(requestObject.IsSetParallelAsmReadThreads())
            {
                context.Writer.WritePropertyName("ParallelAsmReadThreads");
                context.Writer.WriteNumberValue(requestObject.ParallelAsmReadThreads.Value);
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

            if(requestObject.IsSetReadAheadBlocks())
            {
                context.Writer.WritePropertyName("ReadAheadBlocks");
                context.Writer.WriteNumberValue(requestObject.ReadAheadBlocks.Value);
            }

            if(requestObject.IsSetReadTableSpaceName())
            {
                context.Writer.WritePropertyName("ReadTableSpaceName");
                context.Writer.WriteBooleanValue(requestObject.ReadTableSpaceName.Value);
            }

            if(requestObject.IsSetReplacePathPrefix())
            {
                context.Writer.WritePropertyName("ReplacePathPrefix");
                context.Writer.WriteBooleanValue(requestObject.ReplacePathPrefix.Value);
            }

            if(requestObject.IsSetRetryInterval())
            {
                context.Writer.WritePropertyName("RetryInterval");
                context.Writer.WriteNumberValue(requestObject.RetryInterval.Value);
            }

            if(requestObject.IsSetSecretsManagerAccessRoleArn())
            {
                context.Writer.WritePropertyName("SecretsManagerAccessRoleArn");
                context.Writer.WriteStringValue(requestObject.SecretsManagerAccessRoleArn);
            }

            if(requestObject.IsSetSecretsManagerOracleAsmAccessRoleArn())
            {
                context.Writer.WritePropertyName("SecretsManagerOracleAsmAccessRoleArn");
                context.Writer.WriteStringValue(requestObject.SecretsManagerOracleAsmAccessRoleArn);
            }

            if(requestObject.IsSetSecretsManagerOracleAsmSecretId())
            {
                context.Writer.WritePropertyName("SecretsManagerOracleAsmSecretId");
                context.Writer.WriteStringValue(requestObject.SecretsManagerOracleAsmSecretId);
            }

            if(requestObject.IsSetSecretsManagerSecretId())
            {
                context.Writer.WritePropertyName("SecretsManagerSecretId");
                context.Writer.WriteStringValue(requestObject.SecretsManagerSecretId);
            }

            if(requestObject.IsSetSecurityDbEncryption())
            {
                context.Writer.WritePropertyName("SecurityDbEncryption");
                context.Writer.WriteStringValue(requestObject.SecurityDbEncryption);
            }

            if(requestObject.IsSetSecurityDbEncryptionName())
            {
                context.Writer.WritePropertyName("SecurityDbEncryptionName");
                context.Writer.WriteStringValue(requestObject.SecurityDbEncryptionName);
            }

            if(requestObject.IsSetServerName())
            {
                context.Writer.WritePropertyName("ServerName");
                context.Writer.WriteStringValue(requestObject.ServerName);
            }

            if(requestObject.IsSetSpatialDataOptionToGeoJsonFunctionName())
            {
                context.Writer.WritePropertyName("SpatialDataOptionToGeoJsonFunctionName");
                context.Writer.WriteStringValue(requestObject.SpatialDataOptionToGeoJsonFunctionName);
            }

            if(requestObject.IsSetStandbyDelayTime())
            {
                context.Writer.WritePropertyName("StandbyDelayTime");
                context.Writer.WriteNumberValue(requestObject.StandbyDelayTime.Value);
            }

            if(requestObject.IsSetTrimSpaceInChar())
            {
                context.Writer.WritePropertyName("TrimSpaceInChar");
                context.Writer.WriteBooleanValue(requestObject.TrimSpaceInChar.Value);
            }

            if(requestObject.IsSetUseAlternateFolderForOnline())
            {
                context.Writer.WritePropertyName("UseAlternateFolderForOnline");
                context.Writer.WriteBooleanValue(requestObject.UseAlternateFolderForOnline.Value);
            }

            if(requestObject.IsSetUseBFile())
            {
                context.Writer.WritePropertyName("UseBFile");
                context.Writer.WriteBooleanValue(requestObject.UseBFile.Value);
            }

            if(requestObject.IsSetUseDirectPathFullLoad())
            {
                context.Writer.WritePropertyName("UseDirectPathFullLoad");
                context.Writer.WriteBooleanValue(requestObject.UseDirectPathFullLoad.Value);
            }

            if(requestObject.IsSetUseLogminerReader())
            {
                context.Writer.WritePropertyName("UseLogminerReader");
                context.Writer.WriteBooleanValue(requestObject.UseLogminerReader.Value);
            }

            if(requestObject.IsSetUsePathPrefix())
            {
                context.Writer.WritePropertyName("UsePathPrefix");
                context.Writer.WriteStringValue(requestObject.UsePathPrefix);
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
        public readonly static OracleSettingsMarshaller Instance = new OracleSettingsMarshaller();

    }
}