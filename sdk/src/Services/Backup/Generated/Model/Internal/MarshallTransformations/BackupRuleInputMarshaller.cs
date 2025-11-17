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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BackupRuleInput Marshaller
    /// </summary>
    public class BackupRuleInputMarshaller : IRequestMarshaller<BackupRuleInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BackupRuleInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCompletionWindowMinutes())
            {
                context.Writer.WritePropertyName("CompletionWindowMinutes");
                context.Writer.Write(requestObject.CompletionWindowMinutes);
            }

            if(requestObject.IsSetCopyActions())
            {
                context.Writer.WritePropertyName("CopyActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCopyActionsListValue in requestObject.CopyActions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CopyActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectCopyActionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnableContinuousBackup())
            {
                context.Writer.WritePropertyName("EnableContinuousBackup");
                context.Writer.Write(requestObject.EnableContinuousBackup);
            }

            if(requestObject.IsSetIndexActions())
            {
                context.Writer.WritePropertyName("IndexActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIndexActionsListValue in requestObject.IndexActions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IndexActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectIndexActionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLifecycle())
            {
                context.Writer.WritePropertyName("Lifecycle");
                context.Writer.WriteObjectStart();

                var marshaller = LifecycleMarshaller.Instance;
                marshaller.Marshall(requestObject.Lifecycle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRecoveryPointTags())
            {
                context.Writer.WritePropertyName("RecoveryPointTags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectRecoveryPointTagsKvp in requestObject.RecoveryPointTags)
                {
                    context.Writer.WritePropertyName(requestObjectRecoveryPointTagsKvp.Key);
                    var requestObjectRecoveryPointTagsValue = requestObjectRecoveryPointTagsKvp.Value;

                        context.Writer.Write(requestObjectRecoveryPointTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRuleName())
            {
                context.Writer.WritePropertyName("RuleName");
                context.Writer.Write(requestObject.RuleName);
            }

            if(requestObject.IsSetScheduleExpression())
            {
                context.Writer.WritePropertyName("ScheduleExpression");
                context.Writer.Write(requestObject.ScheduleExpression);
            }

            if(requestObject.IsSetScheduleExpressionTimezone())
            {
                context.Writer.WritePropertyName("ScheduleExpressionTimezone");
                context.Writer.Write(requestObject.ScheduleExpressionTimezone);
            }

            if(requestObject.IsSetStartWindowMinutes())
            {
                context.Writer.WritePropertyName("StartWindowMinutes");
                context.Writer.Write(requestObject.StartWindowMinutes);
            }

            if(requestObject.IsSetTargetBackupVaultName())
            {
                context.Writer.WritePropertyName("TargetBackupVaultName");
                context.Writer.Write(requestObject.TargetBackupVaultName);
            }

            if(requestObject.IsSetTargetLogicallyAirGappedBackupVaultArn())
            {
                context.Writer.WritePropertyName("TargetLogicallyAirGappedBackupVaultArn");
                context.Writer.Write(requestObject.TargetLogicallyAirGappedBackupVaultArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BackupRuleInputMarshaller Instance = new BackupRuleInputMarshaller();

    }
}