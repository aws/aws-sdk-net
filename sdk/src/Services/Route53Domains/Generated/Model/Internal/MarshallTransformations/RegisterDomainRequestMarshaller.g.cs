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

using Amazon.Route53Domains.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterDomain Request Marshaller
    /// </summary>
    public partial class RegisterDomainRequestMarshaller : IMarshaller<IRequest, RegisterDomainRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterDomainRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RegisterDomainRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Domains");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-05-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/Route53Domains_v20140515/operation/RegisterDomain";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAdminContact())
                {
                    context.Writer.WriteTextString("AdminContact");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContactDetailMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AdminContact, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetAutoRenew())
                {
                    context.Writer.WriteTextString("AutoRenew");
                    context.Writer.WriteBoolean(publicRequest.AutoRenew.Value);
                }
                if (publicRequest.IsSetBillingContact())
                {
                    context.Writer.WriteTextString("BillingContact");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContactDetailMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BillingContact, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetConsent())
                {
                    context.Writer.WriteTextString("Consent");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ConsentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Consent, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDomainName())
                {
                    context.Writer.WriteTextString("DomainName");
                    context.Writer.WriteTextString(publicRequest.DomainName);
                }
                if (publicRequest.IsSetDurationInYears())
                {
                    context.Writer.WriteTextString("DurationInYears");
                    context.Writer.WriteInt32(publicRequest.DurationInYears.Value);
                }
                if (publicRequest.IsSetIdnLangCode())
                {
                    context.Writer.WriteTextString("IdnLangCode");
                    context.Writer.WriteTextString(publicRequest.IdnLangCode);
                }
                if (publicRequest.IsSetPrivacyProtectAdminContact())
                {
                    context.Writer.WriteTextString("PrivacyProtectAdminContact");
                    context.Writer.WriteBoolean(publicRequest.PrivacyProtectAdminContact.Value);
                }
                if (publicRequest.IsSetPrivacyProtectBillingContact())
                {
                    context.Writer.WriteTextString("PrivacyProtectBillingContact");
                    context.Writer.WriteBoolean(publicRequest.PrivacyProtectBillingContact.Value);
                }
                if (publicRequest.IsSetPrivacyProtectRegistrantContact())
                {
                    context.Writer.WriteTextString("PrivacyProtectRegistrantContact");
                    context.Writer.WriteBoolean(publicRequest.PrivacyProtectRegistrantContact.Value);
                }
                if (publicRequest.IsSetPrivacyProtectTechContact())
                {
                    context.Writer.WriteTextString("PrivacyProtectTechContact");
                    context.Writer.WriteBoolean(publicRequest.PrivacyProtectTechContact.Value);
                }
                if (publicRequest.IsSetRegistrantContact())
                {
                    context.Writer.WriteTextString("RegistrantContact");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContactDetailMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RegistrantContact, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTechContact())
                {
                    context.Writer.WriteTextString("TechContact");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ContactDetailMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TechContact, context);

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

        private static readonly RegisterDomainRequestMarshaller _instance = new();

        internal static RegisterDomainRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RegisterDomainRequestMarshaller Instance => _instance;
    }
}
