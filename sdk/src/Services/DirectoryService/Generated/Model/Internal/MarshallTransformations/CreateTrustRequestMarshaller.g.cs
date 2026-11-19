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

using Amazon.DirectoryService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTrust Request Marshaller
    /// </summary>
    public partial class CreateTrustRequestMarshaller : IMarshaller<IRequest, CreateTrustRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrustRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateTrustRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectoryService");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-16";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/DirectoryService_20150416/operation/CreateTrust";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetConditionalForwarderIpAddrs())
                {
                    context.Writer.WriteTextString("ConditionalForwarderIpAddrs");
                    context.Writer.WriteStartArray(publicRequest.ConditionalForwarderIpAddrs.Count);
                    foreach (var publicRequestConditionalForwarderIpAddrsListValue in publicRequest.ConditionalForwarderIpAddrs)
                    {
                        context.Writer.WriteTextString(publicRequestConditionalForwarderIpAddrsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetConditionalForwarderIpv6Addrs())
                {
                    context.Writer.WriteTextString("ConditionalForwarderIpv6Addrs");
                    context.Writer.WriteStartArray(publicRequest.ConditionalForwarderIpv6Addrs.Count);
                    foreach (var publicRequestConditionalForwarderIpv6AddrsListValue in publicRequest.ConditionalForwarderIpv6Addrs)
                    {
                        context.Writer.WriteTextString(publicRequestConditionalForwarderIpv6AddrsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetDirectoryId())
                {
                    context.Writer.WriteTextString("DirectoryId");
                    context.Writer.WriteTextString(publicRequest.DirectoryId);
                }
                if (publicRequest.IsSetRemoteDomainName())
                {
                    context.Writer.WriteTextString("RemoteDomainName");
                    context.Writer.WriteTextString(publicRequest.RemoteDomainName);
                }
                if (publicRequest.IsSetSelectiveAuth())
                {
                    context.Writer.WriteTextString("SelectiveAuth");
                    context.Writer.WriteTextString(publicRequest.SelectiveAuth);
                }
                if (publicRequest.IsSetTrustDirection())
                {
                    context.Writer.WriteTextString("TrustDirection");
                    context.Writer.WriteTextString(publicRequest.TrustDirection);
                }
                if (publicRequest.IsSetTrustPassword())
                {
                    context.Writer.WriteTextString("TrustPassword");
                    context.Writer.WriteTextString(publicRequest.TrustPassword);
                }
                if (publicRequest.IsSetTrustType())
                {
                    context.Writer.WriteTextString("TrustType");
                    context.Writer.WriteTextString(publicRequest.TrustType);
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

        private static readonly CreateTrustRequestMarshaller _instance = new();

        internal static CreateTrustRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateTrustRequestMarshaller Instance => _instance;
    }
}
