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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAnomalyDetector Request Marshaller
    /// </summary>       
    public class PutAnomalyDetectorRequestMarshaller : IMarshaller<IRequest, PutAnomalyDetectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAnomalyDetectorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAnomalyDetectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            string target = "GraniteServiceVersion20100801.PutAnomalyDetector";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2010-08-01";
            request.HttpMethod = "POST";

            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("Configuration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AnomalyDetectorConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDimensions())
                {
                    context.Writer.WritePropertyName("Dimensions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDimensionsListValue in publicRequest.Dimensions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DimensionMarshaller.Instance;
                        marshaller.Marshall(publicRequestDimensionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetricCharacteristics())
                {
                    context.Writer.WritePropertyName("MetricCharacteristics");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricCharacteristicsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetricCharacteristics, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMetricMathAnomalyDetector())
                {
                    context.Writer.WritePropertyName("MetricMathAnomalyDetector");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricMathAnomalyDetectorMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetricMathAnomalyDetector, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMetricName())
                {
                    context.Writer.WritePropertyName("MetricName");
                    context.Writer.Write(publicRequest.MetricName);
                }

                if(publicRequest.IsSetNamespace())
                {
                    context.Writer.WritePropertyName("Namespace");
                    context.Writer.Write(publicRequest.Namespace);
                }

                if(publicRequest.IsSetSingleMetricAnomalyDetector())
                {
                    context.Writer.WritePropertyName("SingleMetricAnomalyDetector");
                    context.Writer.WriteObjectStart();

                    var marshaller = SingleMetricAnomalyDetectorMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SingleMetricAnomalyDetector, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStat())
                {
                    context.Writer.WritePropertyName("Stat");
                    context.Writer.Write(publicRequest.Stat);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutAnomalyDetectorRequestMarshaller _instance = new PutAnomalyDetectorRequestMarshaller();        

        internal static PutAnomalyDetectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAnomalyDetectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}