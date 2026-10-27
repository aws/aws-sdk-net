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

using Amazon.MarketplaceAgreement.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAgreementRequest Request Marshaller
    /// </summary>
    public partial class CreateAgreementRequestRequestMarshaller : IMarshaller<IRequest, CreateAgreementRequestRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAgreementRequestRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateAgreementRequestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceAgreement");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AWSMPCommerceService_v20200301/operation/CreateAgreementRequest";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAgreementProposalIdentifier())
                {
                    context.Writer.WriteTextString("agreementProposalIdentifier");
                    context.Writer.WriteTextString(publicRequest.AgreementProposalIdentifier);
                }
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("clientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else
                {
                    context.Writer.WriteTextString("clientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetIntent())
                {
                    context.Writer.WriteTextString("intent");
                    context.Writer.WriteTextString(publicRequest.Intent);
                }
                if (publicRequest.IsSetRequestedTerms())
                {
                    context.Writer.WriteTextString("requestedTerms");
                    context.Writer.WriteStartArray(publicRequest.RequestedTerms.Count);
                    foreach (var publicRequestRequestedTermsListValue in publicRequest.RequestedTerms)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = RequestedTermMarshaller.Instance;
                        marshaller.Marshall(publicRequestRequestedTermsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetSourceAgreementIdentifier())
                {
                    context.Writer.WriteTextString("sourceAgreementIdentifier");
                    context.Writer.WriteTextString(publicRequest.SourceAgreementIdentifier);
                }
                if (publicRequest.IsSetTaxConfiguration())
                {
                    context.Writer.WriteTextString("taxConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TaxConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TaxConfiguration, context);

                    context.Writer.WriteEndMap();
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

        private static readonly CreateAgreementRequestRequestMarshaller _instance = new();

        internal static CreateAgreementRequestRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateAgreementRequestRequestMarshaller Instance => _instance;
    }
}
