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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcceptAnyDate())
            {
                context.Writer.WritePropertyName("AcceptAnyDate");
                context.Writer.WriteBooleanValue(requestObject.AcceptAnyDate.Value);
            }

            if(requestObject.IsSetAfterConnectScript())
            {
                context.Writer.WritePropertyName("AfterConnectScript");
                context.Writer.WriteStringValue(requestObject.AfterConnectScript);
            }

            if(requestObject.IsSetBucketFolder())
            {
                context.Writer.WritePropertyName("BucketFolder");
                context.Writer.WriteStringValue(requestObject.BucketFolder);
            }

            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("BucketName");
                context.Writer.WriteStringValue(requestObject.BucketName);
            }

            if(requestObject.IsSetCaseSensitiveNames())
            {
                context.Writer.WritePropertyName("CaseSensitiveNames");
                context.Writer.WriteBooleanValue(requestObject.CaseSensitiveNames.Value);
            }

            if(requestObject.IsSetCompUpdate())
            {
                context.Writer.WritePropertyName("CompUpdate");
                context.Writer.WriteBooleanValue(requestObject.CompUpdate.Value);
            }

            if(requestObject.IsSetConnectionTimeout())
            {
                context.Writer.WritePropertyName("ConnectionTimeout");
                context.Writer.WriteNumberValue(requestObject.ConnectionTimeout.Value);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDateFormat())
            {
                context.Writer.WritePropertyName("DateFormat");
                context.Writer.WriteStringValue(requestObject.DateFormat);
            }

            if(requestObject.IsSetEmptyAsNull())
            {
                context.Writer.WritePropertyName("EmptyAsNull");
                context.Writer.WriteBooleanValue(requestObject.EmptyAsNull.Value);
            }

            if(requestObject.IsSetEncryptionMode())
            {
                context.Writer.WritePropertyName("EncryptionMode");
                context.Writer.WriteStringValue(requestObject.EncryptionMode);
            }

            if(requestObject.IsSetExplicitIds())
            {
                context.Writer.WritePropertyName("ExplicitIds");
                context.Writer.WriteBooleanValue(requestObject.ExplicitIds.Value);
            }

            if(requestObject.IsSetFileTransferUploadStreams())
            {
                context.Writer.WritePropertyName("FileTransferUploadStreams");
                context.Writer.WriteNumberValue(requestObject.FileTransferUploadStreams.Value);
            }

            if(requestObject.IsSetLoadTimeout())
            {
                context.Writer.WritePropertyName("LoadTimeout");
                context.Writer.WriteNumberValue(requestObject.LoadTimeout.Value);
            }

            if(requestObject.IsSetMapBooleanAsBoolean())
            {
                context.Writer.WritePropertyName("MapBooleanAsBoolean");
                context.Writer.WriteBooleanValue(requestObject.MapBooleanAsBoolean.Value);
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

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetRemoveQuotes())
            {
                context.Writer.WritePropertyName("RemoveQuotes");
                context.Writer.WriteBooleanValue(requestObject.RemoveQuotes.Value);
            }

            if(requestObject.IsSetReplaceChars())
            {
                context.Writer.WritePropertyName("ReplaceChars");
                context.Writer.WriteStringValue(requestObject.ReplaceChars);
            }

            if(requestObject.IsSetReplaceInvalidChars())
            {
                context.Writer.WritePropertyName("ReplaceInvalidChars");
                context.Writer.WriteStringValue(requestObject.ReplaceInvalidChars);
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

            if(requestObject.IsSetServerSideEncryptionKmsKeyId())
            {
                context.Writer.WritePropertyName("ServerSideEncryptionKmsKeyId");
                context.Writer.WriteStringValue(requestObject.ServerSideEncryptionKmsKeyId);
            }

            if(requestObject.IsSetServiceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ServiceAccessRoleArn");
                context.Writer.WriteStringValue(requestObject.ServiceAccessRoleArn);
            }

            if(requestObject.IsSetTimeFormat())
            {
                context.Writer.WritePropertyName("TimeFormat");
                context.Writer.WriteStringValue(requestObject.TimeFormat);
            }

            if(requestObject.IsSetTrimBlanks())
            {
                context.Writer.WritePropertyName("TrimBlanks");
                context.Writer.WriteBooleanValue(requestObject.TrimBlanks.Value);
            }

            if(requestObject.IsSetTruncateColumns())
            {
                context.Writer.WritePropertyName("TruncateColumns");
                context.Writer.WriteBooleanValue(requestObject.TruncateColumns.Value);
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
        public readonly static RedshiftSettingsMarshaller Instance = new RedshiftSettingsMarshaller();

    }
}