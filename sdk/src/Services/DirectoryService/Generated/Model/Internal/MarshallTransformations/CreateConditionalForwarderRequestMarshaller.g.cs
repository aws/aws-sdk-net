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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.DirectoryService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConditionalForwarder Request Marshaller
    /// </summary>
    public partial class CreateConditionalForwarderRequestMarshaller : IMarshaller<IRequest, CreateConditionalForwarderRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConditionalForwarderRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateConditionalForwarderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectoryService");
            string target = "DirectoryService_20150416.CreateConditionalForwarder";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-16";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDirectoryId())
            {
                context.Writer.WritePropertyName("DirectoryId");
                context.Writer.WriteStringValue(publicRequest.DirectoryId);
            }
            if (publicRequest.IsSetDnsIpAddrs())
            {
                context.Writer.WritePropertyName("DnsIpAddrs");
                context.Writer.WriteStartArray();
                foreach (var publicRequestDnsIpAddrsListValue in publicRequest.DnsIpAddrs)
                {
                    context.Writer.WriteStringValue(publicRequestDnsIpAddrsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDnsIpv6Addrs())
            {
                context.Writer.WritePropertyName("DnsIpv6Addrs");
                context.Writer.WriteStartArray();
                foreach (var publicRequestDnsIpv6AddrsListValue in publicRequest.DnsIpv6Addrs)
                {
                    context.Writer.WriteStringValue(publicRequestDnsIpv6AddrsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRemoteDomainName())
            {
                context.Writer.WritePropertyName("RemoteDomainName");
                context.Writer.WriteStringValue(publicRequest.RemoteDomainName);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateConditionalForwarderRequestMarshaller _instance = new();

        internal static CreateConditionalForwarderRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateConditionalForwarderRequestMarshaller Instance => _instance;
    }
}
