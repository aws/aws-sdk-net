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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
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
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListCommandExecutions Request Marshaller
    /// </summary>       
    public class ListCommandExecutionsRequestMarshaller : IMarshaller<IRequest, ListCommandExecutionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCommandExecutionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListCommandExecutionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/command-executions";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCommandArn())
            {
                context.Writer.WritePropertyName("commandArn");
                context.Writer.WriteStringValue(publicRequest.CommandArn);
            }

            if(publicRequest.IsSetCompletedTimeFilter())
            {
                context.Writer.WritePropertyName("completedTimeFilter");
                context.Writer.WriteStartObject();

                var marshaller = TimeFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.CompletedTimeFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNamespace())
            {
                context.Writer.WritePropertyName("namespace");
                context.Writer.WriteStringValue(publicRequest.Namespace);
            }

            if(publicRequest.IsSetSortOrder())
            {
                context.Writer.WritePropertyName("sortOrder");
                context.Writer.WriteStringValue(publicRequest.SortOrder);
            }

            if(publicRequest.IsSetStartedTimeFilter())
            {
                context.Writer.WritePropertyName("startedTimeFilter");
                context.Writer.WriteStartObject();

                var marshaller = TimeFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.StartedTimeFilter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }

            if(publicRequest.IsSetTargetArn())
            {
                context.Writer.WritePropertyName("targetArn");
                context.Writer.WriteStringValue(publicRequest.TargetArn);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            request.UseQueryString = true;

            return request;
        }
        private static ListCommandExecutionsRequestMarshaller _instance = new ListCommandExecutionsRequestMarshaller();        

        internal static ListCommandExecutionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListCommandExecutionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}