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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubOrchestrator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHubOrchestrator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkflowStepAutomationConfiguration Marshaller
    /// </summary>
    public class WorkflowStepAutomationConfigurationMarshaller : IRequestMarshaller<WorkflowStepAutomationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WorkflowStepAutomationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteStartObject();

                var marshaller = PlatformCommandMarshaller.Instance;
                marshaller.Marshall(requestObject.Command, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRunEnvironment())
            {
                context.Writer.WritePropertyName("runEnvironment");
                context.Writer.WriteStringValue(requestObject.RunEnvironment);
            }

            if(requestObject.IsSetScriptLocationS3Bucket())
            {
                context.Writer.WritePropertyName("scriptLocationS3Bucket");
                context.Writer.WriteStringValue(requestObject.ScriptLocationS3Bucket);
            }

            if(requestObject.IsSetScriptLocationS3Key())
            {
                context.Writer.WritePropertyName("scriptLocationS3Key");
                context.Writer.WriteStartObject();

                var marshaller = PlatformScriptKeyMarshaller.Instance;
                marshaller.Marshall(requestObject.ScriptLocationS3Key, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTargetType())
            {
                context.Writer.WritePropertyName("targetType");
                context.Writer.WriteStringValue(requestObject.TargetType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkflowStepAutomationConfigurationMarshaller Instance = new WorkflowStepAutomationConfigurationMarshaller();

    }
}