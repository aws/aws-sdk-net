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
            HistoryEvent historyEvent = new HistoryEvent();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("EventTimestamp", targetDepth))
              {
                historyEvent.EventTimestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EventType", targetDepth))
              {
                historyEvent.EventType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EventId", targetDepth))
              {
                historyEvent.EventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecutionStartedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionStartedEventAttributes = WorkflowExecutionStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecutionCompletedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionCompletedEventAttributes = WorkflowExecutionCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CompleteWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.CompleteWorkflowExecutionFailedEventAttributes = CompleteWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionFailedEventAttributes = WorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("FailWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.FailWorkflowExecutionFailedEventAttributes = FailWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecutionTimedOutEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionTimedOutEventAttributes = WorkflowExecutionTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecutionCanceledEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionCanceledEventAttributes = WorkflowExecutionCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CancelWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.CancelWorkflowExecutionFailedEventAttributes = CancelWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecutionContinuedAsNewEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionContinuedAsNewEventAttributes = WorkflowExecutionContinuedAsNewEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ContinueAsNewWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.ContinueAsNewWorkflowExecutionFailedEventAttributes = ContinueAsNewWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecutionTerminatedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionTerminatedEventAttributes = WorkflowExecutionTerminatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecutionCancelRequestedEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionCancelRequestedEventAttributes = WorkflowExecutionCancelRequestedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DecisionTaskScheduledEventAttributes", targetDepth))
              {
                historyEvent.DecisionTaskScheduledEventAttributes = DecisionTaskScheduledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DecisionTaskStartedEventAttributes", targetDepth))
              {
                historyEvent.DecisionTaskStartedEventAttributes = DecisionTaskStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DecisionTaskCompletedEventAttributes", targetDepth))
              {
                historyEvent.DecisionTaskCompletedEventAttributes = DecisionTaskCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DecisionTaskTimedOutEventAttributes", targetDepth))
              {
                historyEvent.DecisionTaskTimedOutEventAttributes = DecisionTaskTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ActivityTaskScheduledEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskScheduledEventAttributes = ActivityTaskScheduledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ActivityTaskStartedEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskStartedEventAttributes = ActivityTaskStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ActivityTaskCompletedEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskCompletedEventAttributes = ActivityTaskCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ActivityTaskFailedEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskFailedEventAttributes = ActivityTaskFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ActivityTaskTimedOutEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskTimedOutEventAttributes = ActivityTaskTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ActivityTaskCanceledEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskCanceledEventAttributes = ActivityTaskCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ActivityTaskCancelRequestedEventAttributes", targetDepth))
              {
                historyEvent.ActivityTaskCancelRequestedEventAttributes = ActivityTaskCancelRequestedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WorkflowExecutionSignaledEventAttributes", targetDepth))
              {
                historyEvent.WorkflowExecutionSignaledEventAttributes = WorkflowExecutionSignaledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("MarkerRecordedEventAttributes", targetDepth))
              {
                historyEvent.MarkerRecordedEventAttributes = MarkerRecordedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RecordMarkerFailedEventAttributes", targetDepth))
              {
                historyEvent.RecordMarkerFailedEventAttributes = RecordMarkerFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TimerStartedEventAttributes", targetDepth))
              {
                historyEvent.TimerStartedEventAttributes = TimerStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TimerFiredEventAttributes", targetDepth))
              {
                historyEvent.TimerFiredEventAttributes = TimerFiredEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TimerCanceledEventAttributes", targetDepth))
              {
                historyEvent.TimerCanceledEventAttributes = TimerCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartChildWorkflowExecutionInitiatedEventAttributes", targetDepth))
              {
                historyEvent.StartChildWorkflowExecutionInitiatedEventAttributes = StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ChildWorkflowExecutionStartedEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionStartedEventAttributes = ChildWorkflowExecutionStartedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ChildWorkflowExecutionCompletedEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionCompletedEventAttributes = ChildWorkflowExecutionCompletedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ChildWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionFailedEventAttributes = ChildWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ChildWorkflowExecutionTimedOutEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionTimedOutEventAttributes = ChildWorkflowExecutionTimedOutEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ChildWorkflowExecutionCanceledEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionCanceledEventAttributes = ChildWorkflowExecutionCanceledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ChildWorkflowExecutionTerminatedEventAttributes", targetDepth))
              {
                historyEvent.ChildWorkflowExecutionTerminatedEventAttributes = ChildWorkflowExecutionTerminatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SignalExternalWorkflowExecutionInitiatedEventAttributes", targetDepth))
              {
                historyEvent.SignalExternalWorkflowExecutionInitiatedEventAttributes = SignalExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ExternalWorkflowExecutionSignaledEventAttributes", targetDepth))
              {
                historyEvent.ExternalWorkflowExecutionSignaledEventAttributes = ExternalWorkflowExecutionSignaledEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SignalExternalWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.SignalExternalWorkflowExecutionFailedEventAttributes = SignalExternalWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ExternalWorkflowExecutionCancelRequestedEventAttributes", targetDepth))
              {
                historyEvent.ExternalWorkflowExecutionCancelRequestedEventAttributes = ExternalWorkflowExecutionCancelRequestedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RequestCancelExternalWorkflowExecutionInitiatedEventAttributes", targetDepth))
              {
                historyEvent.RequestCancelExternalWorkflowExecutionInitiatedEventAttributes = RequestCancelExternalWorkflowExecutionInitiatedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RequestCancelExternalWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.RequestCancelExternalWorkflowExecutionFailedEventAttributes = RequestCancelExternalWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ScheduleActivityTaskFailedEventAttributes", targetDepth))
              {
                historyEvent.ScheduleActivityTaskFailedEventAttributes = ScheduleActivityTaskFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RequestCancelActivityTaskFailedEventAttributes", targetDepth))
              {
                historyEvent.RequestCancelActivityTaskFailedEventAttributes = RequestCancelActivityTaskFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartTimerFailedEventAttributes", targetDepth))
              {
                historyEvent.StartTimerFailedEventAttributes = StartTimerFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CancelTimerFailedEventAttributes", targetDepth))
              {
                historyEvent.CancelTimerFailedEventAttributes = CancelTimerFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartChildWorkflowExecutionFailedEventAttributes", targetDepth))
              {
                historyEvent.StartChildWorkflowExecutionFailedEventAttributes = StartChildWorkflowExecutionFailedEventAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
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
  
