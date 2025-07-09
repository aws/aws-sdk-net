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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
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
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEventSourceMapping Request Marshaller
    /// </summary>       
    public class UpdateEventSourceMappingRequestMarshaller : IMarshaller<IRequest, UpdateEventSourceMappingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEventSourceMappingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEventSourceMappingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetUUID())
                throw new AmazonLambdaException("Request object does not have required field UUID set");
            request.AddPathResource("{UUID}", StringUtils.FromString(publicRequest.UUID));
            request.ResourcePath = "/2015-03-31/event-source-mappings/{UUID}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAmazonManagedKafkaEventSourceConfig())
            {
                context.Writer.WritePropertyName("AmazonManagedKafkaEventSourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = AmazonManagedKafkaEventSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AmazonManagedKafkaEventSourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBatchSize())
            {
                context.Writer.WritePropertyName("BatchSize");
                context.Writer.WriteNumberValue(publicRequest.BatchSize.Value);
            }

            if(publicRequest.IsSetBisectBatchOnFunctionError())
            {
                context.Writer.WritePropertyName("BisectBatchOnFunctionError");
                context.Writer.WriteBooleanValue(publicRequest.BisectBatchOnFunctionError.Value);
            }

            if(publicRequest.IsSetDestinationConfig())
            {
                context.Writer.WritePropertyName("DestinationConfig");
                context.Writer.WriteStartObject();

                var marshaller = DestinationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDocumentDBEventSourceConfig())
            {
                context.Writer.WritePropertyName("DocumentDBEventSourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = DocumentDBEventSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DocumentDBEventSourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(publicRequest.Enabled.Value);
            }

            if(publicRequest.IsSetFilterCriteria())
            {
                context.Writer.WritePropertyName("FilterCriteria");
                context.Writer.WriteStartObject();

                var marshaller = FilterCriteriaMarshaller.Instance;
                marshaller.Marshall(publicRequest.FilterCriteria, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFunctionName())
            {
                context.Writer.WritePropertyName("FunctionName");
                context.Writer.WriteStringValue(publicRequest.FunctionName);
            }

            if(publicRequest.IsSetFunctionResponseTypes())
            {
                context.Writer.WritePropertyName("FunctionResponseTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFunctionResponseTypesListValue in publicRequest.FunctionResponseTypes)
                {
                        context.Writer.WriteStringValue(publicRequestFunctionResponseTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetKMSKeyArn())
            {
                context.Writer.WritePropertyName("KMSKeyArn");
                context.Writer.WriteStringValue(publicRequest.KMSKeyArn);
            }

            if(publicRequest.IsSetMaximumBatchingWindowInSeconds())
            {
                context.Writer.WritePropertyName("MaximumBatchingWindowInSeconds");
                context.Writer.WriteNumberValue(publicRequest.MaximumBatchingWindowInSeconds.Value);
            }

            if(publicRequest.IsSetMaximumRecordAgeInSeconds())
            {
                context.Writer.WritePropertyName("MaximumRecordAgeInSeconds");
                context.Writer.WriteNumberValue(publicRequest.MaximumRecordAgeInSeconds.Value);
            }

            if(publicRequest.IsSetMaximumRetryAttempts())
            {
                context.Writer.WritePropertyName("MaximumRetryAttempts");
                context.Writer.WriteNumberValue(publicRequest.MaximumRetryAttempts.Value);
            }

            if(publicRequest.IsSetMetricsConfig())
            {
                context.Writer.WritePropertyName("MetricsConfig");
                context.Writer.WriteStartObject();

                var marshaller = EventSourceMappingMetricsConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.MetricsConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetParallelizationFactor())
            {
                context.Writer.WritePropertyName("ParallelizationFactor");
                context.Writer.WriteNumberValue(publicRequest.ParallelizationFactor.Value);
            }

            if(publicRequest.IsSetProvisionedPollerConfig())
            {
                context.Writer.WritePropertyName("ProvisionedPollerConfig");
                context.Writer.WriteStartObject();

                var marshaller = ProvisionedPollerConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ProvisionedPollerConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScalingConfig())
            {
                context.Writer.WritePropertyName("ScalingConfig");
                context.Writer.WriteStartObject();

                var marshaller = ScalingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScalingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSelfManagedKafkaEventSourceConfig())
            {
                context.Writer.WritePropertyName("SelfManagedKafkaEventSourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = SelfManagedKafkaEventSourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SelfManagedKafkaEventSourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceAccessConfigurations())
            {
                context.Writer.WritePropertyName("SourceAccessConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourceAccessConfigurationsListValue in publicRequest.SourceAccessConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SourceAccessConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestSourceAccessConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTumblingWindowInSeconds())
            {
                context.Writer.WritePropertyName("TumblingWindowInSeconds");
                context.Writer.WriteNumberValue(publicRequest.TumblingWindowInSeconds.Value);
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
        private static UpdateEventSourceMappingRequestMarshaller _instance = new UpdateEventSourceMappingRequestMarshaller();        

        internal static UpdateEventSourceMappingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEventSourceMappingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}