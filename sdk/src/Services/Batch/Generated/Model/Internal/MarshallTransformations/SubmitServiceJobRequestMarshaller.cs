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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
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
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubmitServiceJob Request Marshaller
    /// </summary>       
    public class SubmitServiceJobRequestMarshaller : IMarshaller<IRequest, SubmitServiceJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SubmitServiceJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SubmitServiceJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/submitservicejob";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetJobName())
            {
                context.Writer.WritePropertyName("jobName");
                context.Writer.WriteStringValue(publicRequest.JobName);
            }

            if(publicRequest.IsSetJobQueue())
            {
                context.Writer.WritePropertyName("jobQueue");
                context.Writer.WriteStringValue(publicRequest.JobQueue);
            }

            if(publicRequest.IsSetRetryStrategy())
            {
                context.Writer.WritePropertyName("retryStrategy");
                context.Writer.WriteStartObject();

                var marshaller = ServiceJobRetryStrategyMarshaller.Instance;
                marshaller.Marshall(publicRequest.RetryStrategy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSchedulingPriority())
            {
                context.Writer.WritePropertyName("schedulingPriority");
                context.Writer.WriteNumberValue(publicRequest.SchedulingPriority.Value);
            }

            if(publicRequest.IsSetServiceJobType())
            {
                context.Writer.WritePropertyName("serviceJobType");
                context.Writer.WriteStringValue(publicRequest.ServiceJobType);
            }

            if(publicRequest.IsSetServiceRequestPayload())
            {
                context.Writer.WritePropertyName("serviceRequestPayload");
                context.Writer.WriteStringValue(publicRequest.ServiceRequestPayload);
            }

            if(publicRequest.IsSetShareIdentifier())
            {
                context.Writer.WritePropertyName("shareIdentifier");
                context.Writer.WriteStringValue(publicRequest.ShareIdentifier);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTimeoutConfig())
            {
                context.Writer.WritePropertyName("timeoutConfig");
                context.Writer.WriteStartObject();

                var marshaller = ServiceJobTimeoutMarshaller.Instance;
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
            


            return request;
        }
        private static SubmitServiceJobRequestMarshaller _instance = new SubmitServiceJobRequestMarshaller();        

        internal static SubmitServiceJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubmitServiceJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}