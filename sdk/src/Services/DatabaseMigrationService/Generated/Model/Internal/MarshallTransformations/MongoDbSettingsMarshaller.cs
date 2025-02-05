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
    /// MongoDbSettings Marshaller
    /// </summary>
    public class MongoDbSettingsMarshaller : IRequestMarshaller<MongoDbSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MongoDbSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthMechanism())
            {
                context.Writer.WritePropertyName("AuthMechanism");
                context.Writer.WriteStringValue(requestObject.AuthMechanism);
            }

            if(requestObject.IsSetAuthSource())
            {
                context.Writer.WritePropertyName("AuthSource");
                context.Writer.WriteStringValue(requestObject.AuthSource);
            }

            if(requestObject.IsSetAuthType())
            {
                context.Writer.WritePropertyName("AuthType");
                context.Writer.WriteStringValue(requestObject.AuthType);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDocsToInvestigate())
            {
                context.Writer.WritePropertyName("DocsToInvestigate");
                context.Writer.WriteStringValue(requestObject.DocsToInvestigate);
            }

            if(requestObject.IsSetExtractDocId())
            {
                context.Writer.WritePropertyName("ExtractDocId");
                context.Writer.WriteStringValue(requestObject.ExtractDocId);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetNestingLevel())
            {
                context.Writer.WritePropertyName("NestingLevel");
                context.Writer.WriteStringValue(requestObject.NestingLevel);
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

            if(requestObject.IsSetReplicateShardCollections())
            {
                context.Writer.WritePropertyName("ReplicateShardCollections");
                context.Writer.WriteBooleanValue(requestObject.ReplicateShardCollections.Value);
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

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.WriteStringValue(requestObject.Username);
            }

            if(requestObject.IsSetUseUpdateLookUp())
            {
                context.Writer.WritePropertyName("UseUpdateLookUp");
                context.Writer.WriteBooleanValue(requestObject.UseUpdateLookUp.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MongoDbSettingsMarshaller Instance = new MongoDbSettingsMarshaller();

    }
}