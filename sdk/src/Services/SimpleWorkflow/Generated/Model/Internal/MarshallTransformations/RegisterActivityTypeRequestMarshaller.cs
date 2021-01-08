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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// RegisterActivityType Request Marshaller
    /// </summary>       
    public class RegisterActivityTypeRequestMarshaller : IMarshaller<IRequest, RegisterActivityTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterActivityTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterActivityTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleWorkflow");
            string target = "SimpleWorkflowService.RegisterActivityType";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-01-25";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefaultTaskHeartbeatTimeout())
                {
                    context.Writer.WritePropertyName("defaultTaskHeartbeatTimeout");
                    context.Writer.Write(publicRequest.DefaultTaskHeartbeatTimeout);
                }

                if(publicRequest.IsSetDefaultTaskList())
                {
                    context.Writer.WritePropertyName("defaultTaskList");
                    context.Writer.WriteObjectStart();

                    var marshaller = TaskListMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefaultTaskList, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaultTaskPriority())
                {
                    context.Writer.WritePropertyName("defaultTaskPriority");
                    context.Writer.Write(publicRequest.DefaultTaskPriority);
                }

                if(publicRequest.IsSetDefaultTaskScheduleToCloseTimeout())
                {
                    context.Writer.WritePropertyName("defaultTaskScheduleToCloseTimeout");
                    context.Writer.Write(publicRequest.DefaultTaskScheduleToCloseTimeout);
                }

                if(publicRequest.IsSetDefaultTaskScheduleToStartTimeout())
                {
                    context.Writer.WritePropertyName("defaultTaskScheduleToStartTimeout");
                    context.Writer.Write(publicRequest.DefaultTaskScheduleToStartTimeout);
                }

                if(publicRequest.IsSetDefaultTaskStartToCloseTimeout())
                {
                    context.Writer.WritePropertyName("defaultTaskStartToCloseTimeout");
                    context.Writer.Write(publicRequest.DefaultTaskStartToCloseTimeout);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDomain())
                {
                    context.Writer.WritePropertyName("domain");
                    context.Writer.Write(publicRequest.Domain);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetVersion())
                {
                    context.Writer.WritePropertyName("version");
                    context.Writer.Write(publicRequest.Version);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterActivityTypeRequestMarshaller _instance = new RegisterActivityTypeRequestMarshaller();        

        internal static RegisterActivityTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterActivityTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}