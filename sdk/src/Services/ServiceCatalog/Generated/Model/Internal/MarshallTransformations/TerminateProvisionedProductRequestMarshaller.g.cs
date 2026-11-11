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

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TerminateProvisionedProduct Request Marshaller
    /// </summary>
    public partial class TerminateProvisionedProductRequestMarshaller : IMarshaller<IRequest, TerminateProvisionedProductRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TerminateProvisionedProductRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(TerminateProvisionedProductRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceCatalog");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-12-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AWS242ServiceCatalogService/operation/TerminateProvisionedProduct";
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
                if (publicRequest.IsSetIgnoreErrors())
                {
                    context.Writer.WriteTextString("IgnoreErrors");
                    context.Writer.WriteBoolean(publicRequest.IgnoreErrors.Value);
                }
                if (publicRequest.IsSetProvisionedProductId())
                {
                    context.Writer.WriteTextString("ProvisionedProductId");
                    context.Writer.WriteTextString(publicRequest.ProvisionedProductId);
                }
                if (publicRequest.IsSetProvisionedProductName())
                {
                    context.Writer.WriteTextString("ProvisionedProductName");
                    context.Writer.WriteTextString(publicRequest.ProvisionedProductName);
                }
                if (publicRequest.IsSetRetainPhysicalResources())
                {
                    context.Writer.WriteTextString("RetainPhysicalResources");
                    context.Writer.WriteBoolean(publicRequest.RetainPhysicalResources.Value);
                }
                if (publicRequest.IsSetTerminateToken())
                {
                    context.Writer.WriteTextString("TerminateToken");
                    context.Writer.WriteTextString(publicRequest.TerminateToken);
                }
                else
                {
                    context.Writer.WriteTextString("TerminateToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
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

        private static readonly TerminateProvisionedProductRequestMarshaller _instance = new();

        internal static TerminateProvisionedProductRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TerminateProvisionedProductRequestMarshaller Instance => _instance;
    }
}
