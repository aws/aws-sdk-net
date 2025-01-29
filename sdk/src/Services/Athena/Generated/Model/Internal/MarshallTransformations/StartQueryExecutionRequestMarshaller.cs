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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Athena.Model;
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
namespace Amazon.Athena.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartQueryExecution Request Marshaller
    /// </summary>       
    public class StartQueryExecutionRequestMarshaller : IMarshaller<IRequest, StartQueryExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartQueryExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartQueryExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Athena");
            string target = "AmazonAthena.StartQueryExecution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-05-18";
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
            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetExecutionParameters())
            {
                context.Writer.WritePropertyName("ExecutionParameters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestExecutionParametersListValue in publicRequest.ExecutionParameters)
                {
                        context.Writer.WriteStringValue(publicRequestExecutionParametersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetQueryExecutionContext())
            {
                context.Writer.WritePropertyName("QueryExecutionContext");
                context.Writer.WriteStartObject();

                var marshaller = QueryExecutionContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.QueryExecutionContext, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetQueryString())
            {
                context.Writer.WritePropertyName("QueryString");
                context.Writer.WriteStringValue(publicRequest.QueryString);
            }

            if(publicRequest.IsSetResultConfiguration())
            {
                context.Writer.WritePropertyName("ResultConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ResultConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ResultConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResultReuseConfiguration())
            {
                context.Writer.WritePropertyName("ResultReuseConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ResultReuseConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ResultReuseConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWorkGroup())
            {
                context.Writer.WritePropertyName("WorkGroup");
                context.Writer.WriteStringValue(publicRequest.WorkGroup);
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
        private static StartQueryExecutionRequestMarshaller _instance = new StartQueryExecutionRequestMarshaller();        

        internal static StartQueryExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartQueryExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}