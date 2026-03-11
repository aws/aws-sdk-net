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
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GraniteServiceVersion20100801/operation/GetMetricData";
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
                if (publicRequest.IsSetLabelOptions())
                {
                    context.Writer.WriteTextString("LabelOptions");
                    context.Writer.WriteStartMap(null);

                    var marshaller = LabelOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LabelOptions, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetMaxDatapoints())
                {
                    context.Writer.WriteTextString("MaxDatapoints");
                    context.Writer.WriteInt32(publicRequest.MaxDatapoints.Value);
                }
                if (publicRequest.IsSetMetricDataQueries())
                {
                    context.Writer.WriteTextString("MetricDataQueries");
                    context.Writer.WriteStartArray(publicRequest.MetricDataQueries.Count);
                    foreach(var publicRequestMetricDataQueriesListValue in publicRequest.MetricDataQueries)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = MetricDataQueryMarshaller.Instance;
                        marshaller.Marshall(publicRequestMetricDataQueriesListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("NextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetScanBy())
                {
                    context.Writer.WriteTextString("ScanBy");
                    context.Writer.WriteTextString(publicRequest.ScanBy);
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