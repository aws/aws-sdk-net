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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerMetrics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMakerMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchPutMetrics Request Marshaller
    /// </summary>       
    public class BatchPutMetricsRequestMarshaller : IMarshaller<IRequest, BatchPutMetricsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchPutMetricsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchPutMetricsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerMetrics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-30";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/BatchPutMetrics";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMetricData())
                {
                    context.Writer.WritePropertyName("MetricData");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetricDataListValue in publicRequest.MetricData)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RawMetricDataMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricDataListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTrialComponentName())
                {
                    context.Writer.WritePropertyName("TrialComponentName");
                    context.Writer.Write(publicRequest.TrialComponentName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchPutMetricsRequestMarshaller _instance = new BatchPutMetricsRequestMarshaller();        

        internal static BatchPutMetricsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchPutMetricsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}