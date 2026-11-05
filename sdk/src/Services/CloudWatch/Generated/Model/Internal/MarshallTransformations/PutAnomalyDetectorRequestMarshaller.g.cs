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

using Amazon.CloudWatch.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAnomalyDetector Request Marshaller
    /// </summary>
    public partial class PutAnomalyDetectorRequestMarshaller : IMarshaller<IRequest, PutAnomalyDetectorRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAnomalyDetectorRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutAnomalyDetectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2010-08-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/GraniteServiceVersion20100801/operation/PutAnomalyDetector";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetConfiguration())
                {
                    context.Writer.WriteTextString("Configuration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = AnomalyDetectorConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDimensions())
                {
                    context.Writer.WriteTextString("Dimensions");
                    context.Writer.WriteStartArray(publicRequest.Dimensions.Count);
                    foreach (var publicRequestDimensionsListValue in publicRequest.Dimensions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = DimensionMarshaller.Instance;
                        marshaller.Marshall(publicRequestDimensionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetMetricCharacteristics())
                {
                    context.Writer.WriteTextString("MetricCharacteristics");
                    context.Writer.WriteStartMap(null);

                    var marshaller = MetricCharacteristicsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetricCharacteristics, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetMetricMathAnomalyDetector())
                {
                    context.Writer.WriteTextString("MetricMathAnomalyDetector");
                    context.Writer.WriteStartMap(null);

                    var marshaller = MetricMathAnomalyDetectorMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetricMathAnomalyDetector, context);

                    context.Writer.WriteEndMap();
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
                if (publicRequest.IsSetSingleMetricAnomalyDetector())
                {
                    context.Writer.WriteTextString("SingleMetricAnomalyDetector");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SingleMetricAnomalyDetectorMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SingleMetricAnomalyDetector, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetStat())
                {
                    context.Writer.WriteTextString("Stat");
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

        private static readonly PutAnomalyDetectorRequestMarshaller _instance = new();

        internal static PutAnomalyDetectorRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutAnomalyDetectorRequestMarshaller Instance => _instance;
    }
}
