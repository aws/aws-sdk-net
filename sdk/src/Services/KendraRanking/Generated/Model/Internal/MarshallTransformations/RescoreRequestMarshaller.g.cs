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

using Amazon.KendraRanking.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.KendraRanking.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Rescore Request Marshaller
    /// </summary>
    public partial class RescoreRequestMarshaller : IMarshaller<IRequest, RescoreRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RescoreRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RescoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KendraRanking");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-19";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AWSKendraRerankingFrontendService/operation/Rescore";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDocuments())
                {
                    context.Writer.WriteTextString("Documents");
                    context.Writer.WriteStartArray(publicRequest.Documents.Count);
                    foreach (var publicRequestDocumentsListValue in publicRequest.Documents)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = DocumentMarshaller.Instance;
                        marshaller.Marshall(publicRequestDocumentsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetRescoreExecutionPlanId())
                {
                    context.Writer.WriteTextString("RescoreExecutionPlanId");
                    context.Writer.WriteTextString(publicRequest.RescoreExecutionPlanId);
                }
                if (publicRequest.IsSetSearchQuery())
                {
                    context.Writer.WriteTextString("SearchQuery");
                    context.Writer.WriteTextString(publicRequest.SearchQuery);
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

        private static readonly RescoreRequestMarshaller _instance = new();

        internal static RescoreRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RescoreRequestMarshaller Instance => _instance;
    }
}
