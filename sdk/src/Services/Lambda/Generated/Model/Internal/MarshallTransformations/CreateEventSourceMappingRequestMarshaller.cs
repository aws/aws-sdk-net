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
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEventSourceMapping Request Marshaller
    /// </summary>       
    public class CreateEventSourceMappingRequestMarshaller : IMarshaller<IRequest, CreateEventSourceMappingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEventSourceMappingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEventSourceMappingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2015-03-31/event-source-mappings/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAmazonManagedKafkaEventSourceConfig())
                {
                    context.Writer.WritePropertyName("AmazonManagedKafkaEventSourceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AmazonManagedKafkaEventSourceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AmazonManagedKafkaEventSourceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBatchSize())
                {
                    context.Writer.WritePropertyName("BatchSize");
                    context.Writer.Write(publicRequest.BatchSize);
                }

                if(publicRequest.IsSetBisectBatchOnFunctionError())
                {
                    context.Writer.WritePropertyName("BisectBatchOnFunctionError");
                    context.Writer.Write(publicRequest.BisectBatchOnFunctionError);
                }

                if(publicRequest.IsSetDestinationConfig())
                {
                    context.Writer.WritePropertyName("DestinationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DestinationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DestinationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDocumentDBEventSourceConfig())
                {
                    context.Writer.WritePropertyName("DocumentDBEventSourceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DocumentDBEventSourceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DocumentDBEventSourceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEnabled())
                {
                    context.Writer.WritePropertyName("Enabled");
                    context.Writer.Write(publicRequest.Enabled);
                }

                if(publicRequest.IsSetEventSourceArn())
                {
                    context.Writer.WritePropertyName("EventSourceArn");
                    context.Writer.Write(publicRequest.EventSourceArn);
                }

                if(publicRequest.IsSetFilterCriteria())
                {
                    context.Writer.WritePropertyName("FilterCriteria");
                    context.Writer.WriteObjectStart();

                    var marshaller = FilterCriteriaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FilterCriteria, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFunctionName())
                {
                    context.Writer.WritePropertyName("FunctionName");
                    context.Writer.Write(publicRequest.FunctionName);
                }

                if(publicRequest.IsSetFunctionResponseTypes())
                {
                    context.Writer.WritePropertyName("FunctionResponseTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFunctionResponseTypesListValue in publicRequest.FunctionResponseTypes)
                    {
                            context.Writer.Write(publicRequestFunctionResponseTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaximumBatchingWindowInSeconds())
                {
                    context.Writer.WritePropertyName("MaximumBatchingWindowInSeconds");
                    context.Writer.Write(publicRequest.MaximumBatchingWindowInSeconds);
                }

                if(publicRequest.IsSetMaximumRecordAgeInSeconds())
                {
                    context.Writer.WritePropertyName("MaximumRecordAgeInSeconds");
                    context.Writer.Write(publicRequest.MaximumRecordAgeInSeconds);
                }

                if(publicRequest.IsSetMaximumRetryAttempts())
                {
                    context.Writer.WritePropertyName("MaximumRetryAttempts");
                    context.Writer.Write(publicRequest.MaximumRetryAttempts);
                }

                if(publicRequest.IsSetParallelizationFactor())
                {
                    context.Writer.WritePropertyName("ParallelizationFactor");
                    context.Writer.Write(publicRequest.ParallelizationFactor);
                }

                if(publicRequest.IsSetQueues())
                {
                    context.Writer.WritePropertyName("Queues");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestQueuesListValue in publicRequest.Queues)
                    {
                            context.Writer.Write(publicRequestQueuesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetScalingConfig())
                {
                    context.Writer.WritePropertyName("ScalingConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScalingConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScalingConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSelfManagedEventSource())
                {
                    context.Writer.WritePropertyName("SelfManagedEventSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = SelfManagedEventSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SelfManagedEventSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSelfManagedKafkaEventSourceConfig())
                {
                    context.Writer.WritePropertyName("SelfManagedKafkaEventSourceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = SelfManagedKafkaEventSourceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SelfManagedKafkaEventSourceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceAccessConfigurations())
                {
                    context.Writer.WritePropertyName("SourceAccessConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceAccessConfigurationsListValue in publicRequest.SourceAccessConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SourceAccessConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourceAccessConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStartingPosition())
                {
                    context.Writer.WritePropertyName("StartingPosition");
                    context.Writer.Write(publicRequest.StartingPosition);
                }

                if(publicRequest.IsSetStartingPositionTimestamp())
                {
                    context.Writer.WritePropertyName("StartingPositionTimestamp");
                    context.Writer.Write(publicRequest.StartingPositionTimestamp);
                }

                if(publicRequest.IsSetTopics())
                {
                    context.Writer.WritePropertyName("Topics");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTopicsListValue in publicRequest.Topics)
                    {
                            context.Writer.Write(publicRequestTopicsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTumblingWindowInSeconds())
                {
                    context.Writer.WritePropertyName("TumblingWindowInSeconds");
                    context.Writer.Write(publicRequest.TumblingWindowInSeconds);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEventSourceMappingRequestMarshaller _instance = new CreateEventSourceMappingRequestMarshaller();        

        internal static CreateEventSourceMappingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEventSourceMappingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}