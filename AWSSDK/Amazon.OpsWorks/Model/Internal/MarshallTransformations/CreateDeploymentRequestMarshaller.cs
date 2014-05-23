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
using System.Globalization;
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
    /// CreateDeployment Request Marshaller
    /// </summary>       
    public class CreateDeploymentRequestMarshaller : IMarshaller<IRequest, CreateDeploymentRequest> 
    {
        public IRequest Marshall(CreateDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.CreateDeployment";
            request.Headers["X-Amz-Target"] = target;

            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest != null && publicRequest.IsSetAppId())
                {
                    writer.WritePropertyName("AppId");
                    writer.Write(publicRequest.AppId);
                }

                if(publicRequest != null && publicRequest.IsSetCommand())
                {
                    writer.WritePropertyName("Command");
                    writer.WriteObjectStart();
                    if(publicRequest.Command != null && publicRequest.Command.IsSetArgs() && publicRequest.Command.Args.Count > 0)
                    {
                        writer.WritePropertyName("Args");
                        writer.WriteObjectStart();
                        foreach (var publicRequestCommandArgsKvp in publicRequest.Command.Args)
                        {
                            writer.WritePropertyName(publicRequestCommandArgsKvp.Key);
                            var publicRequestCommandArgsValue = publicRequestCommandArgsKvp.Value;

                            writer.WriteArrayStart();
                            foreach(var publicRequestCommandArgsValueListValue in publicRequestCommandArgsValue)
                            {
                                writer.Write(publicRequestCommandArgsValueListValue);
                            }
                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.Command != null && publicRequest.Command.IsSetName())
                    {
                        writer.WritePropertyName("Name");
                        writer.Write(publicRequest.Command.Name);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest != null && publicRequest.IsSetComment())
                {
                    writer.WritePropertyName("Comment");
                    writer.Write(publicRequest.Comment);
                }

                if(publicRequest != null && publicRequest.IsSetCustomJson())
                {
                    writer.WritePropertyName("CustomJson");
                    writer.Write(publicRequest.CustomJson);
                }

                if(publicRequest != null && publicRequest.IsSetInstanceIds() && publicRequest.InstanceIds.Count > 0)
                {
                    writer.WritePropertyName("InstanceIds");
                    writer.WriteArrayStart();
                    foreach(var publicRequestInstanceIdsListValue in publicRequest.InstanceIds)
                    {
                        writer.Write(publicRequestInstanceIdsListValue);
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest != null && publicRequest.IsSetStackId())
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(publicRequest.StackId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            return request;
        }


    }
}