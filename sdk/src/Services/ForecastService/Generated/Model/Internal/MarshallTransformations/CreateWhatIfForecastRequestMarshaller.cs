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
    /// CreateWhatIfForecast Request Marshaller
    /// </summary>       
    public class CreateWhatIfForecastRequestMarshaller : IMarshaller<IRequest, CreateWhatIfForecastRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWhatIfForecastRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWhatIfForecastRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastService");
            string target = "AmazonForecast.CreateWhatIfForecast";
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

                if(publicRequest.IsSetTimeSeriesReplacementsDataSource())
                {
                    context.Writer.WritePropertyName("TimeSeriesReplacementsDataSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = TimeSeriesReplacementsDataSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimeSeriesReplacementsDataSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimeSeriesTransformations())
                {
                    context.Writer.WritePropertyName("TimeSeriesTransformations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTimeSeriesTransformationsListValue in publicRequest.TimeSeriesTransformations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TimeSeriesTransformationMarshaller.Instance;
                        marshaller.Marshall(publicRequestTimeSeriesTransformationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWhatIfAnalysisArn())
                {
                    context.Writer.WritePropertyName("WhatIfAnalysisArn");
                    context.Writer.Write(publicRequest.WhatIfAnalysisArn);
                }

                if(publicRequest.IsSetWhatIfForecastName())
                {
                    context.Writer.WritePropertyName("WhatIfForecastName");
                    context.Writer.Write(publicRequest.WhatIfForecastName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateWhatIfForecastRequestMarshaller _instance = new CreateWhatIfForecastRequestMarshaller();        

        internal static CreateWhatIfForecastRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWhatIfForecastRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}