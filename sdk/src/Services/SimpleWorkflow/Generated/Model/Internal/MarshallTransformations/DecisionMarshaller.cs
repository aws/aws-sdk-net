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
    /// Decision Marshaller
    /// </summary>
    public class DecisionMarshaller : IRequestMarshaller<Decision, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Decision requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCancelTimerDecisionAttributes())
            {
                context.Writer.WritePropertyName("cancelTimerDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = CancelTimerDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.CancelTimerDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCancelWorkflowExecutionDecisionAttributes())
            {
                context.Writer.WritePropertyName("cancelWorkflowExecutionDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = CancelWorkflowExecutionDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.CancelWorkflowExecutionDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCompleteWorkflowExecutionDecisionAttributes())
            {
                context.Writer.WritePropertyName("completeWorkflowExecutionDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = CompleteWorkflowExecutionDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.CompleteWorkflowExecutionDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContinueAsNewWorkflowExecutionDecisionAttributes())
            {
                context.Writer.WritePropertyName("continueAsNewWorkflowExecutionDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = ContinueAsNewWorkflowExecutionDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.ContinueAsNewWorkflowExecutionDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDecisionType())
            {
                context.Writer.WritePropertyName("decisionType");
                context.Writer.WriteStringValue(requestObject.DecisionType);
            }

            if(requestObject.IsSetFailWorkflowExecutionDecisionAttributes())
            {
                context.Writer.WritePropertyName("failWorkflowExecutionDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = FailWorkflowExecutionDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.FailWorkflowExecutionDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecordMarkerDecisionAttributes())
            {
                context.Writer.WritePropertyName("recordMarkerDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = RecordMarkerDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.RecordMarkerDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequestCancelActivityTaskDecisionAttributes())
            {
                context.Writer.WritePropertyName("requestCancelActivityTaskDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = RequestCancelActivityTaskDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.RequestCancelActivityTaskDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequestCancelExternalWorkflowExecutionDecisionAttributes())
            {
                context.Writer.WritePropertyName("requestCancelExternalWorkflowExecutionDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = RequestCancelExternalWorkflowExecutionDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.RequestCancelExternalWorkflowExecutionDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScheduleActivityTaskDecisionAttributes())
            {
                context.Writer.WritePropertyName("scheduleActivityTaskDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleActivityTaskDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.ScheduleActivityTaskDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScheduleLambdaFunctionDecisionAttributes())
            {
                context.Writer.WritePropertyName("scheduleLambdaFunctionDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleLambdaFunctionDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.ScheduleLambdaFunctionDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSignalExternalWorkflowExecutionDecisionAttributes())
            {
                context.Writer.WritePropertyName("signalExternalWorkflowExecutionDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = SignalExternalWorkflowExecutionDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.SignalExternalWorkflowExecutionDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStartChildWorkflowExecutionDecisionAttributes())
            {
                context.Writer.WritePropertyName("startChildWorkflowExecutionDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = StartChildWorkflowExecutionDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.StartChildWorkflowExecutionDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStartTimerDecisionAttributes())
            {
                context.Writer.WritePropertyName("startTimerDecisionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = StartTimerDecisionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.StartTimerDecisionAttributes, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DecisionMarshaller Instance = new DecisionMarshaller();

    }
}