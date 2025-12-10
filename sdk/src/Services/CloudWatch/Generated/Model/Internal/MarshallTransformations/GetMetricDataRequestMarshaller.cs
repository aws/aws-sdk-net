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
    /// GetMetricData Request Marshaller
    /// </summary>       
    public class GetMetricDataRequestMarshaller : IMarshaller<IRequest, GetMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMetricDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMetricDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            string target = "GraniteServiceVersion20100801.GetMetricData";
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
                if(publicRequest.IsSetEndTimeUtc())
                {
                    context.Writer.WritePropertyName("EndTime");
                    context.Writer.Write(publicRequest.EndTimeUtc);
                }

                if(publicRequest.IsSetLabelOptions())
                {
                    context.Writer.WritePropertyName("LabelOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = LabelOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LabelOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxDatapoints())
                {
                    context.Writer.WritePropertyName("MaxDatapoints");
                    context.Writer.Write(publicRequest.MaxDatapoints);
                }

                if(publicRequest.IsSetMetricDataQueries())
                {
                    context.Writer.WritePropertyName("MetricDataQueries");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMetricDataQueriesListValue in publicRequest.MetricDataQueries)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MetricDataQueryMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricDataQueriesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetScanBy())
                {
                    context.Writer.WritePropertyName("ScanBy");
                    context.Writer.Write(publicRequest.ScanBy);
                }

                if(publicRequest.IsSetStartTimeUtc())
                {
                    context.Writer.WritePropertyName("StartTime");
                    context.Writer.Write(publicRequest.StartTimeUtc);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetMetricDataRequestMarshaller _instance = new GetMetricDataRequestMarshaller();        

        internal static GetMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}