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
using ThirdParty.Json.LitJson;

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
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlgorithmArn())
                {
                    context.Writer.WritePropertyName("AlgorithmArn");
                    context.Writer.Write(publicRequest.AlgorithmArn);
                }

                if(publicRequest.IsSetEncryptionConfig())
                {
                    context.Writer.WritePropertyName("EncryptionConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEvaluationParameters())
                {
                    context.Writer.WritePropertyName("EvaluationParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EvaluationParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFeaturizationConfig())
                {
                    context.Writer.WritePropertyName("FeaturizationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = FeaturizationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FeaturizationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetForecastHorizon())
                {
                    context.Writer.WritePropertyName("ForecastHorizon");
                    context.Writer.Write(publicRequest.ForecastHorizon);
                }

                if(publicRequest.IsSetForecastTypes())
                {
                    context.Writer.WritePropertyName("ForecastTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestForecastTypesListValue in publicRequest.ForecastTypes)
                    {
                            context.Writer.Write(publicRequestForecastTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetHPOConfig())
                {
                    context.Writer.WritePropertyName("HPOConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = HyperParameterTuningJobConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HPOConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputDataConfig())
                {
                    context.Writer.WritePropertyName("InputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = InputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPerformAutoML())
                {
                    context.Writer.WritePropertyName("PerformAutoML");
                    context.Writer.Write(publicRequest.PerformAutoML);
                }

                if(publicRequest.IsSetPerformHPO())
                {
                    context.Writer.WritePropertyName("PerformHPO");
                    context.Writer.Write(publicRequest.PerformHPO);
                }

                if(publicRequest.IsSetPredictorName())
                {
                    context.Writer.WritePropertyName("PredictorName");
                    context.Writer.Write(publicRequest.PredictorName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTrainingParameters())
                {
                    context.Writer.WritePropertyName("TrainingParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTrainingParametersKvp in publicRequest.TrainingParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestTrainingParametersKvp.Key);
                        var publicRequestTrainingParametersValue = publicRequestTrainingParametersKvp.Value;

                            context.Writer.Write(publicRequestTrainingParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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