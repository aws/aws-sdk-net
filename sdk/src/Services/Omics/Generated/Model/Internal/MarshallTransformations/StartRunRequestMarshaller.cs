/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartRun Request Marshaller
    /// </summary>       
    public class StartRunRequestMarshaller : IMarshaller<IRequest, StartRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/run";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLogLevel())
                {
                    context.Writer.WritePropertyName("logLevel");
                    context.Writer.Write(publicRequest.LogLevel);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOutputUri())
                {
                    context.Writer.WritePropertyName("outputUri");
                    context.Writer.Write(publicRequest.OutputUri);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("parameters");
                    Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequest.Parameters);
                }

                if(publicRequest.IsSetPriority())
                {
                    context.Writer.WritePropertyName("priority");
                    context.Writer.Write(publicRequest.Priority);
                }

                if(publicRequest.IsSetRequestId())
                {
                    context.Writer.WritePropertyName("requestId");
                    context.Writer.Write(publicRequest.RequestId);
                }

                else if(!(publicRequest.IsSetRequestId()))
                {
                    context.Writer.WritePropertyName("requestId");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetRunGroupId())
                {
                    context.Writer.WritePropertyName("runGroupId");
                    context.Writer.Write(publicRequest.RunGroupId);
                }

                if(publicRequest.IsSetRunId())
                {
                    context.Writer.WritePropertyName("runId");
                    context.Writer.Write(publicRequest.RunId);
                }

                if(publicRequest.IsSetStorageCapacity())
                {
                    context.Writer.WritePropertyName("storageCapacity");
                    context.Writer.Write(publicRequest.StorageCapacity);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWorkflowId())
                {
                    context.Writer.WritePropertyName("workflowId");
                    context.Writer.Write(publicRequest.WorkflowId);
                }

                if(publicRequest.IsSetWorkflowType())
                {
                    context.Writer.WritePropertyName("workflowType");
                    context.Writer.Write(publicRequest.WorkflowType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"workflows-";

            return request;
        }
        private static StartRunRequestMarshaller _instance = new StartRunRequestMarshaller();        

        internal static StartRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}