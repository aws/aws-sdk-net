/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// HistoryEventUnmarshaller
      /// </summary>
      internal class HistoryEventUnmarshaller : IUnmarshaller<HistoryEvent, XmlUnmarshallerContext>, IUnmarshaller<HistoryEvent, JsonUnmarshallerContext>
      {
        HistoryEvent IUnmarshaller<HistoryEvent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public HistoryEvent Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            HistoryEvent historyEvent = new HistoryEvent();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("eventTimestamp", targetDepth))
              {
                historyEvent.EventTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("eventType", targetDepth))
              {
                historyEvent.EventType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("eventId", targetDepth))
              {
                historyEvent.EventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionStartedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionStartedEventAttributes = WorkflowExecutionStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionCompletedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionCompletedEventAttributes = WorkflowExecutionCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("completeWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.CompleteWorkflowExecutionFailedEventAttributes = CompleteWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionFailedEventAttributes = WorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("failWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.FailWorkflowExecutionFailedEventAttributes = FailWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionTimedOutEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionTimedOutEventAttributes = WorkflowExecutionTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionCanceledEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionCanceledEventAttributes = WorkflowExecutionCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("cancelWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.CancelWorkflowExecutionFailedEventAttributes = CancelWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionContinuedAsNewEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionContinuedAsNewEventAttributes = WorkflowExecutionContinuedAsNewEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("continueAsNewWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.ContinueAsNewWorkflowExecutionFailedEventAttributes = ContinueAsNewWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionTerminatedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionTerminatedEventAttributes = WorkflowExecutionTerminatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionCancelRequestedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionCancelRequestedEventAttributes = WorkflowExecutionCancelRequestedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskScheduledEventAttributes", targetDepth))
              {
                historyEvent.DecisionTaskScheduledEventAttributes = DecisionTaskScheduledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskStartedEventAttributes", targetDepth))
              {
                historyEvent.DecisionTaskStartedEventAttributes = DecisionTaskStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventAttributes", targetDepth))
              {
                historyEvent.DecisionTaskCompletedEventAttributes = DecisionTaskCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskTimedOutEventAttributes", targetDepth))
              {
                historyEvent.DecisionTaskTimedOutEventAttributes = DecisionTaskTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskScheduledEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskScheduledEventAttributes = ActivityTaskScheduledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskStartedEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskStartedEventAttributes = ActivityTaskStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskCompletedEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskCompletedEventAttributes = ActivityTaskCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskFailedEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskFailedEventAttributes = ActivityTaskFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskTimedOutEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskTimedOutEventAttributes = ActivityTaskTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskCanceledEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskCanceledEventAttributes = ActivityTaskCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskCancelRequestedEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskCancelRequestedEventAttributes = ActivityTaskCancelRequestedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionSignaledEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionSignaledEventAttributes = WorkflowExecutionSignaledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("markerRecordedEventAttributes", targetDepth))
              {
                historyEvent.MarkerRecordedEventAttributes = MarkerRecordedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("recordMarkerFailedEventAttributes", targetDepth))
              {
                historyEvent.RecordMarkerFailedEventAttributes = RecordMarkerFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timerStartedEventAttributes", targetDepth))
              {
                historyEvent.TimerStartedEventAttributes = TimerStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timerFiredEventAttributes", targetDepth))
              {
                historyEvent.TimerFiredEventAttributes = TimerFiredEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timerCanceledEventAttributes", targetDepth))
              {
                historyEvent.TimerCanceledEventAttributes = TimerCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startChildWorkflowExecutionInitiatedEventAttributes", targetDepth))
              {
                historyEvent.StartChildWorkflowExecutionInitiatedEventAttributes = StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionStartedEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionStartedEventAttributes = ChildWorkflowExecutionStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionCompletedEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionCompletedEventAttributes = ChildWorkflowExecutionCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionFailedEventAttributes = ChildWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionTimedOutEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionTimedOutEventAttributes = ChildWorkflowExecutionTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionCanceledEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionCanceledEventAttributes = ChildWorkflowExecutionCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionTerminatedEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionTerminatedEventAttributes = ChildWorkflowExecutionTerminatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("signalExternalWorkflowExecutionInitiatedEventAttributes", targetDepth))
              {
                historyEvent.SignalExternalWorkflowExecutionInitiatedEventAttributes = SignalExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("externalWorkflowExecutionSignaledEventAttributes", targetDepth))
              {
                historyEvent.ExternalWorkflowExecutionSignaledEventAttributes = ExternalWorkflowExecutionSignaledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("signalExternalWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.SignalExternalWorkflowExecutionFailedEventAttributes = SignalExternalWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("externalWorkflowExecutionCancelRequestedEventAttributes", targetDepth))
              {
                historyEvent.ExternalWorkflowExecutionCancelRequestedEventAttributes = ExternalWorkflowExecutionCancelRequestedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("requestCancelExternalWorkflowExecutionInitiatedEventAttributes", targetDepth))
              {
                historyEvent.RequestCancelExternalWorkflowExecutionInitiatedEventAttributes = RequestCancelExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("requestCancelExternalWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.RequestCancelExternalWorkflowExecutionFailedEventAttributes = RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("scheduleActivityTaskFailedEventAttributes", targetDepth))
              {
                historyEvent.ScheduleActivityTaskFailedEventAttributes = ScheduleActivityTaskFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("requestCancelActivityTaskFailedEventAttributes", targetDepth))
              {
                historyEvent.RequestCancelActivityTaskFailedEventAttributes = RequestCancelActivityTaskFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startTimerFailedEventAttributes", targetDepth))
              {
                historyEvent.StartTimerFailedEventAttributes = StartTimerFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("cancelTimerFailedEventAttributes", targetDepth))
              {
                historyEvent.CancelTimerFailedEventAttributes = CancelTimerFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startChildWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.StartChildWorkflowExecutionFailedEventAttributes = StartChildWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return historyEvent;
        }

        private static HistoryEventUnmarshaller instance;
        public static HistoryEventUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new HistoryEventUnmarshaller();
            return instance;
        }
    }
}
  
