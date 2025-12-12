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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetInsightRuleReport Request Marshaller
    /// </summary>       
    public class GetInsightRuleReportRequestMarshaller : IMarshaller<IRequest, GetInsightRuleReportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetInsightRuleReportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetInsightRuleReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GraniteServiceVersion20100801/operation/GetInsightRuleReport";
            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2010-08-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetEndTime())
                {
                    context.Writer.WriteTextString("EndTime");
                    context.Writer.WriteDateTime(publicRequest.EndTime.Value);
                }
                if (publicRequest.IsSetMaxContributorCount())
                {
                    context.Writer.WriteTextString("MaxContributorCount");
                    context.Writer.WriteInt32(publicRequest.MaxContributorCount.Value);
                }
                if (publicRequest.IsSetMetrics())
                {
                    context.Writer.WriteTextString("Metrics");
                    context.Writer.WriteStartArray(publicRequest.Metrics.Count);
                    foreach(var publicRequestMetricsListValue in publicRequest.Metrics)
                    {
                            context.Writer.WriteTextString(publicRequestMetricsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetOrderBy())
                {
                    context.Writer.WriteTextString("OrderBy");
                    context.Writer.WriteTextString(publicRequest.OrderBy);
                }
                if (publicRequest.IsSetPeriod())
                {
                    context.Writer.WriteTextString("Period");
                    context.Writer.WriteInt32(publicRequest.Period.Value);
                }
                if (publicRequest.IsSetRuleName())
                {
                    context.Writer.WriteTextString("RuleName");
                    context.Writer.WriteTextString(publicRequest.RuleName);
                }
                if (publicRequest.IsSetStartTime())
                {
                    context.Writer.WriteTextString("StartTime");
                    context.Writer.WriteDateTime(publicRequest.StartTime.Value);
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static GetInsightRuleReportRequestMarshaller _instance = new GetInsightRuleReportRequestMarshaller();        

        internal static GetInsightRuleReportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetInsightRuleReportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}