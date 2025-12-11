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
    /// GetMetricStatistics Request Marshaller
    /// </summary>       
    public class GetMetricStatisticsRequestMarshaller : IMarshaller<IRequest, GetMetricStatisticsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMetricStatisticsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMetricStatisticsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GraniteServiceVersion20100801/operation/GetMetricStatistics";
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
                if (publicRequest.IsSetDimensions())
                {
                    context.Writer.WriteTextString("Dimensions");
                    context.Writer.WriteStartArray(publicRequest.Dimensions.Count);
                    foreach(var publicRequestDimensionsListValue in publicRequest.Dimensions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = DimensionMarshaller.Instance;
                        marshaller.Marshall(publicRequestDimensionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEndTime())
                {
                    context.Writer.WriteTextString("EndTime");
                    context.Writer.WriteDateTime(publicRequest.EndTime.Value);
                }
                if (publicRequest.IsSetExtendedStatistics())
                {
                    context.Writer.WriteTextString("ExtendedStatistics");
                    context.Writer.WriteStartArray(publicRequest.ExtendedStatistics.Count);
                    foreach(var publicRequestExtendedStatisticsListValue in publicRequest.ExtendedStatistics)
                    {
                            context.Writer.WriteTextString(publicRequestExtendedStatisticsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetMetricName())
                {
                    context.Writer.WriteTextString("MetricName");
                    context.Writer.WriteTextString(publicRequest.MetricName);
                }
                if (publicRequest.IsSetNamespace())
                {
                    context.Writer.WriteTextString("Namespace");
                    context.Writer.WriteTextString(publicRequest.Namespace);
                }
                if (publicRequest.IsSetPeriod())
                {
                    context.Writer.WriteTextString("Period");
                    context.Writer.WriteInt32(publicRequest.Period.Value);
                }
                if (publicRequest.IsSetStartTime())
                {
                    context.Writer.WriteTextString("StartTime");
                    context.Writer.WriteDateTime(publicRequest.StartTime.Value);
                }
                if (publicRequest.IsSetStatistics())
                {
                    context.Writer.WriteTextString("Statistics");
                    context.Writer.WriteStartArray(publicRequest.Statistics.Count);
                    foreach(var publicRequestStatisticsListValue in publicRequest.Statistics)
                    {
                            context.Writer.WriteTextString(publicRequestStatisticsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetUnit())
                {
                    context.Writer.WriteTextString("Unit");
                    context.Writer.WriteTextString(publicRequest.Unit);
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
        private static GetMetricStatisticsRequestMarshaller _instance = new GetMetricStatisticsRequestMarshaller();        

        internal static GetMetricStatisticsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMetricStatisticsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}