/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            HistoryEvent historyEvent = new HistoryEvent();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("eventTimestamp", targetDepth))
              {
                context.Read();
                historyEvent.EventTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("eventType", targetDepth))
              {
                context.Read();
                historyEvent.EventType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("eventId", targetDepth))
              {
                context.Read();
                historyEvent.EventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionStartedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.WorkflowExecutionStartedEventAttributes = WorkflowExecutionStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionCompletedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.WorkflowExecutionCompletedEventAttributes = WorkflowExecutionCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("completeWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.CompleteWorkflowExecutionFailedEventAttributes = CompleteWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.WorkflowExecutionFailedEventAttributes = WorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("failWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.FailWorkflowExecutionFailedEventAttributes = FailWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionTimedOutEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.WorkflowExecutionTimedOutEventAttributes = WorkflowExecutionTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionCanceledEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.WorkflowExecutionCanceledEventAttributes = WorkflowExecutionCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("cancelWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.CancelWorkflowExecutionFailedEventAttributes = CancelWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionContinuedAsNewEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.WorkflowExecutionContinuedAsNewEventAttributes = WorkflowExecutionContinuedAsNewEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("continueAsNewWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ContinueAsNewWorkflowExecutionFailedEventAttributes = ContinueAsNewWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionTerminatedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.WorkflowExecutionTerminatedEventAttributes = WorkflowExecutionTerminatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionCancelRequestedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.WorkflowExecutionCancelRequestedEventAttributes = WorkflowExecutionCancelRequestedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskScheduledEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.DecisionTaskScheduledEventAttributes = DecisionTaskScheduledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskStartedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.DecisionTaskStartedEventAttributes = DecisionTaskStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.DecisionTaskCompletedEventAttributes = DecisionTaskCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskTimedOutEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.DecisionTaskTimedOutEventAttributes = DecisionTaskTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskScheduledEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ActivityTaskScheduledEventAttributes = ActivityTaskScheduledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskStartedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ActivityTaskStartedEventAttributes = ActivityTaskStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskCompletedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ActivityTaskCompletedEventAttributes = ActivityTaskCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ActivityTaskFailedEventAttributes = ActivityTaskFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskTimedOutEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ActivityTaskTimedOutEventAttributes = ActivityTaskTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskCanceledEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ActivityTaskCanceledEventAttributes = ActivityTaskCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("activityTaskCancelRequestedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ActivityTaskCancelRequestedEventAttributes = ActivityTaskCancelRequestedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("workflowExecutionSignaledEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.WorkflowExecutionSignaledEventAttributes = WorkflowExecutionSignaledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("markerRecordedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.MarkerRecordedEventAttributes = MarkerRecordedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("recordMarkerFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.RecordMarkerFailedEventAttributes = RecordMarkerFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timerStartedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.TimerStartedEventAttributes = TimerStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timerFiredEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.TimerFiredEventAttributes = TimerFiredEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timerCanceledEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.TimerCanceledEventAttributes = TimerCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startChildWorkflowExecutionInitiatedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.StartChildWorkflowExecutionInitiatedEventAttributes = StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionStartedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ChildWorkflowExecutionStartedEventAttributes = ChildWorkflowExecutionStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionCompletedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ChildWorkflowExecutionCompletedEventAttributes = ChildWorkflowExecutionCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ChildWorkflowExecutionFailedEventAttributes = ChildWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionTimedOutEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ChildWorkflowExecutionTimedOutEventAttributes = ChildWorkflowExecutionTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionCanceledEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ChildWorkflowExecutionCanceledEventAttributes = ChildWorkflowExecutionCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childWorkflowExecutionTerminatedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ChildWorkflowExecutionTerminatedEventAttributes = ChildWorkflowExecutionTerminatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("signalExternalWorkflowExecutionInitiatedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.SignalExternalWorkflowExecutionInitiatedEventAttributes = SignalExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("externalWorkflowExecutionSignaledEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ExternalWorkflowExecutionSignaledEventAttributes = ExternalWorkflowExecutionSignaledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("signalExternalWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.SignalExternalWorkflowExecutionFailedEventAttributes = SignalExternalWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("externalWorkflowExecutionCancelRequestedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ExternalWorkflowExecutionCancelRequestedEventAttributes = ExternalWorkflowExecutionCancelRequestedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("requestCancelExternalWorkflowExecutionInitiatedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.RequestCancelExternalWorkflowExecutionInitiatedEventAttributes = RequestCancelExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("requestCancelExternalWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.RequestCancelExternalWorkflowExecutionFailedEventAttributes = RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("scheduleActivityTaskFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.ScheduleActivityTaskFailedEventAttributes = ScheduleActivityTaskFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("requestCancelActivityTaskFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.RequestCancelActivityTaskFailedEventAttributes = RequestCancelActivityTaskFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startTimerFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.StartTimerFailedEventAttributes = StartTimerFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("cancelTimerFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.CancelTimerFailedEventAttributes = CancelTimerFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("startChildWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                context.Read();
                historyEvent.StartChildWorkflowExecutionFailedEventAttributes = StartChildWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return historyEvent;
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
  
