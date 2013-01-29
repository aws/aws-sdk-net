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
    /// Count Closed Workflow Executions Request Marshaller
    /// </summary>       
    internal class CountClosedWorkflowExecutionsRequestMarshaller : IMarshaller<IRequest, CountClosedWorkflowExecutionsRequest> 
    {
        

        public IRequest Marshall(CountClosedWorkflowExecutionsRequest countClosedWorkflowExecutionsRequest) 
        {

            IRequest request = new DefaultRequest(countClosedWorkflowExecutionsRequest, "AmazonSimpleWorkflow");
            string target = "SimpleWorkflowService.CountClosedWorkflowExecutions";
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
                
                if (countClosedWorkflowExecutionsRequest != null && countClosedWorkflowExecutionsRequest.IsSetDomain()) 
                {
                    writer.WritePropertyName("domain");
                    writer.Write(countClosedWorkflowExecutionsRequest.Domain);
                }

                if (countClosedWorkflowExecutionsRequest != null) 
                {
                    ExecutionTimeFilter startTimeFilter = countClosedWorkflowExecutionsRequest.StartTimeFilter;
                    if (startTimeFilter != null)
                    {
                        writer.WritePropertyName("startTimeFilter");
                        writer.WriteObjectStart();
                        if (startTimeFilter != null && startTimeFilter.IsSetOldestDate()) 
                        {
                            writer.WritePropertyName("oldestDate");
                            writer.Write(startTimeFilter.OldestDate);
                        }
                        if (startTimeFilter != null && startTimeFilter.IsSetLatestDate()) 
                        {
                            writer.WritePropertyName("latestDate");
                            writer.Write(startTimeFilter.LatestDate);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (countClosedWorkflowExecutionsRequest != null) 
                {
                    ExecutionTimeFilter closeTimeFilter = countClosedWorkflowExecutionsRequest.CloseTimeFilter;
                    if (closeTimeFilter != null)
                    {
                        writer.WritePropertyName("closeTimeFilter");
                        writer.WriteObjectStart();
                        if (closeTimeFilter != null && closeTimeFilter.IsSetOldestDate()) 
                        {
                            writer.WritePropertyName("oldestDate");
                            writer.Write(closeTimeFilter.OldestDate);
                        }
                        if (closeTimeFilter != null && closeTimeFilter.IsSetLatestDate()) 
                        {
                            writer.WritePropertyName("latestDate");
                            writer.Write(closeTimeFilter.LatestDate);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (countClosedWorkflowExecutionsRequest != null) 
                {
                    WorkflowExecutionFilter executionFilter = countClosedWorkflowExecutionsRequest.ExecutionFilter;
                    if (executionFilter != null)
                    {
                        writer.WritePropertyName("executionFilter");
                        writer.WriteObjectStart();
                        if (executionFilter != null && executionFilter.IsSetWorkflowId()) 
                        {
                            writer.WritePropertyName("workflowId");
                            writer.Write(executionFilter.WorkflowId);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (countClosedWorkflowExecutionsRequest != null) 
                {
                    WorkflowTypeFilter typeFilter = countClosedWorkflowExecutionsRequest.TypeFilter;
                    if (typeFilter != null)
                    {
                        writer.WritePropertyName("typeFilter");
                        writer.WriteObjectStart();
                        if (typeFilter != null && typeFilter.IsSetName()) 
                        {
                            writer.WritePropertyName("name");
                            writer.Write(typeFilter.Name);
                        }
                        if (typeFilter != null && typeFilter.IsSetVersion()) 
                        {
                            writer.WritePropertyName("version");
                            writer.Write(typeFilter.Version);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (countClosedWorkflowExecutionsRequest != null) 
                {
                    TagFilter tagFilter = countClosedWorkflowExecutionsRequest.TagFilter;
                    if (tagFilter != null)
                    {
                        writer.WritePropertyName("tagFilter");
                        writer.WriteObjectStart();
                        if (tagFilter != null && tagFilter.IsSetTag()) 
                        {
                            writer.WritePropertyName("tag");
                            writer.Write(tagFilter.Tag);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (countClosedWorkflowExecutionsRequest != null) 
                {
                    CloseStatusFilter closeStatusFilter = countClosedWorkflowExecutionsRequest.CloseStatusFilter;
                    if (closeStatusFilter != null)
                    {
                        writer.WritePropertyName("closeStatusFilter");
                        writer.WriteObjectStart();
                        if (closeStatusFilter != null && closeStatusFilter.IsSetStatus()) 
                        {
                            writer.WritePropertyName("status");
                            writer.Write(closeStatusFilter.Status);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
