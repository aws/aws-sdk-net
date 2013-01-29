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
    /// Register Activity Type Request Marshaller
    /// </summary>       
    internal class RegisterActivityTypeRequestMarshaller : IMarshaller<IRequest, RegisterActivityTypeRequest> 
    {
        

        public IRequest Marshall(RegisterActivityTypeRequest registerActivityTypeRequest) 
        {

            IRequest request = new DefaultRequest(registerActivityTypeRequest, "AmazonSimpleWorkflow");
            string target = "SimpleWorkflowService.RegisterActivityType";
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
                
                if (registerActivityTypeRequest != null && registerActivityTypeRequest.IsSetDomain()) 
                {
                    writer.WritePropertyName("domain");
                    writer.Write(registerActivityTypeRequest.Domain);
                }
                if (registerActivityTypeRequest != null && registerActivityTypeRequest.IsSetName()) 
                {
                    writer.WritePropertyName("name");
                    writer.Write(registerActivityTypeRequest.Name);
                }
                if (registerActivityTypeRequest != null && registerActivityTypeRequest.IsSetVersion()) 
                {
                    writer.WritePropertyName("version");
                    writer.Write(registerActivityTypeRequest.Version);
                }
                if (registerActivityTypeRequest != null && registerActivityTypeRequest.IsSetDescription()) 
                {
                    writer.WritePropertyName("description");
                    writer.Write(registerActivityTypeRequest.Description);
                }
                if (registerActivityTypeRequest != null && registerActivityTypeRequest.IsSetDefaultTaskStartToCloseTimeout()) 
                {
                    writer.WritePropertyName("defaultTaskStartToCloseTimeout");
                    writer.Write(registerActivityTypeRequest.DefaultTaskStartToCloseTimeout);
                }
                if (registerActivityTypeRequest != null && registerActivityTypeRequest.IsSetDefaultTaskHeartbeatTimeout()) 
                {
                    writer.WritePropertyName("defaultTaskHeartbeatTimeout");
                    writer.Write(registerActivityTypeRequest.DefaultTaskHeartbeatTimeout);
                }

                if (registerActivityTypeRequest != null) 
                {
                    TaskList defaultTaskList = registerActivityTypeRequest.DefaultTaskList;
                    if (defaultTaskList != null)
                    {
                        writer.WritePropertyName("defaultTaskList");
                        writer.WriteObjectStart();
                        if (defaultTaskList != null && defaultTaskList.IsSetName()) 
                        {
                            writer.WritePropertyName("name");
                            writer.Write(defaultTaskList.Name);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (registerActivityTypeRequest != null && registerActivityTypeRequest.IsSetDefaultTaskScheduleToStartTimeout()) 
                {
                    writer.WritePropertyName("defaultTaskScheduleToStartTimeout");
                    writer.Write(registerActivityTypeRequest.DefaultTaskScheduleToStartTimeout);
                }
                if (registerActivityTypeRequest != null && registerActivityTypeRequest.IsSetDefaultTaskScheduleToCloseTimeout()) 
                {
                    writer.WritePropertyName("defaultTaskScheduleToCloseTimeout");
                    writer.Write(registerActivityTypeRequest.DefaultTaskScheduleToCloseTimeout);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
