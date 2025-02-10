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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartPipelineExecution Request Marshaller
    /// </summary>       
    public class StartPipelineExecutionRequestMarshaller : IMarshaller<IRequest, StartPipelineExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartPipelineExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartPipelineExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.StartPipelineExecution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
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
            if(publicRequest.IsSetParallelismConfiguration())
            {
                context.Writer.WritePropertyName("ParallelismConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ParallelismConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ParallelismConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPipelineExecutionDescription())
            {
                context.Writer.WritePropertyName("PipelineExecutionDescription");
                context.Writer.WriteStringValue(publicRequest.PipelineExecutionDescription);
            }

            if(publicRequest.IsSetPipelineExecutionDisplayName())
            {
                context.Writer.WritePropertyName("PipelineExecutionDisplayName");
                context.Writer.WriteStringValue(publicRequest.PipelineExecutionDisplayName);
            }

            if(publicRequest.IsSetPipelineName())
            {
                context.Writer.WritePropertyName("PipelineName");
                context.Writer.WriteStringValue(publicRequest.PipelineName);
            }

            if(publicRequest.IsSetPipelineParameters())
            {
                context.Writer.WritePropertyName("PipelineParameters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPipelineParametersListValue in publicRequest.PipelineParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestPipelineParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSelectiveExecutionConfig())
            {
                context.Writer.WritePropertyName("SelectiveExecutionConfig");
                context.Writer.WriteStartObject();

                var marshaller = SelectiveExecutionConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SelectiveExecutionConfig, context);

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
        private static StartPipelineExecutionRequestMarshaller _instance = new StartPipelineExecutionRequestMarshaller();        

        internal static StartPipelineExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartPipelineExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}