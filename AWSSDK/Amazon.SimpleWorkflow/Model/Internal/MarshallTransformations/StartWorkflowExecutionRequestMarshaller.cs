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
    /// Start Workflow Execution Request Marshaller
    /// </summary>       
    internal class StartWorkflowExecutionRequestMarshaller : IMarshaller<IRequest, StartWorkflowExecutionRequest> 
    {
        

        public IRequest Marshall(StartWorkflowExecutionRequest startWorkflowExecutionRequest) 
        {

            IRequest request = new DefaultRequest(startWorkflowExecutionRequest, "AmazonSimpleWorkflow");
            string target = "SimpleWorkflowService.StartWorkflowExecution";
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
                
                if (startWorkflowExecutionRequest != null && startWorkflowExecutionRequest.IsSetDomain()) 
                {
                    writer.WritePropertyName("domain");
                    writer.Write(startWorkflowExecutionRequest.Domain);
                }
                if (startWorkflowExecutionRequest != null && startWorkflowExecutionRequest.IsSetWorkflowId()) 
                {
                    writer.WritePropertyName("workflowId");
                    writer.Write(startWorkflowExecutionRequest.WorkflowId);
                }

                if (startWorkflowExecutionRequest != null) 
                {
                    WorkflowType workflowType = startWorkflowExecutionRequest.WorkflowType;
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

                if (startWorkflowExecutionRequest != null) 
                {
                    TaskList taskList = startWorkflowExecutionRequest.TaskList;
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
                if (startWorkflowExecutionRequest != null && startWorkflowExecutionRequest.IsSetInput()) 
                {
                    writer.WritePropertyName("input");
                    writer.Write(startWorkflowExecutionRequest.Input);
                }
                if (startWorkflowExecutionRequest != null && startWorkflowExecutionRequest.IsSetExecutionStartToCloseTimeout()) 
                {
                    writer.WritePropertyName("executionStartToCloseTimeout");
                    writer.Write(startWorkflowExecutionRequest.ExecutionStartToCloseTimeout);
                }

                if (startWorkflowExecutionRequest != null && startWorkflowExecutionRequest.TagList != null && startWorkflowExecutionRequest.TagList.Count > 0) 
                {
                    List<string> tagListList = startWorkflowExecutionRequest.TagList;
                    writer.WritePropertyName("tagList");
                    writer.WriteArrayStart();

                    foreach (string tagListListValue in tagListList) 
                    { 
                        writer.Write(StringUtils.FromString(tagListListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (startWorkflowExecutionRequest != null && startWorkflowExecutionRequest.IsSetTaskStartToCloseTimeout()) 
                {
                    writer.WritePropertyName("taskStartToCloseTimeout");
                    writer.Write(startWorkflowExecutionRequest.TaskStartToCloseTimeout);
                }
                if (startWorkflowExecutionRequest != null && startWorkflowExecutionRequest.IsSetChildPolicy()) 
                {
                    writer.WritePropertyName("childPolicy");
                    writer.Write(startWorkflowExecutionRequest.ChildPolicy);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
