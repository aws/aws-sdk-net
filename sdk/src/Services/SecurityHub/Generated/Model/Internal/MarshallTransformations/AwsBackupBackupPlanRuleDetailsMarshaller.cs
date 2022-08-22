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
    /// AwsBackupBackupPlanRuleDetails Marshaller
    /// </summary>
    public class AwsBackupBackupPlanRuleDetailsMarshaller : IRequestMarshaller<AwsBackupBackupPlanRuleDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsBackupBackupPlanRuleDetails requestObject, JsonMarshallerContext context)
        {
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

                    var marshaller = AwsBackupBackupPlanRuleCopyActionsDetailsMarshaller.Instance;
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

            if(requestObject.IsSetLifecycle())
            {
                context.Writer.WritePropertyName("Lifecycle");
                context.Writer.WriteObjectStart();

                var marshaller = AwsBackupBackupPlanLifecycleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Lifecycle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRuleId())
            {
                context.Writer.WritePropertyName("RuleId");
                context.Writer.Write(requestObject.RuleId);
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

            if(requestObject.IsSetStartWindowMinutes())
            {
                context.Writer.WritePropertyName("StartWindowMinutes");
                context.Writer.Write(requestObject.StartWindowMinutes);
            }

            if(requestObject.IsSetTargetBackupVault())
            {
                context.Writer.WritePropertyName("TargetBackupVault");
                context.Writer.Write(requestObject.TargetBackupVault);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsBackupBackupPlanRuleDetailsMarshaller Instance = new AwsBackupBackupPlanRuleDetailsMarshaller();

    }
}