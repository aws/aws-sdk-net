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

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Deployment Request Marshaller
    /// </summary>       
    internal class CreateDeploymentRequestMarshaller : IMarshaller<IRequest, CreateDeploymentRequest> 
    {
        

        public IRequest Marshall(CreateDeploymentRequest createDeploymentRequest) 
        {

            IRequest request = new DefaultRequest(createDeploymentRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.CreateDeployment";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            
              
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
                
                if (createDeploymentRequest != null && createDeploymentRequest.IsSetStackId()) 
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(createDeploymentRequest.StackId);
                }
                if (createDeploymentRequest != null && createDeploymentRequest.IsSetAppId()) 
                {
                    writer.WritePropertyName("AppId");
                    writer.Write(createDeploymentRequest.AppId);
                }

                if (createDeploymentRequest != null && createDeploymentRequest.InstanceIds != null && createDeploymentRequest.InstanceIds.Count > 0) 
                {
                    List<string> instanceIdsList = createDeploymentRequest.InstanceIds;
                    writer.WritePropertyName("InstanceIds");
                    writer.WriteArrayStart();

                    foreach (string instanceIdsListValue in instanceIdsList) 
                    { 
                        writer.Write(StringUtils.FromString(instanceIdsListValue));
                    }

                    writer.WriteArrayEnd();
                }

                if (createDeploymentRequest != null) 
                {
                    DeploymentCommand command = createDeploymentRequest.Command;
                    if (command != null)
                    {
                        writer.WritePropertyName("Command");
                        writer.WriteObjectStart();
                        if (command != null && command.IsSetName()) 
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(command.Name);
                        }
                        if (command != null) 
                        {
                            if (command.Args != null && command.Args.Count > 0)
                            {
                                writer.WritePropertyName("Args");
                                writer.WriteObjectStart();
                                foreach (string commandArgsKey in command.Args.Keys)
                                {
                                    List<string> argsListValue;
                                    bool argsListValueHasValue = command.Args.TryGetValue(commandArgsKey, out argsListValue);
                                    writer.WritePropertyName(commandArgsKey);

                                }
                                writer.WriteObjectEnd();
                            }
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (createDeploymentRequest != null && createDeploymentRequest.IsSetComment()) 
                {
                    writer.WritePropertyName("Comment");
                    writer.Write(createDeploymentRequest.Comment);
                }
                if (createDeploymentRequest != null && createDeploymentRequest.IsSetCustomJson()) 
                {
                    writer.WritePropertyName("CustomJson");
                    writer.Write(createDeploymentRequest.CustomJson);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
