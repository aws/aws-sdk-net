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
    /// CreateComputeEnvironment Request Marshaller
    /// </summary>       
    public class CreateComputeEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateComputeEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateComputeEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateComputeEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/createcomputeenvironment";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetComputeEnvironmentName())
            {
                context.Writer.WritePropertyName("computeEnvironmentName");
                context.Writer.WriteStringValue(publicRequest.ComputeEnvironmentName);
            }

            if(publicRequest.IsSetComputeResources())
            {
                context.Writer.WritePropertyName("computeResources");
                context.Writer.WriteStartObject();

                var marshaller = ComputeResourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.ComputeResources, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetContext())
            {
                context.Writer.WritePropertyName("context");
                context.Writer.WriteStringValue(publicRequest.Context);
            }

            if(publicRequest.IsSetEksConfiguration())
            {
                context.Writer.WritePropertyName("eksConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EksConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EksConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServiceRole())
            {
                context.Writer.WritePropertyName("serviceRole");
                context.Writer.WriteStringValue(publicRequest.ServiceRole);
            }

            if(publicRequest.IsSetState())
            {
                context.Writer.WritePropertyName("state");
                context.Writer.WriteStringValue(publicRequest.State);
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

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(publicRequest.Type);
            }

            if(publicRequest.IsSetUnmanagedvCpus())
            {
                context.Writer.WritePropertyName("unmanagedvCpus");
                context.Writer.WriteNumberValue(publicRequest.UnmanagedvCpus.Value);
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
        private static CreateComputeEnvironmentRequestMarshaller _instance = new CreateComputeEnvironmentRequestMarshaller();        

        internal static CreateComputeEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateComputeEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}