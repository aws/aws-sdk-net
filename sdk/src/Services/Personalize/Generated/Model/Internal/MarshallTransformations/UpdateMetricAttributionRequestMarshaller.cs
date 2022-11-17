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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMetricAttribution Request Marshaller
    /// </summary>       
    public class UpdateMetricAttributionRequestMarshaller : IMarshaller<IRequest, UpdateMetricAttributionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMetricAttributionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMetricAttributionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Personalize");
            string target = "AmazonPersonalize.UpdateMetricAttribution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddMetrics())
                {
                    context.Writer.WritePropertyName("addMetrics");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddMetricsListValue in publicRequest.AddMetrics)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricAttributeMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddMetricsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetricAttributionArn())
                {
                    context.Writer.WritePropertyName("metricAttributionArn");
                    context.Writer.Write(publicRequest.MetricAttributionArn);
                }

                if(publicRequest.IsSetMetricsOutputConfig())
                {
                    context.Writer.WritePropertyName("metricsOutputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricAttributionOutputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetricsOutputConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRemoveMetrics())
                {
                    context.Writer.WritePropertyName("removeMetrics");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoveMetricsListValue in publicRequest.RemoveMetrics)
                    {
                            context.Writer.Write(publicRequestRemoveMetricsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMetricAttributionRequestMarshaller _instance = new UpdateMetricAttributionRequestMarshaller();        

        internal static UpdateMetricAttributionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMetricAttributionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}