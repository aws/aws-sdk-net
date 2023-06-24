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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAnomaliesForInsight Request Marshaller
    /// </summary>       
    public class ListAnomaliesForInsightRequestMarshaller : IMarshaller<IRequest, ListAnomaliesForInsightRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAnomaliesForInsightRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAnomaliesForInsightRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DevOpsGuru");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-12-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetInsightId())
                throw new AmazonDevOpsGuruException("Request object does not have required field InsightId set");
            request.AddPathResource("{InsightId}", StringUtils.FromString(publicRequest.InsightId));
            request.ResourcePath = "/anomalies/insight/{InsightId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountId())
                {
                    context.Writer.WritePropertyName("AccountId");
                    context.Writer.Write(publicRequest.AccountId);
                }

                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("Filters");
                    context.Writer.WriteObjectStart();

                    var marshaller = ListAnomaliesForInsightFiltersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Filters, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetStartTimeRange())
                {
                    context.Writer.WritePropertyName("StartTimeRange");
                    context.Writer.WriteObjectStart();

                    var marshaller = StartTimeRangeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StartTimeRange, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListAnomaliesForInsightRequestMarshaller _instance = new ListAnomaliesForInsightRequestMarshaller();        

        internal static ListAnomaliesForInsightRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAnomaliesForInsightRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}