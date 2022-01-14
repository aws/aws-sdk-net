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
    /// CreateAutoPredictor Request Marshaller
    /// </summary>       
    public class CreateAutoPredictorRequestMarshaller : IMarshaller<IRequest, CreateAutoPredictorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAutoPredictorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAutoPredictorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastService");
            string target = "AmazonForecast.CreateAutoPredictor";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDataConfig())
                {
                    context.Writer.WritePropertyName("DataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEncryptionConfig())
                {
                    context.Writer.WritePropertyName("EncryptionConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExplainPredictor())
                {
                    context.Writer.WritePropertyName("ExplainPredictor");
                    context.Writer.Write(publicRequest.ExplainPredictor);
                }

                if(publicRequest.IsSetForecastDimensions())
                {
                    context.Writer.WritePropertyName("ForecastDimensions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestForecastDimensionsListValue in publicRequest.ForecastDimensions)
                    {
                            context.Writer.Write(publicRequestForecastDimensionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetForecastFrequency())
                {
                    context.Writer.WritePropertyName("ForecastFrequency");
                    context.Writer.Write(publicRequest.ForecastFrequency);
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

                if(publicRequest.IsSetOptimizationMetric())
                {
                    context.Writer.WritePropertyName("OptimizationMetric");
                    context.Writer.Write(publicRequest.OptimizationMetric);
                }

                if(publicRequest.IsSetPredictorName())
                {
                    context.Writer.WritePropertyName("PredictorName");
                    context.Writer.Write(publicRequest.PredictorName);
                }

                if(publicRequest.IsSetReferencePredictorArn())
                {
                    context.Writer.WritePropertyName("ReferencePredictorArn");
                    context.Writer.Write(publicRequest.ReferencePredictorArn);
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAutoPredictorRequestMarshaller _instance = new CreateAutoPredictorRequestMarshaller();        

        internal static CreateAutoPredictorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAutoPredictorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}