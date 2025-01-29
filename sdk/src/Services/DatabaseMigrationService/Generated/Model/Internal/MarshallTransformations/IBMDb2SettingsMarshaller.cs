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
    /// IBMDb2Settings Marshaller
    /// </summary>
    public class IBMDb2SettingsMarshaller : IRequestMarshaller<IBMDb2Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IBMDb2Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCurrentLsn())
            {
                context.Writer.WritePropertyName("CurrentLsn");
                context.Writer.WriteStringValue(requestObject.CurrentLsn);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetKeepCsvFiles())
            {
                context.Writer.WritePropertyName("KeepCsvFiles");
                context.Writer.WriteBooleanValue(requestObject.KeepCsvFiles.Value);
            }

            if(requestObject.IsSetLoadTimeout())
            {
                context.Writer.WritePropertyName("LoadTimeout");
                context.Writer.WriteNumberValue(requestObject.LoadTimeout.Value);
            }

            if(requestObject.IsSetMaxFileSize())
            {
                context.Writer.WritePropertyName("MaxFileSize");
                context.Writer.WriteNumberValue(requestObject.MaxFileSize.Value);
            }

            if(requestObject.IsSetMaxKBytesPerRead())
            {
                context.Writer.WritePropertyName("MaxKBytesPerRead");
                context.Writer.WriteNumberValue(requestObject.MaxKBytesPerRead.Value);
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

            if(requestObject.IsSetSetDataCaptureChanges())
            {
                context.Writer.WritePropertyName("SetDataCaptureChanges");
                context.Writer.WriteBooleanValue(requestObject.SetDataCaptureChanges.Value);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.WriteStringValue(requestObject.Username);
            }

            if(requestObject.IsSetWriteBufferSize())
            {
                context.Writer.WritePropertyName("WriteBufferSize");
                context.Writer.WriteNumberValue(requestObject.WriteBufferSize.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IBMDb2SettingsMarshaller Instance = new IBMDb2SettingsMarshaller();

    }
}