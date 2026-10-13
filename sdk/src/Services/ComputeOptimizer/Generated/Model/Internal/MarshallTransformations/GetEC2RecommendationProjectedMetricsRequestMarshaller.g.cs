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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetEC2RecommendationProjectedMetrics Request Marshaller
    /// </summary>
    public partial class GetEC2RecommendationProjectedMetricsRequestMarshaller : IMarshaller<IRequest, GetEC2RecommendationProjectedMetricsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetEC2RecommendationProjectedMetricsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetEC2RecommendationProjectedMetricsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizer");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/ComputeOptimizerService/operation/GetEC2RecommendationProjectedMetrics";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetEndTime())
                {
                    context.Writer.WriteTextString("endTime");
                    context.Writer.WriteDateTime(publicRequest.EndTime.Value);
                }
                if (publicRequest.IsSetInstanceArn())
                {
                    context.Writer.WriteTextString("instanceArn");
                    context.Writer.WriteTextString(publicRequest.InstanceArn);
                }
                if (publicRequest.IsSetPeriod())
                {
                    context.Writer.WriteTextString("period");
                    context.Writer.WriteInt32(publicRequest.Period.Value);
                }
                if (publicRequest.IsSetRecommendationPreferences())
                {
                    context.Writer.WriteTextString("recommendationPreferences");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RecommendationPreferencesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RecommendationPreferences, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetStartTime())
                {
                    context.Writer.WriteTextString("startTime");
                    context.Writer.WriteDateTime(publicRequest.StartTime.Value);
                }
                if (publicRequest.IsSetStat())
                {
                    context.Writer.WriteTextString("stat");
                    context.Writer.WriteTextString(publicRequest.Stat);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly GetEC2RecommendationProjectedMetricsRequestMarshaller _instance = new();

        internal static GetEC2RecommendationProjectedMetricsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetEC2RecommendationProjectedMetricsRequestMarshaller Instance => _instance;
    }
}
