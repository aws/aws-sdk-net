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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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

                if(publicRequest.IsSetScalingConfig())
                {
                    context.Writer.WritePropertyName("ScalingConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScalingConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScalingConfig, context);

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