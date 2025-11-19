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
                context.Writer.WriteNumberValue(requestObject.CompletionWindowMinutes.Value);
            }

            if(requestObject.IsSetCopyActions())
            {
                context.Writer.WritePropertyName("CopyActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCopyActionsListValue in requestObject.CopyActions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CopyActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectCopyActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnableContinuousBackup())
            {
                context.Writer.WritePropertyName("EnableContinuousBackup");
                context.Writer.WriteBooleanValue(requestObject.EnableContinuousBackup.Value);
            }

            if(requestObject.IsSetIndexActions())
            {
                context.Writer.WritePropertyName("IndexActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIndexActionsListValue in requestObject.IndexActions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IndexActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectIndexActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLifecycle())
            {
                context.Writer.WritePropertyName("Lifecycle");
                context.Writer.WriteStartObject();

                var marshaller = LifecycleMarshaller.Instance;
                marshaller.Marshall(requestObject.Lifecycle, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecoveryPointTags())
            {
                context.Writer.WritePropertyName("RecoveryPointTags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectRecoveryPointTagsKvp in requestObject.RecoveryPointTags)
                {
                    context.Writer.WritePropertyName(requestObjectRecoveryPointTagsKvp.Key);
                    var requestObjectRecoveryPointTagsValue = requestObjectRecoveryPointTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectRecoveryPointTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRuleName())
            {
                context.Writer.WritePropertyName("RuleName");
                context.Writer.WriteStringValue(requestObject.RuleName);
            }

            if(requestObject.IsSetScanActions())
            {
                context.Writer.WritePropertyName("ScanActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanActionsListValue in requestObject.ScanActions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ScanActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScheduleExpression())
            {
                context.Writer.WritePropertyName("ScheduleExpression");
                context.Writer.WriteStringValue(requestObject.ScheduleExpression);
            }

            if(requestObject.IsSetScheduleExpressionTimezone())
            {
                context.Writer.WritePropertyName("ScheduleExpressionTimezone");
                context.Writer.WriteStringValue(requestObject.ScheduleExpressionTimezone);
            }

            if(requestObject.IsSetStartWindowMinutes())
            {
                context.Writer.WritePropertyName("StartWindowMinutes");
                context.Writer.WriteNumberValue(requestObject.StartWindowMinutes.Value);
            }

            if(requestObject.IsSetTargetBackupVaultName())
            {
                context.Writer.WritePropertyName("TargetBackupVaultName");
                context.Writer.WriteStringValue(requestObject.TargetBackupVaultName);
            }

            if(requestObject.IsSetTargetLogicallyAirGappedBackupVaultArn())
            {
                context.Writer.WritePropertyName("TargetLogicallyAirGappedBackupVaultArn");
                context.Writer.WriteStringValue(requestObject.TargetLogicallyAirGappedBackupVaultArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BackupRuleInputMarshaller Instance = new BackupRuleInputMarshaller();

    }
}