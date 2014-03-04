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
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Respond Decision Task Completed Request Marshaller
    /// </summary>       
    internal class RespondDecisionTaskCompletedRequestMarshaller : IMarshaller<IRequest, RespondDecisionTaskCompletedRequest> 
    {
        

        public IRequest Marshall(RespondDecisionTaskCompletedRequest respondDecisionTaskCompletedRequest) 
        {

            IRequest request = new DefaultRequest(respondDecisionTaskCompletedRequest, "AmazonSimpleWorkflow");
            string target = "SimpleWorkflowService.RespondDecisionTaskCompleted";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (respondDecisionTaskCompletedRequest != null && respondDecisionTaskCompletedRequest.IsSetTaskToken()) 
                {
                    writer.WritePropertyName("taskToken");
                    writer.Write(respondDecisionTaskCompletedRequest.TaskToken);
                }

                if (respondDecisionTaskCompletedRequest != null && respondDecisionTaskCompletedRequest.Decisions != null && respondDecisionTaskCompletedRequest.Decisions.Count > 0)
                {
                    List<Decision> decisionsList = respondDecisionTaskCompletedRequest.Decisions;
                    writer.WritePropertyName("decisions");
                    writer.WriteArrayStart();

                    foreach (Decision decisionsListValue in decisionsList) 
                    {
                        writer.WriteObjectStart();
                        if (decisionsListValue != null && decisionsListValue.IsSetDecisionType()) 
                        {
                            writer.WritePropertyName("decisionType");
                            writer.Write(decisionsListValue.DecisionType);
                        }

                        if (decisionsListValue != null) 
                        {
                            ScheduleActivityTaskDecisionAttributes scheduleActivityTaskDecisionAttributes = decisionsListValue.ScheduleActivityTaskDecisionAttributes;
                            if (scheduleActivityTaskDecisionAttributes != null)
                            {
                                writer.WritePropertyName("scheduleActivityTaskDecisionAttributes");
                                writer.WriteObjectStart();

                                if (scheduleActivityTaskDecisionAttributes != null) 
                                {
                                    ActivityType activityType = scheduleActivityTaskDecisionAttributes.ActivityType;
                                    if (activityType != null)
                                    {
                                        writer.WritePropertyName("activityType");
                                        writer.WriteObjectStart();
                                        if (activityType != null && activityType.IsSetName()) 
                                        {
                                            writer.WritePropertyName("name");
                                            writer.Write(activityType.Name);
                                        }
                                        if (activityType != null && activityType.IsSetVersion()) 
                                        {
                                            writer.WritePropertyName("version");
                                            writer.Write(activityType.Version);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                }
                                if (scheduleActivityTaskDecisionAttributes != null && scheduleActivityTaskDecisionAttributes.IsSetActivityId()) 
                                {
                                    writer.WritePropertyName("activityId");
                                    writer.Write(scheduleActivityTaskDecisionAttributes.ActivityId);
                                }
                                if (scheduleActivityTaskDecisionAttributes != null && scheduleActivityTaskDecisionAttributes.IsSetControl()) 
                                {
                                    writer.WritePropertyName("control");
                                    writer.Write(scheduleActivityTaskDecisionAttributes.Control);
                                }
                                if (scheduleActivityTaskDecisionAttributes != null && scheduleActivityTaskDecisionAttributes.IsSetInput()) 
                                {
                                    writer.WritePropertyName("input");
                                    writer.Write(scheduleActivityTaskDecisionAttributes.Input);
                                }
                                if (scheduleActivityTaskDecisionAttributes != null && scheduleActivityTaskDecisionAttributes.IsSetScheduleToCloseTimeout()) 
                                {
                                    writer.WritePropertyName("scheduleToCloseTimeout");
                                    writer.Write(scheduleActivityTaskDecisionAttributes.ScheduleToCloseTimeout);
                                }

                                if (scheduleActivityTaskDecisionAttributes != null) 
                                {
                                    TaskList taskList = scheduleActivityTaskDecisionAttributes.TaskList;
                                    if (taskList != null)
                                    {
                                        writer.WritePropertyName("taskList");
                                        writer.WriteObjectStart();
                                        if (taskList != null && taskList.IsSetName()) 
                                        {
                                            writer.WritePropertyName("name");
                                            writer.Write(taskList.Name);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                }
                                if (scheduleActivityTaskDecisionAttributes != null && scheduleActivityTaskDecisionAttributes.IsSetScheduleToStartTimeout()) 
                                {
                                    writer.WritePropertyName("scheduleToStartTimeout");
                                    writer.Write(scheduleActivityTaskDecisionAttributes.ScheduleToStartTimeout);
                                }
                                if (scheduleActivityTaskDecisionAttributes != null && scheduleActivityTaskDecisionAttributes.IsSetStartToCloseTimeout()) 
                                {
                                    writer.WritePropertyName("startToCloseTimeout");
                                    writer.Write(scheduleActivityTaskDecisionAttributes.StartToCloseTimeout);
                                }
                                if (scheduleActivityTaskDecisionAttributes != null && scheduleActivityTaskDecisionAttributes.IsSetHeartbeatTimeout()) 
                                {
                                    writer.WritePropertyName("heartbeatTimeout");
                                    writer.Write(scheduleActivityTaskDecisionAttributes.HeartbeatTimeout);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            RequestCancelActivityTaskDecisionAttributes requestCancelActivityTaskDecisionAttributes = decisionsListValue.RequestCancelActivityTaskDecisionAttributes;
                            if (requestCancelActivityTaskDecisionAttributes != null)
                            {
                                writer.WritePropertyName("requestCancelActivityTaskDecisionAttributes");
                                writer.WriteObjectStart();
                                if (requestCancelActivityTaskDecisionAttributes != null && requestCancelActivityTaskDecisionAttributes.IsSetActivityId()) 
                                {
                                    writer.WritePropertyName("activityId");
                                    writer.Write(requestCancelActivityTaskDecisionAttributes.ActivityId);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            CompleteWorkflowExecutionDecisionAttributes completeWorkflowExecutionDecisionAttributes = decisionsListValue.CompleteWorkflowExecutionDecisionAttributes;
                            if (completeWorkflowExecutionDecisionAttributes != null)
                            {
                                writer.WritePropertyName("completeWorkflowExecutionDecisionAttributes");
                                writer.WriteObjectStart();
                                if (completeWorkflowExecutionDecisionAttributes != null && completeWorkflowExecutionDecisionAttributes.IsSetResult()) 
                                {
                                    writer.WritePropertyName("result");
                                    writer.Write(completeWorkflowExecutionDecisionAttributes.Result);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            FailWorkflowExecutionDecisionAttributes failWorkflowExecutionDecisionAttributes = decisionsListValue.FailWorkflowExecutionDecisionAttributes;
                            if (failWorkflowExecutionDecisionAttributes != null)
                            {
                                writer.WritePropertyName("failWorkflowExecutionDecisionAttributes");
                                writer.WriteObjectStart();
                                if (failWorkflowExecutionDecisionAttributes != null && failWorkflowExecutionDecisionAttributes.IsSetReason()) 
                                {
                                    writer.WritePropertyName("reason");
                                    writer.Write(failWorkflowExecutionDecisionAttributes.Reason);
                                }
                                if (failWorkflowExecutionDecisionAttributes != null && failWorkflowExecutionDecisionAttributes.IsSetDetails()) 
                                {
                                    writer.WritePropertyName("details");
                                    writer.Write(failWorkflowExecutionDecisionAttributes.Details);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            CancelWorkflowExecutionDecisionAttributes cancelWorkflowExecutionDecisionAttributes = decisionsListValue.CancelWorkflowExecutionDecisionAttributes;
                            if (cancelWorkflowExecutionDecisionAttributes != null)
                            {
                                writer.WritePropertyName("cancelWorkflowExecutionDecisionAttributes");
                                writer.WriteObjectStart();
                                if (cancelWorkflowExecutionDecisionAttributes != null && cancelWorkflowExecutionDecisionAttributes.IsSetDetails()) 
                                {
                                    writer.WritePropertyName("details");
                                    writer.Write(cancelWorkflowExecutionDecisionAttributes.Details);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            ContinueAsNewWorkflowExecutionDecisionAttributes continueAsNewWorkflowExecutionDecisionAttributes = decisionsListValue.ContinueAsNewWorkflowExecutionDecisionAttributes;
                            if (continueAsNewWorkflowExecutionDecisionAttributes != null)
                            {
                                writer.WritePropertyName("continueAsNewWorkflowExecutionDecisionAttributes");
                                writer.WriteObjectStart();
                                if (continueAsNewWorkflowExecutionDecisionAttributes != null && continueAsNewWorkflowExecutionDecisionAttributes.IsSetInput()) 
                                {
                                    writer.WritePropertyName("input");
                                    writer.Write(continueAsNewWorkflowExecutionDecisionAttributes.Input);
                                }
                                if (continueAsNewWorkflowExecutionDecisionAttributes != null && continueAsNewWorkflowExecutionDecisionAttributes.IsSetExecutionStartToCloseTimeout()) 
                                {
                                    writer.WritePropertyName("executionStartToCloseTimeout");
                                    writer.Write(continueAsNewWorkflowExecutionDecisionAttributes.ExecutionStartToCloseTimeout);
                                }

                                if (continueAsNewWorkflowExecutionDecisionAttributes != null) 
                                {
                                    TaskList taskList = continueAsNewWorkflowExecutionDecisionAttributes.TaskList;
                                    if (taskList != null)
                                    {
                                        writer.WritePropertyName("taskList");
                                        writer.WriteObjectStart();
                                        if (taskList != null && taskList.IsSetName()) 
                                        {
                                            writer.WritePropertyName("name");
                                            writer.Write(taskList.Name);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                }
                                if (continueAsNewWorkflowExecutionDecisionAttributes != null && continueAsNewWorkflowExecutionDecisionAttributes.IsSetTaskStartToCloseTimeout()) 
                                {
                                    writer.WritePropertyName("taskStartToCloseTimeout");
                                    writer.Write(continueAsNewWorkflowExecutionDecisionAttributes.TaskStartToCloseTimeout);
                                }
                                if (continueAsNewWorkflowExecutionDecisionAttributes != null && continueAsNewWorkflowExecutionDecisionAttributes.IsSetChildPolicy()) 
                                {
                                    writer.WritePropertyName("childPolicy");
                                    writer.Write(continueAsNewWorkflowExecutionDecisionAttributes.ChildPolicy);
                                }

                                if (continueAsNewWorkflowExecutionDecisionAttributes != null && continueAsNewWorkflowExecutionDecisionAttributes.TagList != null && continueAsNewWorkflowExecutionDecisionAttributes.TagList.Count > 0) 
                                {
                                    List<string> tagListList = continueAsNewWorkflowExecutionDecisionAttributes.TagList;
                                    writer.WritePropertyName("tagList");
                                    writer.WriteArrayStart();

                                    foreach (string tagListListValue in tagListList) 
                                    { 
                                        writer.Write(StringUtils.FromString(tagListListValue));
                                    }

                                    writer.WriteArrayEnd();
                                }
                                if (continueAsNewWorkflowExecutionDecisionAttributes != null && continueAsNewWorkflowExecutionDecisionAttributes.IsSetWorkflowTypeVersion()) 
                                {
                                    writer.WritePropertyName("workflowTypeVersion");
                                    writer.Write(continueAsNewWorkflowExecutionDecisionAttributes.WorkflowTypeVersion);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            RecordMarkerDecisionAttributes recordMarkerDecisionAttributes = decisionsListValue.RecordMarkerDecisionAttributes;
                            if (recordMarkerDecisionAttributes != null)
                            {
                                writer.WritePropertyName("recordMarkerDecisionAttributes");
                                writer.WriteObjectStart();
                                if (recordMarkerDecisionAttributes != null && recordMarkerDecisionAttributes.IsSetMarkerName()) 
                                {
                                    writer.WritePropertyName("markerName");
                                    writer.Write(recordMarkerDecisionAttributes.MarkerName);
                                }
                                if (recordMarkerDecisionAttributes != null && recordMarkerDecisionAttributes.IsSetDetails()) 
                                {
                                    writer.WritePropertyName("details");
                                    writer.Write(recordMarkerDecisionAttributes.Details);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            StartTimerDecisionAttributes startTimerDecisionAttributes = decisionsListValue.StartTimerDecisionAttributes;
                            if (startTimerDecisionAttributes != null)
                            {
                                writer.WritePropertyName("startTimerDecisionAttributes");
                                writer.WriteObjectStart();
                                if (startTimerDecisionAttributes != null && startTimerDecisionAttributes.IsSetTimerId()) 
                                {
                                    writer.WritePropertyName("timerId");
                                    writer.Write(startTimerDecisionAttributes.TimerId);
                                }
                                if (startTimerDecisionAttributes != null && startTimerDecisionAttributes.IsSetControl()) 
                                {
                                    writer.WritePropertyName("control");
                                    writer.Write(startTimerDecisionAttributes.Control);
                                }
                                if (startTimerDecisionAttributes != null && startTimerDecisionAttributes.IsSetStartToFireTimeout()) 
                                {
                                    writer.WritePropertyName("startToFireTimeout");
                                    writer.Write(startTimerDecisionAttributes.StartToFireTimeout);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            CancelTimerDecisionAttributes cancelTimerDecisionAttributes = decisionsListValue.CancelTimerDecisionAttributes;
                            if (cancelTimerDecisionAttributes != null)
                            {
                                writer.WritePropertyName("cancelTimerDecisionAttributes");
                                writer.WriteObjectStart();
                                if (cancelTimerDecisionAttributes != null && cancelTimerDecisionAttributes.IsSetTimerId()) 
                                {
                                    writer.WritePropertyName("timerId");
                                    writer.Write(cancelTimerDecisionAttributes.TimerId);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            SignalExternalWorkflowExecutionDecisionAttributes signalExternalWorkflowExecutionDecisionAttributes = decisionsListValue.SignalExternalWorkflowExecutionDecisionAttributes;
                            if (signalExternalWorkflowExecutionDecisionAttributes != null)
                            {
                                writer.WritePropertyName("signalExternalWorkflowExecutionDecisionAttributes");
                                writer.WriteObjectStart();
                                if (signalExternalWorkflowExecutionDecisionAttributes != null && signalExternalWorkflowExecutionDecisionAttributes.IsSetWorkflowId()) 
                                {
                                    writer.WritePropertyName("workflowId");
                                    writer.Write(signalExternalWorkflowExecutionDecisionAttributes.WorkflowId);
                                }
                                if (signalExternalWorkflowExecutionDecisionAttributes != null && signalExternalWorkflowExecutionDecisionAttributes.IsSetRunId()) 
                                {
                                    writer.WritePropertyName("runId");
                                    writer.Write(signalExternalWorkflowExecutionDecisionAttributes.RunId);
                                }
                                if (signalExternalWorkflowExecutionDecisionAttributes != null && signalExternalWorkflowExecutionDecisionAttributes.IsSetSignalName()) 
                                {
                                    writer.WritePropertyName("signalName");
                                    writer.Write(signalExternalWorkflowExecutionDecisionAttributes.SignalName);
                                }
                                if (signalExternalWorkflowExecutionDecisionAttributes != null && signalExternalWorkflowExecutionDecisionAttributes.IsSetInput()) 
                                {
                                    writer.WritePropertyName("input");
                                    writer.Write(signalExternalWorkflowExecutionDecisionAttributes.Input);
                                }
                                if (signalExternalWorkflowExecutionDecisionAttributes != null && signalExternalWorkflowExecutionDecisionAttributes.IsSetControl()) 
                                {
                                    writer.WritePropertyName("control");
                                    writer.Write(signalExternalWorkflowExecutionDecisionAttributes.Control);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            RequestCancelExternalWorkflowExecutionDecisionAttributes requestCancelExternalWorkflowExecutionDecisionAttributes = decisionsListValue.RequestCancelExternalWorkflowExecutionDecisionAttributes;
                            if (requestCancelExternalWorkflowExecutionDecisionAttributes != null)
                            {
                                writer.WritePropertyName("requestCancelExternalWorkflowExecutionDecisionAttributes");
                                writer.WriteObjectStart();
                                if (requestCancelExternalWorkflowExecutionDecisionAttributes != null && requestCancelExternalWorkflowExecutionDecisionAttributes.IsSetWorkflowId()) 
                                {
                                    writer.WritePropertyName("workflowId");
                                    writer.Write(requestCancelExternalWorkflowExecutionDecisionAttributes.WorkflowId);
                                }
                                if (requestCancelExternalWorkflowExecutionDecisionAttributes != null && requestCancelExternalWorkflowExecutionDecisionAttributes.IsSetRunId()) 
                                {
                                    writer.WritePropertyName("runId");
                                    writer.Write(requestCancelExternalWorkflowExecutionDecisionAttributes.RunId);
                                }
                                if (requestCancelExternalWorkflowExecutionDecisionAttributes != null && requestCancelExternalWorkflowExecutionDecisionAttributes.IsSetControl()) 
                                {
                                    writer.WritePropertyName("control");
                                    writer.Write(requestCancelExternalWorkflowExecutionDecisionAttributes.Control);
                                }
                                writer.WriteObjectEnd();
                            }
                        }

                        if (decisionsListValue != null) 
                        {
                            StartChildWorkflowExecutionDecisionAttributes startChildWorkflowExecutionDecisionAttributes = decisionsListValue.StartChildWorkflowExecutionDecisionAttributes;
                            if (startChildWorkflowExecutionDecisionAttributes != null)
                            {
                                writer.WritePropertyName("startChildWorkflowExecutionDecisionAttributes");
                                writer.WriteObjectStart();

                                if (startChildWorkflowExecutionDecisionAttributes != null) 
                                {
                                    WorkflowType workflowType = startChildWorkflowExecutionDecisionAttributes.WorkflowType;
                                    if (workflowType != null)
                                    {
                                        writer.WritePropertyName("workflowType");
                                        writer.WriteObjectStart();
                                        if (workflowType != null && workflowType.IsSetName()) 
                                        {
                                            writer.WritePropertyName("name");
                                            writer.Write(workflowType.Name);
                                        }
                                        if (workflowType != null && workflowType.IsSetVersion()) 
                                        {
                                            writer.WritePropertyName("version");
                                            writer.Write(workflowType.Version);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                }
                                if (startChildWorkflowExecutionDecisionAttributes != null && startChildWorkflowExecutionDecisionAttributes.IsSetWorkflowId()) 
                                {
                                    writer.WritePropertyName("workflowId");
                                    writer.Write(startChildWorkflowExecutionDecisionAttributes.WorkflowId);
                                }
                                if (startChildWorkflowExecutionDecisionAttributes != null && startChildWorkflowExecutionDecisionAttributes.IsSetControl()) 
                                {
                                    writer.WritePropertyName("control");
                                    writer.Write(startChildWorkflowExecutionDecisionAttributes.Control);
                                }
                                if (startChildWorkflowExecutionDecisionAttributes != null && startChildWorkflowExecutionDecisionAttributes.IsSetInput()) 
                                {
                                    writer.WritePropertyName("input");
                                    writer.Write(startChildWorkflowExecutionDecisionAttributes.Input);
                                }
                                if (startChildWorkflowExecutionDecisionAttributes != null && startChildWorkflowExecutionDecisionAttributes.IsSetExecutionStartToCloseTimeout()) 
                                {
                                    writer.WritePropertyName("executionStartToCloseTimeout");
                                    writer.Write(startChildWorkflowExecutionDecisionAttributes.ExecutionStartToCloseTimeout);
                                }

                                if (startChildWorkflowExecutionDecisionAttributes != null) 
                                {
                                    TaskList taskList = startChildWorkflowExecutionDecisionAttributes.TaskList;
                                    if (taskList != null)
                                    {
                                        writer.WritePropertyName("taskList");
                                        writer.WriteObjectStart();
                                        if (taskList != null && taskList.IsSetName()) 
                                        {
                                            writer.WritePropertyName("name");
                                            writer.Write(taskList.Name);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                }
                                if (startChildWorkflowExecutionDecisionAttributes != null && startChildWorkflowExecutionDecisionAttributes.IsSetTaskStartToCloseTimeout()) 
                                {
                                    writer.WritePropertyName("taskStartToCloseTimeout");
                                    writer.Write(startChildWorkflowExecutionDecisionAttributes.TaskStartToCloseTimeout);
                                }
                                if (startChildWorkflowExecutionDecisionAttributes != null && startChildWorkflowExecutionDecisionAttributes.IsSetChildPolicy()) 
                                {
                                    writer.WritePropertyName("childPolicy");
                                    writer.Write(startChildWorkflowExecutionDecisionAttributes.ChildPolicy);
                                }

                                if (startChildWorkflowExecutionDecisionAttributes != null && startChildWorkflowExecutionDecisionAttributes.TagList != null && startChildWorkflowExecutionDecisionAttributes.TagList.Count > 0) 
                                {
                                    List<string> tagListList = startChildWorkflowExecutionDecisionAttributes.TagList;
                                    writer.WritePropertyName("tagList");
                                    writer.WriteArrayStart();

                                    foreach (string tagListListValue in tagListList) 
                                    { 
                                        writer.Write(StringUtils.FromString(tagListListValue));
                                    }

                                    writer.WriteArrayEnd();
                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }
                if (respondDecisionTaskCompletedRequest != null && respondDecisionTaskCompletedRequest.IsSetExecutionContext()) 
                {
                    writer.WritePropertyName("executionContext");
                    writer.Write(respondDecisionTaskCompletedRequest.ExecutionContext);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
