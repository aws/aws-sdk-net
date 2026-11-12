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

using Amazon.ACMPCA.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCertificateAuthority Request Marshaller
    /// </summary>
    public partial class CreateCertificateAuthorityRequestMarshaller : IMarshaller<IRequest, CreateCertificateAuthorityRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCertificateAuthorityRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateCertificateAuthorityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ACMPCA");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/ACMPrivateCA/operation/CreateCertificateAuthority";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetCertificateAuthorityConfiguration())
                {
                    context.Writer.WriteTextString("CertificateAuthorityConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CertificateAuthorityConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CertificateAuthorityConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetCertificateAuthorityType())
                {
                    context.Writer.WriteTextString("CertificateAuthorityType");
                    context.Writer.WriteTextString(publicRequest.CertificateAuthorityType);
                }
                if (publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WriteTextString("IdempotencyToken");
                    context.Writer.WriteTextString(publicRequest.IdempotencyToken);
                }
                if (publicRequest.IsSetKeyStorageSecurityStandard())
                {
                    context.Writer.WriteTextString("KeyStorageSecurityStandard");
                    context.Writer.WriteTextString(publicRequest.KeyStorageSecurityStandard);
                }
                if (publicRequest.IsSetRevocationConfiguration())
                {
                    context.Writer.WriteTextString("RevocationConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RevocationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RevocationConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetUsageMode())
                {
                    context.Writer.WriteTextString("UsageMode");
                    context.Writer.WriteTextString(publicRequest.UsageMode);
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

        private static readonly CreateCertificateAuthorityRequestMarshaller _instance = new();

        internal static CreateCertificateAuthorityRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateCertificateAuthorityRequestMarshaller Instance => _instance;
    }
}
