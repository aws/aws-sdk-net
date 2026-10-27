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

using Amazon.PI.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPerformanceAnalysisReport Request Marshaller
    /// </summary>
    public partial class GetPerformanceAnalysisReportRequestMarshaller : IMarshaller<IRequest, GetPerformanceAnalysisReportRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPerformanceAnalysisReportRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetPerformanceAnalysisReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PI");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-02-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/PerformanceInsightsv20180227/operation/GetPerformanceAnalysisReport";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAcceptLanguage())
                {
                    context.Writer.WriteTextString("AcceptLanguage");
                    context.Writer.WriteTextString(publicRequest.AcceptLanguage);
                }
                if (publicRequest.IsSetAnalysisReportId())
                {
                    context.Writer.WriteTextString("AnalysisReportId");
                    context.Writer.WriteTextString(publicRequest.AnalysisReportId);
                }
                if (publicRequest.IsSetIdentifier())
                {
                    context.Writer.WriteTextString("Identifier");
                    context.Writer.WriteTextString(publicRequest.Identifier);
                }
                if (publicRequest.IsSetServiceType())
                {
                    context.Writer.WriteTextString("ServiceType");
                    context.Writer.WriteTextString(publicRequest.ServiceType);
                }
                if (publicRequest.IsSetTextFormat())
                {
                    context.Writer.WriteTextString("TextFormat");
                    context.Writer.WriteTextString(publicRequest.TextFormat);
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

        private static readonly GetPerformanceAnalysisReportRequestMarshaller _instance = new();

        internal static GetPerformanceAnalysisReportRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetPerformanceAnalysisReportRequestMarshaller Instance => _instance;
    }
}
