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

#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OracleDataProviderSettings Marshaller
    /// </summary>
    public class OracleDataProviderSettingsMarshaller : IRequestMarshaller<OracleDataProviderSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OracleDataProviderSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAsmServer())
            {
                context.Writer.WritePropertyName("AsmServer");
                context.Writer.Write(requestObject.AsmServer);
            }

            if(requestObject.IsSetCertificateArn())
            {
                context.Writer.WritePropertyName("CertificateArn");
                context.Writer.Write(requestObject.CertificateArn);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.Write(requestObject.Port);
            }

            if(requestObject.IsSetSecretsManagerOracleAsmAccessRoleArn())
            {
                context.Writer.WritePropertyName("SecretsManagerOracleAsmAccessRoleArn");
                context.Writer.Write(requestObject.SecretsManagerOracleAsmAccessRoleArn);
            }

            if(requestObject.IsSetSecretsManagerOracleAsmSecretId())
            {
                context.Writer.WritePropertyName("SecretsManagerOracleAsmSecretId");
                context.Writer.Write(requestObject.SecretsManagerOracleAsmSecretId);
            }

            if(requestObject.IsSetSecretsManagerSecurityDbEncryptionAccessRoleArn())
            {
                context.Writer.WritePropertyName("SecretsManagerSecurityDbEncryptionAccessRoleArn");
                context.Writer.Write(requestObject.SecretsManagerSecurityDbEncryptionAccessRoleArn);
            }

            if(requestObject.IsSetSecretsManagerSecurityDbEncryptionSecretId())
            {
                context.Writer.WritePropertyName("SecretsManagerSecurityDbEncryptionSecretId");
                context.Writer.Write(requestObject.SecretsManagerSecurityDbEncryptionSecretId);
            }

            if(requestObject.IsSetServerName())
            {
                context.Writer.WritePropertyName("ServerName");
                context.Writer.Write(requestObject.ServerName);
            }

            if(requestObject.IsSetSslMode())
            {
                context.Writer.WritePropertyName("SslMode");
                context.Writer.Write(requestObject.SslMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OracleDataProviderSettingsMarshaller Instance = new OracleDataProviderSettingsMarshaller();

    }
}
#pragma warning restore CS0612,CS0618