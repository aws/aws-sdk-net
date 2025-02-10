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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
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
namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePredictor Request Marshaller
    /// </summary>       
    public class CreatePredictorRequestMarshaller : IMarshaller<IRequest, CreatePredictorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePredictorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePredictorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastService");
            string target = "AmazonForecast.CreatePredictor";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-26";
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
            if(publicRequest.IsSetAlgorithmArn())
            {
                context.Writer.WritePropertyName("AlgorithmArn");
                context.Writer.WriteStringValue(publicRequest.AlgorithmArn);
            }

            if(publicRequest.IsSetAutoMLOverrideStrategy())
            {
                context.Writer.WritePropertyName("AutoMLOverrideStrategy");
                context.Writer.WriteStringValue(publicRequest.AutoMLOverrideStrategy);
            }

            if(publicRequest.IsSetEncryptionConfig())
            {
                context.Writer.WritePropertyName("EncryptionConfig");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEvaluationParameters())
            {
                context.Writer.WritePropertyName("EvaluationParameters");
                context.Writer.WriteStartObject();

                var marshaller = EvaluationParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.EvaluationParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFeaturizationConfig())
            {
                context.Writer.WritePropertyName("FeaturizationConfig");
                context.Writer.WriteStartObject();

                var marshaller = FeaturizationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.FeaturizationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetForecastHorizon())
            {
                context.Writer.WritePropertyName("ForecastHorizon");
                context.Writer.WriteNumberValue(publicRequest.ForecastHorizon.Value);
            }

            if(publicRequest.IsSetForecastTypes())
            {
                context.Writer.WritePropertyName("ForecastTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestForecastTypesListValue in publicRequest.ForecastTypes)
                {
                        context.Writer.WriteStringValue(publicRequestForecastTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetHPOConfig())
            {
                context.Writer.WritePropertyName("HPOConfig");
                context.Writer.WriteStartObject();

                var marshaller = HyperParameterTuningJobConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.HPOConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputDataConfig())
            {
                context.Writer.WritePropertyName("InputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = InputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOptimizationMetric())
            {
                context.Writer.WritePropertyName("OptimizationMetric");
                context.Writer.WriteStringValue(publicRequest.OptimizationMetric);
            }

            if(publicRequest.IsSetPerformAutoML())
            {
                context.Writer.WritePropertyName("PerformAutoML");
                context.Writer.WriteBooleanValue(publicRequest.PerformAutoML.Value);
            }

            if(publicRequest.IsSetPerformHPO())
            {
                context.Writer.WritePropertyName("PerformHPO");
                context.Writer.WriteBooleanValue(publicRequest.PerformHPO.Value);
            }

            if(publicRequest.IsSetPredictorName())
            {
                context.Writer.WritePropertyName("PredictorName");
                context.Writer.WriteStringValue(publicRequest.PredictorName);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTrainingParameters())
            {
                context.Writer.WritePropertyName("TrainingParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTrainingParametersKvp in publicRequest.TrainingParameters)
                {
                    context.Writer.WritePropertyName(publicRequestTrainingParametersKvp.Key);
                    var publicRequestTrainingParametersValue = publicRequestTrainingParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTrainingParametersValue);
                }
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
        private static CreatePredictorRequestMarshaller _instance = new CreatePredictorRequestMarshaller();        

        internal static CreatePredictorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePredictorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}