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
    /// Count Pending Decision Tasks Request Marshaller
    /// </summary>       
    internal class CountPendingDecisionTasksRequestMarshaller : IMarshaller<IRequest, CountPendingDecisionTasksRequest> 
    {
        

        public IRequest Marshall(CountPendingDecisionTasksRequest countPendingDecisionTasksRequest) 
        {

            IRequest request = new DefaultRequest(countPendingDecisionTasksRequest, "AmazonSimpleWorkflow");
            string target = "SimpleWorkflowService.CountPendingDecisionTasks";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
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
            
             
            using (StringWriter stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (countPendingDecisionTasksRequest != null && countPendingDecisionTasksRequest.IsSetDomain()) 
                {
                    writer.WritePropertyName("domain");
                    writer.Write(countPendingDecisionTasksRequest.Domain);
                }

                if (countPendingDecisionTasksRequest != null) 
                {
                    TaskList taskList = countPendingDecisionTasksRequest.TaskList;
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

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
