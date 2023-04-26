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
    /// RedshiftSettings Marshaller
    /// </summary>
    public class RedshiftSettingsMarshaller : IRequestMarshaller<RedshiftSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAcceptAnyDate())
            {
                context.Writer.WritePropertyName("AcceptAnyDate");
                context.Writer.Write(requestObject.AcceptAnyDate);
            }

            if(requestObject.IsSetAfterConnectScript())
            {
                context.Writer.WritePropertyName("AfterConnectScript");
                context.Writer.Write(requestObject.AfterConnectScript);
            }

            if(requestObject.IsSetBucketFolder())
            {
                context.Writer.WritePropertyName("BucketFolder");
                context.Writer.Write(requestObject.BucketFolder);
            }

            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("BucketName");
                context.Writer.Write(requestObject.BucketName);
            }

            if(requestObject.IsSetCaseSensitiveNames())
            {
                context.Writer.WritePropertyName("CaseSensitiveNames");
                context.Writer.Write(requestObject.CaseSensitiveNames);
            }

            if(requestObject.IsSetCompUpdate())
            {
                context.Writer.WritePropertyName("CompUpdate");
                context.Writer.Write(requestObject.CompUpdate);
            }

            if(requestObject.IsSetConnectionTimeout())
            {
                context.Writer.WritePropertyName("ConnectionTimeout");
                context.Writer.Write(requestObject.ConnectionTimeout);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDateFormat())
            {
                context.Writer.WritePropertyName("DateFormat");
                context.Writer.Write(requestObject.DateFormat);
            }

            if(requestObject.IsSetEmptyAsNull())
            {
                context.Writer.WritePropertyName("EmptyAsNull");
                context.Writer.Write(requestObject.EmptyAsNull);
            }

            if(requestObject.IsSetEncryptionMode())
            {
                context.Writer.WritePropertyName("EncryptionMode");
                context.Writer.Write(requestObject.EncryptionMode);
            }

            if(requestObject.IsSetExplicitIds())
            {
                context.Writer.WritePropertyName("ExplicitIds");
                context.Writer.Write(requestObject.ExplicitIds);
            }

            if(requestObject.IsSetFileTransferUploadStreams())
            {
                context.Writer.WritePropertyName("FileTransferUploadStreams");
                context.Writer.Write(requestObject.FileTransferUploadStreams);
            }

            if(requestObject.IsSetLoadTimeout())
            {
                context.Writer.WritePropertyName("LoadTimeout");
                context.Writer.Write(requestObject.LoadTimeout);
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

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.Write(requestObject.Port);
            }

            if(requestObject.IsSetRemoveQuotes())
            {
                context.Writer.WritePropertyName("RemoveQuotes");
                context.Writer.Write(requestObject.RemoveQuotes);
            }

            if(requestObject.IsSetReplaceChars())
            {
                context.Writer.WritePropertyName("ReplaceChars");
                context.Writer.Write(requestObject.ReplaceChars);
            }

            if(requestObject.IsSetReplaceInvalidChars())
            {
                context.Writer.WritePropertyName("ReplaceInvalidChars");
                context.Writer.Write(requestObject.ReplaceInvalidChars);
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

            if(requestObject.IsSetServerSideEncryptionKmsKeyId())
            {
                context.Writer.WritePropertyName("ServerSideEncryptionKmsKeyId");
                context.Writer.Write(requestObject.ServerSideEncryptionKmsKeyId);
            }

            if(requestObject.IsSetServiceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ServiceAccessRoleArn");
                context.Writer.Write(requestObject.ServiceAccessRoleArn);
            }

            if(requestObject.IsSetTimeFormat())
            {
                context.Writer.WritePropertyName("TimeFormat");
                context.Writer.Write(requestObject.TimeFormat);
            }

            if(requestObject.IsSetTrimBlanks())
            {
                context.Writer.WritePropertyName("TrimBlanks");
                context.Writer.Write(requestObject.TrimBlanks);
            }

            if(requestObject.IsSetTruncateColumns())
            {
                context.Writer.WritePropertyName("TruncateColumns");
                context.Writer.Write(requestObject.TruncateColumns);
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.Write(requestObject.Username);
            }

            if(requestObject.IsSetWriteBufferSize())
            {
                context.Writer.WritePropertyName("WriteBufferSize");
                context.Writer.Write(requestObject.WriteBufferSize);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RedshiftSettingsMarshaller Instance = new RedshiftSettingsMarshaller();

    }
}