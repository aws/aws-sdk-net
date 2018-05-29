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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PI.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeDimensionKeys Request Marshaller
    /// </summary>       
    public class DescribeDimensionKeysRequestMarshaller : IMarshaller<IRequest, DescribeDimensionKeysRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeDimensionKeysRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeDimensionKeysRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PI");
            string target = "PerformanceInsightsv20180227.DescribeDimensionKeys";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndTime())
                {
                    context.Writer.WritePropertyName("EndTime");
                    context.Writer.Write(publicRequest.EndTime);
                }

                if(publicRequest.IsSetFilter())
                {
                    context.Writer.WritePropertyName("Filter");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFilterKvp in publicRequest.Filter)
                    {
                        context.Writer.WritePropertyName(publicRequestFilterKvp.Key);
                        var publicRequestFilterValue = publicRequestFilterKvp.Value;

                            context.Writer.Write(publicRequestFilterValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGroupBy())
                {
                    context.Writer.WritePropertyName("GroupBy");
                    context.Writer.WriteObjectStart();

                    var marshaller = DimensionGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GroupBy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIdentifier())
                {
                    context.Writer.WritePropertyName("Identifier");
                    context.Writer.Write(publicRequest.Identifier);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetMetric())
                {
                    context.Writer.WritePropertyName("Metric");
                    context.Writer.Write(publicRequest.Metric);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetPartitionBy())
                {
                    context.Writer.WritePropertyName("PartitionBy");
                    context.Writer.WriteObjectStart();

                    var marshaller = DimensionGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PartitionBy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPeriodInSeconds())
                {
                    context.Writer.WritePropertyName("PeriodInSeconds");
                    context.Writer.Write(publicRequest.PeriodInSeconds);
                }

                if(publicRequest.IsSetServiceType())
                {
                    context.Writer.WritePropertyName("ServiceType");
                    context.Writer.Write(publicRequest.ServiceType);
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("StartTime");
                    context.Writer.Write(publicRequest.StartTime);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeDimensionKeysRequestMarshaller _instance = new DescribeDimensionKeysRequestMarshaller();        

        internal static DescribeDimensionKeysRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDimensionKeysRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}