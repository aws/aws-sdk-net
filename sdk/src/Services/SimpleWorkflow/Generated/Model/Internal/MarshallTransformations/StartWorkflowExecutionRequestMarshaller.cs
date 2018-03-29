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
    /// StartWorkflowExecution Request Marshaller
    /// </summary>       
    public class StartWorkflowExecutionRequestMarshaller : IMarshaller<IRequest, StartWorkflowExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartWorkflowExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartWorkflowExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleWorkflow");
            string target = "SimpleWorkflowService.StartWorkflowExecution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChildPolicy())
                {
                    context.Writer.WritePropertyName("childPolicy");
                    context.Writer.Write(publicRequest.ChildPolicy);
                }

                if(publicRequest.IsSetDomain())
                {
                    context.Writer.WritePropertyName("domain");
                    context.Writer.Write(publicRequest.Domain);
                }

                if(publicRequest.IsSetExecutionStartToCloseTimeout())
                {
                    context.Writer.WritePropertyName("executionStartToCloseTimeout");
                    context.Writer.Write(publicRequest.ExecutionStartToCloseTimeout);
                }

                if(publicRequest.IsSetInput())
                {
                    context.Writer.WritePropertyName("input");
                    context.Writer.Write(publicRequest.Input);
                }

                if(publicRequest.IsSetLambdaRole())
                {
                    context.Writer.WritePropertyName("lambdaRole");
                    context.Writer.Write(publicRequest.LambdaRole);
                }

                if(publicRequest.IsSetTagList())
                {
                    context.Writer.WritePropertyName("tagList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagListListValue in publicRequest.TagList)
                    {
                            context.Writer.Write(publicRequestTagListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTaskList())
                {
                    context.Writer.WritePropertyName("taskList");
                    context.Writer.WriteObjectStart();

                    var marshaller = TaskListMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TaskList, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTaskPriority())
                {
                    context.Writer.WritePropertyName("taskPriority");
                    context.Writer.Write(publicRequest.TaskPriority);
                }

                if(publicRequest.IsSetTaskStartToCloseTimeout())
                {
                    context.Writer.WritePropertyName("taskStartToCloseTimeout");
                    context.Writer.Write(publicRequest.TaskStartToCloseTimeout);
                }

                if(publicRequest.IsSetWorkflowId())
                {
                    context.Writer.WritePropertyName("workflowId");
                    context.Writer.Write(publicRequest.WorkflowId);
                }

                if(publicRequest.IsSetWorkflowType())
                {
                    context.Writer.WritePropertyName("workflowType");
                    context.Writer.WriteObjectStart();

                    var marshaller = WorkflowTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.WorkflowType, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartWorkflowExecutionRequestMarshaller _instance = new StartWorkflowExecutionRequestMarshaller();        

        internal static StartWorkflowExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartWorkflowExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}