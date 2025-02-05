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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContinueAsNewWorkflowExecutionDecisionAttributes Marshaller
    /// </summary>
    public class ContinueAsNewWorkflowExecutionDecisionAttributesMarshaller : IRequestMarshaller<ContinueAsNewWorkflowExecutionDecisionAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContinueAsNewWorkflowExecutionDecisionAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChildPolicy())
            {
                context.Writer.WritePropertyName("childPolicy");
                context.Writer.WriteStringValue(requestObject.ChildPolicy);
            }

            if(requestObject.IsSetExecutionStartToCloseTimeout())
            {
                context.Writer.WritePropertyName("executionStartToCloseTimeout");
                context.Writer.WriteStringValue(requestObject.ExecutionStartToCloseTimeout);
            }

            if(requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.WriteStringValue(requestObject.Input);
            }

            if(requestObject.IsSetLambdaRole())
            {
                context.Writer.WritePropertyName("lambdaRole");
                context.Writer.WriteStringValue(requestObject.LambdaRole);
            }

            if(requestObject.IsSetTagList())
            {
                context.Writer.WritePropertyName("tagList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagListListValue in requestObject.TagList)
                {
                        context.Writer.WriteStringValue(requestObjectTagListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTaskList())
            {
                context.Writer.WritePropertyName("taskList");
                context.Writer.WriteStartObject();

                var marshaller = TaskListMarshaller.Instance;
                marshaller.Marshall(requestObject.TaskList, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTaskPriority())
            {
                context.Writer.WritePropertyName("taskPriority");
                context.Writer.WriteStringValue(requestObject.TaskPriority);
            }

            if(requestObject.IsSetTaskStartToCloseTimeout())
            {
                context.Writer.WritePropertyName("taskStartToCloseTimeout");
                context.Writer.WriteStringValue(requestObject.TaskStartToCloseTimeout);
            }

            if(requestObject.IsSetWorkflowTypeVersion())
            {
                context.Writer.WritePropertyName("workflowTypeVersion");
                context.Writer.WriteStringValue(requestObject.WorkflowTypeVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContinueAsNewWorkflowExecutionDecisionAttributesMarshaller Instance = new ContinueAsNewWorkflowExecutionDecisionAttributesMarshaller();

    }
}