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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-01-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChildPolicy())
            {
                context.Writer.WritePropertyName("childPolicy");
                context.Writer.WriteStringValue(publicRequest.ChildPolicy);
            }

            if(publicRequest.IsSetDomain())
            {
                context.Writer.WritePropertyName("domain");
                context.Writer.WriteStringValue(publicRequest.Domain);
            }

            if(publicRequest.IsSetExecutionStartToCloseTimeout())
            {
                context.Writer.WritePropertyName("executionStartToCloseTimeout");
                context.Writer.WriteStringValue(publicRequest.ExecutionStartToCloseTimeout);
            }

            if(publicRequest.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                context.Writer.WriteStringValue(publicRequest.Input);
            }

            if(publicRequest.IsSetLambdaRole())
            {
                context.Writer.WritePropertyName("lambdaRole");
                context.Writer.WriteStringValue(publicRequest.LambdaRole);
            }

            if(publicRequest.IsSetTagList())
            {
                context.Writer.WritePropertyName("tagList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagListListValue in publicRequest.TagList)
                {
                        context.Writer.WriteStringValue(publicRequestTagListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTaskList())
            {
                context.Writer.WritePropertyName("taskList");
                context.Writer.WriteStartObject();

                var marshaller = TaskListMarshaller.Instance;
                marshaller.Marshall(publicRequest.TaskList, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTaskPriority())
            {
                context.Writer.WritePropertyName("taskPriority");
                context.Writer.WriteStringValue(publicRequest.TaskPriority);
            }

            if(publicRequest.IsSetTaskStartToCloseTimeout())
            {
                context.Writer.WritePropertyName("taskStartToCloseTimeout");
                context.Writer.WriteStringValue(publicRequest.TaskStartToCloseTimeout);
            }

            if(publicRequest.IsSetWorkflowId())
            {
                context.Writer.WritePropertyName("workflowId");
                context.Writer.WriteStringValue(publicRequest.WorkflowId);
            }

            if(publicRequest.IsSetWorkflowType())
            {
                context.Writer.WritePropertyName("workflowType");
                context.Writer.WriteStartObject();

                var marshaller = WorkflowTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.WorkflowType, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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