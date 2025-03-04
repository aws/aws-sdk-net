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
    /// RegisterJobDefinition Request Marshaller
    /// </summary>       
    public class RegisterJobDefinitionRequestMarshaller : IMarshaller<IRequest, RegisterJobDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterJobDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterJobDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/registerjobdefinition";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetConsumableResourceProperties())
            {
                context.Writer.WritePropertyName("consumableResourceProperties");
                context.Writer.WriteStartObject();

                var marshaller = ConsumableResourcePropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConsumableResourceProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetContainerProperties())
            {
                context.Writer.WritePropertyName("containerProperties");
                context.Writer.WriteStartObject();

                var marshaller = ContainerPropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ContainerProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEcsProperties())
            {
                context.Writer.WritePropertyName("ecsProperties");
                context.Writer.WriteStartObject();

                var marshaller = EcsPropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.EcsProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEksProperties())
            {
                context.Writer.WritePropertyName("eksProperties");
                context.Writer.WriteStartObject();

                var marshaller = EksPropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.EksProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobDefinitionName())
            {
                context.Writer.WritePropertyName("jobDefinitionName");
                context.Writer.WriteStringValue(publicRequest.JobDefinitionName);
            }

            if(publicRequest.IsSetNodeProperties())
            {
                context.Writer.WritePropertyName("nodeProperties");
                context.Writer.WriteStartObject();

                var marshaller = NodePropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.NodeProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                {
                    context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                    var publicRequestParametersValue = publicRequestParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPlatformCapabilities())
            {
                context.Writer.WritePropertyName("platformCapabilities");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPlatformCapabilitiesListValue in publicRequest.PlatformCapabilities)
                {
                        context.Writer.WriteStringValue(publicRequestPlatformCapabilitiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("propagateTags");
                context.Writer.WriteBooleanValue(publicRequest.PropagateTags.Value);
            }

            if(publicRequest.IsSetRetryStrategy())
            {
                context.Writer.WritePropertyName("retryStrategy");
                context.Writer.WriteStartObject();

                var marshaller = RetryStrategyMarshaller.Instance;
                marshaller.Marshall(publicRequest.RetryStrategy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSchedulingPriority())
            {
                context.Writer.WritePropertyName("schedulingPriority");
                context.Writer.WriteNumberValue(publicRequest.SchedulingPriority.Value);
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

            if(publicRequest.IsSetTimeout())
            {
                context.Writer.WritePropertyName("timeout");
                context.Writer.WriteStartObject();

                var marshaller = JobTimeoutMarshaller.Instance;
                marshaller.Marshall(publicRequest.Timeout, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(publicRequest.Type);
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
        private static RegisterJobDefinitionRequestMarshaller _instance = new RegisterJobDefinitionRequestMarshaller();        

        internal static RegisterJobDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterJobDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}