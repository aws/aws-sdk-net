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
    /// CreateMetricSet Request Marshaller
    /// </summary>       
    public class CreateMetricSetRequestMarshaller : IMarshaller<IRequest, CreateMetricSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMetricSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMetricSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LookoutMetrics");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateMetricSet";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAnomalyDetectorArn())
                {
                    context.Writer.WritePropertyName("AnomalyDetectorArn");
                    context.Writer.Write(publicRequest.AnomalyDetectorArn);
                }

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

                if(publicRequest.IsSetMetricSetName())
                {
                    context.Writer.WritePropertyName("MetricSetName");
                    context.Writer.Write(publicRequest.MetricSetName);
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

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimestampColumn())
                {
                    context.Writer.WritePropertyName("TimestampColumn");
                    context.Writer.WriteObjectStart();

                    var marshaller = TimestampColumnMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimestampColumn, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimezone())
                {
                    context.Writer.WritePropertyName("Timezone");
                    context.Writer.Write(publicRequest.Timezone);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMetricSetRequestMarshaller _instance = new CreateMetricSetRequestMarshaller();        

        internal static CreateMetricSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMetricSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}