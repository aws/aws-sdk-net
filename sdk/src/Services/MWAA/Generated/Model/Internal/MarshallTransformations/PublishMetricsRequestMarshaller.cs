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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MWAA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MWAA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PublishMetrics Request Marshaller
    /// </summary>       
    public class PublishMetricsRequestMarshaller : IMarshaller<IRequest, PublishMetricsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PublishMetricsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PublishMetricsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MWAA");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-01";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetEnvironmentName())
                throw new AmazonMWAAException("Request object does not have required field EnvironmentName set");
            request.AddPathResource("{EnvironmentName}", StringUtils.FromString(publicRequest.EnvironmentName));
            request.ResourcePath = "/metrics/environments/{EnvironmentName}";
            request.MarshallerVersion = 2;
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

                        var marshaller = MetricDatumMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricDataListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"ops.";

            return request;
        }
        private static PublishMetricsRequestMarshaller _instance = new PublishMetricsRequestMarshaller();        

        internal static PublishMetricsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PublishMetricsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}