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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
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
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMLTransform Request Marshaller
    /// </summary>       
    public class UpdateMLTransformRequestMarshaller : IMarshaller<IRequest, UpdateMLTransformRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMLTransformRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMLTransformRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.UpdateMLTransform";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
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
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetGlueVersion())
            {
                context.Writer.WritePropertyName("GlueVersion");
                context.Writer.WriteStringValue(publicRequest.GlueVersion);
            }

            if(publicRequest.IsSetMaxCapacity())
            {
                context.Writer.WritePropertyName("MaxCapacity");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.MaxCapacity.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.MaxCapacity.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.MaxCapacity.Value);
                }
            }

            if(publicRequest.IsSetMaxRetries())
            {
                context.Writer.WritePropertyName("MaxRetries");
                context.Writer.WriteNumberValue(publicRequest.MaxRetries.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNumberOfWorkers())
            {
                context.Writer.WritePropertyName("NumberOfWorkers");
                context.Writer.WriteNumberValue(publicRequest.NumberOfWorkers.Value);
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();

                var marshaller = TransformParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.Parameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.WriteNumberValue(publicRequest.Timeout.Value);
            }

            if(publicRequest.IsSetTransformId())
            {
                context.Writer.WritePropertyName("TransformId");
                context.Writer.WriteStringValue(publicRequest.TransformId);
            }

            if(publicRequest.IsSetWorkerType())
            {
                context.Writer.WritePropertyName("WorkerType");
                context.Writer.WriteStringValue(publicRequest.WorkerType);
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
        private static UpdateMLTransformRequestMarshaller _instance = new UpdateMLTransformRequestMarshaller();        

        internal static UpdateMLTransformRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMLTransformRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}