/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCostForecast Request Marshaller
    /// </summary>       
    public class GetCostForecastRequestMarshaller : IMarshaller<IRequest, GetCostForecastRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCostForecastRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetCostForecastRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CostExplorer");
            string target = "AWSInsightsIndexService.GetCostForecast";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-25";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFilter())
                {
                    context.Writer.WritePropertyName("Filter");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExpressionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Filter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGranularity())
                {
                    context.Writer.WritePropertyName("Granularity");
                    context.Writer.Write(publicRequest.Granularity);
                }

                if(publicRequest.IsSetMetric())
                {
                    context.Writer.WritePropertyName("Metric");
                    context.Writer.Write(publicRequest.Metric);
                }

                if(publicRequest.IsSetPredictionIntervalLevel())
                {
                    context.Writer.WritePropertyName("PredictionIntervalLevel");
                    context.Writer.Write(publicRequest.PredictionIntervalLevel);
                }

                if(publicRequest.IsSetTimePeriod())
                {
                    context.Writer.WritePropertyName("TimePeriod");
                    context.Writer.WriteObjectStart();

                    var marshaller = DateIntervalMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimePeriod, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetCostForecastRequestMarshaller _instance = new GetCostForecastRequestMarshaller();        

        internal static GetCostForecastRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCostForecastRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}