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
    /// ListClosedWorkflowExecutions Request Marshaller
    /// </summary>       
    public class ListClosedWorkflowExecutionsRequestMarshaller : IMarshaller<IRequest, ListClosedWorkflowExecutionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListClosedWorkflowExecutionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListClosedWorkflowExecutionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleWorkflow");
            string target = "SimpleWorkflowService.ListClosedWorkflowExecutions";
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
            if(publicRequest.IsSetCloseStatusFilter())
            {
                context.Writer.WritePropertyName("closeStatusFilter");
                context.Writer.WriteStartObject();

                var marshaller = CloseStatusFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.CloseStatusFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCloseTimeFilter())
            {
                context.Writer.WritePropertyName("closeTimeFilter");
                context.Writer.WriteStartObject();

                var marshaller = ExecutionTimeFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.CloseTimeFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDomain())
            {
                context.Writer.WritePropertyName("domain");
                context.Writer.WriteStringValue(publicRequest.Domain);
            }

            if(publicRequest.IsSetExecutionFilter())
            {
                context.Writer.WritePropertyName("executionFilter");
                context.Writer.WriteStartObject();

                var marshaller = WorkflowExecutionFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExecutionFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaximumPageSize())
            {
                context.Writer.WritePropertyName("maximumPageSize");
                context.Writer.WriteNumberValue(publicRequest.MaximumPageSize.Value);
            }

            if(publicRequest.IsSetNextPageToken())
            {
                context.Writer.WritePropertyName("nextPageToken");
                context.Writer.WriteStringValue(publicRequest.NextPageToken);
            }

            if(publicRequest.IsSetReverseOrder())
            {
                context.Writer.WritePropertyName("reverseOrder");
                context.Writer.WriteBooleanValue(publicRequest.ReverseOrder.Value);
            }

            if(publicRequest.IsSetStartTimeFilter())
            {
                context.Writer.WritePropertyName("startTimeFilter");
                context.Writer.WriteStartObject();

                var marshaller = ExecutionTimeFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.StartTimeFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTagFilter())
            {
                context.Writer.WritePropertyName("tagFilter");
                context.Writer.WriteStartObject();

                var marshaller = TagFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.TagFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTypeFilter())
            {
                context.Writer.WritePropertyName("typeFilter");
                context.Writer.WriteStartObject();

                var marshaller = WorkflowTypeFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.TypeFilter, context);

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
        private static ListClosedWorkflowExecutionsRequestMarshaller _instance = new ListClosedWorkflowExecutionsRequestMarshaller();        

        internal static ListClosedWorkflowExecutionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListClosedWorkflowExecutionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}