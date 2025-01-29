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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataPipeline.Model;
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
namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryObjects Request Marshaller
    /// </summary>       
    public class QueryObjectsRequestMarshaller : IMarshaller<IRequest, QueryObjectsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryObjectsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(QueryObjectsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataPipeline");
            string target = "DataPipeline.QueryObjects";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-10-29";
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
            if(publicRequest.IsSetLimit())
            {
                context.Writer.WritePropertyName("limit");
                context.Writer.WriteNumberValue(publicRequest.Limit.Value);
            }

            if(publicRequest.IsSetMarker())
            {
                context.Writer.WritePropertyName("marker");
                context.Writer.WriteStringValue(publicRequest.Marker);
            }

            if(publicRequest.IsSetPipelineId())
            {
                context.Writer.WritePropertyName("pipelineId");
                context.Writer.WriteStringValue(publicRequest.PipelineId);
            }

            if(publicRequest.IsSetQuery())
            {
                context.Writer.WritePropertyName("query");
                context.Writer.WriteStartObject();

                var marshaller = QueryMarshaller.Instance;
                marshaller.Marshall(publicRequest.Query, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSphere())
            {
                context.Writer.WritePropertyName("sphere");
                context.Writer.WriteStringValue(publicRequest.Sphere);
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
        private static QueryObjectsRequestMarshaller _instance = new QueryObjectsRequestMarshaller();        

        internal static QueryObjectsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryObjectsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}