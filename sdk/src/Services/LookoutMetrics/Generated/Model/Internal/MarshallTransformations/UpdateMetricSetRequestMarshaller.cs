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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMetricSet Request Marshaller
    /// </summary>       
    public class UpdateMetricSetRequestMarshaller : IMarshaller<IRequest, UpdateMetricSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMetricSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMetricSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutMetrics");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateMetricSet";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDimensionFilterList())
                {
                    context.Writer.WritePropertyName("DimensionFilterList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDimensionFilterListListValue in publicRequest.DimensionFilterList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricSetDimensionFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestDimensionFilterListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDimensionList())
                {
                    context.Writer.WritePropertyName("DimensionList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDimensionListListValue in publicRequest.DimensionList)
                    {
                            context.Writer.Write(publicRequestDimensionListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetricList())
                {
                    context.Writer.WritePropertyName("MetricList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetricListListValue in publicRequest.MetricList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetricSetArn())
                {
                    context.Writer.WritePropertyName("MetricSetArn");
                    context.Writer.Write(publicRequest.MetricSetArn);
                }

                if(publicRequest.IsSetMetricSetDescription())
                {
                    context.Writer.WritePropertyName("MetricSetDescription");
                    context.Writer.Write(publicRequest.MetricSetDescription);
                }

                if(publicRequest.IsSetMetricSetFrequency())
                {
                    context.Writer.WritePropertyName("MetricSetFrequency");
                    context.Writer.Write(publicRequest.MetricSetFrequency);
                }

                if(publicRequest.IsSetMetricSource())
                {
                    context.Writer.WritePropertyName("MetricSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetricSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOffset())
                {
                    context.Writer.WritePropertyName("Offset");
                    context.Writer.Write(publicRequest.Offset);
                }

                if(publicRequest.IsSetTimestampColumn())
                {
                    context.Writer.WritePropertyName("TimestampColumn");
                    context.Writer.WriteObjectStart();

                    var marshaller = TimestampColumnMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimestampColumn, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMetricSetRequestMarshaller _instance = new UpdateMetricSetRequestMarshaller();        

        internal static UpdateMetricSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMetricSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}