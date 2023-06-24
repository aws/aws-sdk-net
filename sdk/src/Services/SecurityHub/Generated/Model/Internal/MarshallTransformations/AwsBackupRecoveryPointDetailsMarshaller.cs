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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsBackupRecoveryPointDetails Marshaller
    /// </summary>
    public class AwsBackupRecoveryPointDetailsMarshaller : IRequestMarshaller<AwsBackupRecoveryPointDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsBackupRecoveryPointDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBackupSizeInBytes())
            {
                context.Writer.WritePropertyName("BackupSizeInBytes");
                context.Writer.Write(requestObject.BackupSizeInBytes);
            }

            if(requestObject.IsSetBackupVaultArn())
            {
                context.Writer.WritePropertyName("BackupVaultArn");
                context.Writer.Write(requestObject.BackupVaultArn);
            }

            if(requestObject.IsSetBackupVaultName())
            {
                context.Writer.WritePropertyName("BackupVaultName");
                context.Writer.Write(requestObject.BackupVaultName);
            }

            if(requestObject.IsSetCalculatedLifecycle())
            {
                context.Writer.WritePropertyName("CalculatedLifecycle");
                context.Writer.WriteObjectStart();

                var marshaller = AwsBackupRecoveryPointCalculatedLifecycleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CalculatedLifecycle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCompletionDate())
            {
                context.Writer.WritePropertyName("CompletionDate");
                context.Writer.Write(requestObject.CompletionDate);
            }

            if(requestObject.IsSetCreatedBy())
            {
                context.Writer.WritePropertyName("CreatedBy");
                context.Writer.WriteObjectStart();

                var marshaller = AwsBackupRecoveryPointCreatedByDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CreatedBy, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreationDate())
            {
                context.Writer.WritePropertyName("CreationDate");
                context.Writer.Write(requestObject.CreationDate);
            }

            if(requestObject.IsSetEncryptionKeyArn())
            {
                context.Writer.WritePropertyName("EncryptionKeyArn");
                context.Writer.Write(requestObject.EncryptionKeyArn);
            }

            if(requestObject.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("IamRoleArn");
                context.Writer.Write(requestObject.IamRoleArn);
            }

            if(requestObject.IsSetIsEncrypted())
            {
                context.Writer.WritePropertyName("IsEncrypted");
                context.Writer.Write(requestObject.IsEncrypted);
            }

            if(requestObject.IsSetLastRestoreTime())
            {
                context.Writer.WritePropertyName("LastRestoreTime");
                context.Writer.Write(requestObject.LastRestoreTime);
            }

            if(requestObject.IsSetLifecycle())
            {
                context.Writer.WritePropertyName("Lifecycle");
                context.Writer.WriteObjectStart();

                var marshaller = AwsBackupRecoveryPointLifecycleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Lifecycle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRecoveryPointArn())
            {
                context.Writer.WritePropertyName("RecoveryPointArn");
                context.Writer.Write(requestObject.RecoveryPointArn);
            }

            if(requestObject.IsSetResourceArn())
            {
                context.Writer.WritePropertyName("ResourceArn");
                context.Writer.Write(requestObject.ResourceArn);
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.Write(requestObject.ResourceType);
            }

            if(requestObject.IsSetSourceBackupVaultArn())
            {
                context.Writer.WritePropertyName("SourceBackupVaultArn");
                context.Writer.Write(requestObject.SourceBackupVaultArn);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetStatusMessage())
            {
                context.Writer.WritePropertyName("StatusMessage");
                context.Writer.Write(requestObject.StatusMessage);
            }

            if(requestObject.IsSetStorageClass())
            {
                context.Writer.WritePropertyName("StorageClass");
                context.Writer.Write(requestObject.StorageClass);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsBackupRecoveryPointDetailsMarshaller Instance = new AwsBackupRecoveryPointDetailsMarshaller();

    }
}