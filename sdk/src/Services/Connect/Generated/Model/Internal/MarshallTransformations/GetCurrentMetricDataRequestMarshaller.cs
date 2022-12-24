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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCurrentMetricData Request Marshaller
    /// </summary>       
    public class GetCurrentMetricDataRequestMarshaller : IMarshaller<IRequest, GetCurrentMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCurrentMetricDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetCurrentMetricDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/metrics/current/{InstanceId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCurrentMetrics())
                {
                    context.Writer.WritePropertyName("CurrentMetrics");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCurrentMetricsListValue in publicRequest.CurrentMetrics)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CurrentMetricMarshaller.Instance;
                        marshaller.Marshall(publicRequestCurrentMetricsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("Filters");
                    context.Writer.WriteObjectStart();

                    var marshaller = FiltersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Filters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGroupings())
                {
                    context.Writer.WritePropertyName("Groupings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGroupingsListValue in publicRequest.Groupings)
                    {
                            context.Writer.Write(publicRequestGroupingsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetSortCriteria())
                {
                    context.Writer.WritePropertyName("SortCriteria");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSortCriteriaListValue in publicRequest.SortCriteria)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CurrentMetricSortCriteriaMarshaller.Instance;
                        marshaller.Marshall(publicRequestSortCriteriaListValue, context);

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
        private static GetCurrentMetricDataRequestMarshaller _instance = new GetCurrentMetricDataRequestMarshaller();        

        internal static GetCurrentMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCurrentMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}