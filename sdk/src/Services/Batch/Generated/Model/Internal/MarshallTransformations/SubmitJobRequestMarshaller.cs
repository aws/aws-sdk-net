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
    /// SubmitJob Request Marshaller
    /// </summary>       
    public class SubmitJobRequestMarshaller : IMarshaller<IRequest, SubmitJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SubmitJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SubmitJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/submitjob";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetArrayProperties())
            {
                context.Writer.WritePropertyName("arrayProperties");
                context.Writer.WriteStartObject();

                var marshaller = ArrayPropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ArrayProperties, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConsumableResourcePropertiesOverride())
            {
                context.Writer.WritePropertyName("consumableResourcePropertiesOverride");
                context.Writer.WriteStartObject();

                var marshaller = ConsumableResourcePropertiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConsumableResourcePropertiesOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetContainerOverrides())
            {
                context.Writer.WritePropertyName("containerOverrides");
                context.Writer.WriteStartObject();

                var marshaller = ContainerOverridesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ContainerOverrides, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDependsOn())
            {
                context.Writer.WritePropertyName("dependsOn");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDependsOnListValue in publicRequest.DependsOn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = JobDependencyMarshaller.Instance;
                    marshaller.Marshall(publicRequestDependsOnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEcsPropertiesOverride())
            {
                context.Writer.WritePropertyName("ecsPropertiesOverride");
                context.Writer.WriteStartObject();

                var marshaller = EcsPropertiesOverrideMarshaller.Instance;
                marshaller.Marshall(publicRequest.EcsPropertiesOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEksPropertiesOverride())
            {
                context.Writer.WritePropertyName("eksPropertiesOverride");
                context.Writer.WriteStartObject();

                var marshaller = EksPropertiesOverrideMarshaller.Instance;
                marshaller.Marshall(publicRequest.EksPropertiesOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobDefinition())
            {
                context.Writer.WritePropertyName("jobDefinition");
                context.Writer.WriteStringValue(publicRequest.JobDefinition);
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

            if(publicRequest.IsSetNodeOverrides())
            {
                context.Writer.WritePropertyName("nodeOverrides");
                context.Writer.WriteStartObject();

                var marshaller = NodeOverridesMarshaller.Instance;
                marshaller.Marshall(publicRequest.NodeOverrides, context);

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

            if(publicRequest.IsSetSchedulingPriorityOverride())
            {
                context.Writer.WritePropertyName("schedulingPriorityOverride");
                context.Writer.WriteNumberValue(publicRequest.SchedulingPriorityOverride.Value);
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

            if(publicRequest.IsSetTimeout())
            {
                context.Writer.WritePropertyName("timeout");
                context.Writer.WriteStartObject();

                var marshaller = JobTimeoutMarshaller.Instance;
                marshaller.Marshall(publicRequest.Timeout, context);

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
        private static SubmitJobRequestMarshaller _instance = new SubmitJobRequestMarshaller();        

        internal static SubmitJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubmitJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}