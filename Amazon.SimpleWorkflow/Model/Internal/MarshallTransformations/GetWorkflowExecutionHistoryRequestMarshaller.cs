/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Get Workflow Execution History Request Marshaller
    /// </summary>       
    internal class GetWorkflowExecutionHistoryRequestMarshaller : IMarshaller<IRequest, GetWorkflowExecutionHistoryRequest> 
    {
        public IRequest Marshall(GetWorkflowExecutionHistoryRequest getWorkflowExecutionHistoryRequest) 
        {

            IRequest request = new DefaultRequest(getWorkflowExecutionHistoryRequest, "AmazonSimpleWorkflow");
            string target = "SimpleWorkflowService.GetWorkflowExecutionHistory";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (getWorkflowExecutionHistoryRequest != null && getWorkflowExecutionHistoryRequest.IsSetDomain()) 
                {
                    writer.WritePropertyName("domain");
                    writer.Write(getWorkflowExecutionHistoryRequest.Domain);
                }

                if (getWorkflowExecutionHistoryRequest != null) 
                {
                    WorkflowExecution execution = getWorkflowExecutionHistoryRequest.Execution;
                    if (execution != null)
                    {
                        writer.WritePropertyName("execution");
                        writer.WriteObjectStart();
                        if (execution != null && execution.IsSetWorkflowId()) 
                        {
                            writer.WritePropertyName("workflowId");
                            writer.Write(execution.WorkflowId);
                        }
                        if (execution != null && execution.IsSetRunId()) 
                        {
                            writer.WritePropertyName("runId");
                            writer.Write(execution.RunId);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (getWorkflowExecutionHistoryRequest != null && getWorkflowExecutionHistoryRequest.IsSetNextPageToken()) 
                {
                    writer.WritePropertyName("nextPageToken");
                    writer.Write(getWorkflowExecutionHistoryRequest.NextPageToken);
                }
                if (getWorkflowExecutionHistoryRequest != null && getWorkflowExecutionHistoryRequest.IsSetMaximumPageSize()) 
                {
                    writer.WritePropertyName("maximumPageSize");
                    writer.Write(getWorkflowExecutionHistoryRequest.MaximumPageSize);
                }
                if (getWorkflowExecutionHistoryRequest != null && getWorkflowExecutionHistoryRequest.IsSetReverseOrder()) 
                {
                    writer.WritePropertyName("reverseOrder");
                    writer.Write(getWorkflowExecutionHistoryRequest.ReverseOrder);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
                return request;
            }
        }
    }
}
