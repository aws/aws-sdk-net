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

/*
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.CreateJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllocatedCapacity())
                {
                    context.Writer.WritePropertyName("AllocatedCapacity");
                    context.Writer.Write(publicRequest.AllocatedCapacity);
                }

                if(publicRequest.IsSetCommand())
                {
                    context.Writer.WritePropertyName("Command");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobCommandMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Command, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConnections())
                {
                    context.Writer.WritePropertyName("Connections");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConnectionsListMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Connections, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaultArguments())
                {
                    context.Writer.WritePropertyName("DefaultArguments");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestDefaultArgumentsKvp in publicRequest.DefaultArguments)
                    {
                        context.Writer.WritePropertyName(publicRequestDefaultArgumentsKvp.Key);
                        var publicRequestDefaultArgumentsValue = publicRequestDefaultArgumentsKvp.Value;

                            context.Writer.Write(publicRequestDefaultArgumentsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetExecutionProperty())
                {
                    context.Writer.WritePropertyName("ExecutionProperty");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExecutionPropertyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExecutionProperty, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogUri())
                {
                    context.Writer.WritePropertyName("LogUri");
                    context.Writer.Write(publicRequest.LogUri);
                }

                if(publicRequest.IsSetMaxRetries())
                {
                    context.Writer.WritePropertyName("MaxRetries");
                    context.Writer.Write(publicRequest.MaxRetries);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNotificationProperty())
                {
                    context.Writer.WritePropertyName("NotificationProperty");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationPropertyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationProperty, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("Role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetTimeout())
                {
                    context.Writer.WritePropertyName("Timeout");
                    context.Writer.Write(publicRequest.Timeout);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}