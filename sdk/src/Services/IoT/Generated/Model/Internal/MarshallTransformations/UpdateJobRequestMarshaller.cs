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
    /// UpdateJob Request Marshaller
    /// </summary>       
    public class UpdateJobRequestMarshaller : IMarshaller<IRequest, UpdateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetJobId())
                throw new AmazonIoTException("Request object does not have required field JobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));
            
            if (publicRequest.IsSetNamespaceId())
                request.Parameters.Add("namespaceId", StringUtils.FromString(publicRequest.NamespaceId));
            request.ResourcePath = "/jobs/{jobId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAbortConfig())
            {
                context.Writer.WritePropertyName("abortConfig");
                context.Writer.WriteStartObject();

                var marshaller = AbortConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AbortConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetJobExecutionsRetryConfig())
            {
                context.Writer.WritePropertyName("jobExecutionsRetryConfig");
                context.Writer.WriteStartObject();

                var marshaller = JobExecutionsRetryConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.JobExecutionsRetryConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobExecutionsRolloutConfig())
            {
                context.Writer.WritePropertyName("jobExecutionsRolloutConfig");
                context.Writer.WriteStartObject();

                var marshaller = JobExecutionsRolloutConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.JobExecutionsRolloutConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPresignedUrlConfig())
            {
                context.Writer.WritePropertyName("presignedUrlConfig");
                context.Writer.WriteStartObject();

                var marshaller = PresignedUrlConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.PresignedUrlConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTimeoutConfig())
            {
                context.Writer.WritePropertyName("timeoutConfig");
                context.Writer.WriteStartObject();

                var marshaller = TimeoutConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimeoutConfig, context);

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
            

            request.UseQueryString = true;

            return request;
        }
        private static UpdateJobRequestMarshaller _instance = new UpdateJobRequestMarshaller();        

        internal static UpdateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}