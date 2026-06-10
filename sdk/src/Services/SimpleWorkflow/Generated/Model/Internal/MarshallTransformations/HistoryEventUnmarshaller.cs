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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HistoryEvent Object
    /// </summary>  
    public class HistoryEventUnmarshaller : IJsonUnmarshaller<HistoryEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public HistoryEvent Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            HistoryEvent unmarshalledObject = new HistoryEvent();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("activityTaskCanceledEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ActivityTaskCanceledEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ActivityTaskCanceledEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityTaskCancelRequestedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ActivityTaskCancelRequestedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ActivityTaskCancelRequestedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityTaskCompletedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ActivityTaskCompletedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ActivityTaskCompletedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityTaskFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ActivityTaskFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ActivityTaskFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityTaskScheduledEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ActivityTaskScheduledEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ActivityTaskScheduledEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityTaskStartedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ActivityTaskStartedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ActivityTaskStartedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityTaskTimedOutEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ActivityTaskTimedOutEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ActivityTaskTimedOutEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cancelTimerFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = CancelTimerFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.CancelTimerFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cancelWorkflowExecutionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = CancelWorkflowExecutionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.CancelWorkflowExecutionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("childWorkflowExecutionCanceledEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ChildWorkflowExecutionCanceledEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ChildWorkflowExecutionCanceledEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("childWorkflowExecutionCompletedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ChildWorkflowExecutionCompletedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ChildWorkflowExecutionCompletedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("childWorkflowExecutionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ChildWorkflowExecutionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ChildWorkflowExecutionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("childWorkflowExecutionStartedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ChildWorkflowExecutionStartedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ChildWorkflowExecutionStartedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("childWorkflowExecutionTerminatedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ChildWorkflowExecutionTerminatedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ChildWorkflowExecutionTerminatedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("childWorkflowExecutionTimedOutEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ChildWorkflowExecutionTimedOutEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ChildWorkflowExecutionTimedOutEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("completeWorkflowExecutionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = CompleteWorkflowExecutionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.CompleteWorkflowExecutionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("continueAsNewWorkflowExecutionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ContinueAsNewWorkflowExecutionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ContinueAsNewWorkflowExecutionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("decisionTaskCompletedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = DecisionTaskCompletedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.DecisionTaskCompletedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("decisionTaskScheduledEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = DecisionTaskScheduledEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.DecisionTaskScheduledEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("decisionTaskStartedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = DecisionTaskStartedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.DecisionTaskStartedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("decisionTaskTimedOutEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = DecisionTaskTimedOutEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.DecisionTaskTimedOutEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eventId", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.EventId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eventTimestamp", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EventTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eventType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("externalWorkflowExecutionCancelRequestedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ExternalWorkflowExecutionCancelRequestedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ExternalWorkflowExecutionCancelRequestedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("externalWorkflowExecutionSignaledEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ExternalWorkflowExecutionSignaledEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ExternalWorkflowExecutionSignaledEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("failWorkflowExecutionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = FailWorkflowExecutionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.FailWorkflowExecutionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionCompletedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = LambdaFunctionCompletedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionCompletedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = LambdaFunctionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionScheduledEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = LambdaFunctionScheduledEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionScheduledEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionStartedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = LambdaFunctionStartedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionStartedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionTimedOutEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = LambdaFunctionTimedOutEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionTimedOutEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("markerRecordedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = MarkerRecordedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.MarkerRecordedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("recordMarkerFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = RecordMarkerFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.RecordMarkerFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("requestCancelActivityTaskFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = RequestCancelActivityTaskFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.RequestCancelActivityTaskFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("requestCancelExternalWorkflowExecutionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.RequestCancelExternalWorkflowExecutionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("requestCancelExternalWorkflowExecutionInitiatedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = RequestCancelExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.RequestCancelExternalWorkflowExecutionInitiatedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scheduleActivityTaskFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ScheduleActivityTaskFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ScheduleActivityTaskFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scheduleLambdaFunctionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = ScheduleLambdaFunctionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.ScheduleLambdaFunctionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("signalExternalWorkflowExecutionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = SignalExternalWorkflowExecutionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.SignalExternalWorkflowExecutionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("signalExternalWorkflowExecutionInitiatedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = SignalExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.SignalExternalWorkflowExecutionInitiatedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startChildWorkflowExecutionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = StartChildWorkflowExecutionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.StartChildWorkflowExecutionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startChildWorkflowExecutionInitiatedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.StartChildWorkflowExecutionInitiatedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startLambdaFunctionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = StartLambdaFunctionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.StartLambdaFunctionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("startTimerFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = StartTimerFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.StartTimerFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timerCanceledEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = TimerCanceledEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.TimerCanceledEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timerFiredEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = TimerFiredEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.TimerFiredEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timerStartedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = TimerStartedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.TimerStartedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workflowExecutionCanceledEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = WorkflowExecutionCanceledEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.WorkflowExecutionCanceledEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workflowExecutionCancelRequestedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = WorkflowExecutionCancelRequestedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.WorkflowExecutionCancelRequestedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workflowExecutionCompletedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = WorkflowExecutionCompletedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.WorkflowExecutionCompletedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workflowExecutionContinuedAsNewEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = WorkflowExecutionContinuedAsNewEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.WorkflowExecutionContinuedAsNewEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workflowExecutionFailedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = WorkflowExecutionFailedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.WorkflowExecutionFailedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workflowExecutionSignaledEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = WorkflowExecutionSignaledEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.WorkflowExecutionSignaledEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workflowExecutionStartedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = WorkflowExecutionStartedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.WorkflowExecutionStartedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workflowExecutionTerminatedEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = WorkflowExecutionTerminatedEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.WorkflowExecutionTerminatedEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workflowExecutionTimedOutEventAttributes", targetDepth, ref reader))
                {
                    var unmarshaller = WorkflowExecutionTimedOutEventAttributesUnmarshaller.Instance;
                    unmarshalledObject.WorkflowExecutionTimedOutEventAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static HistoryEventUnmarshaller _instance = new HistoryEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HistoryEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}