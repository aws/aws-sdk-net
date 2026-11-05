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

using Amazon.Route53Domains.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDomainContact Request Marshaller
    /// </summary>
    public partial class UpdateDomainContactRequestMarshaller : IMarshaller<IRequest, UpdateDomainContactRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDomainContactRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateDomainContactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Domains");
            string target = "Route53Domains_v20140515.UpdateDomainContact";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-05-15";
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
            if (publicRequest.IsSetAdminContact())
            {
                context.Writer.WritePropertyName("AdminContact");
                context.Writer.WriteStartObject();

                var marshaller = ContactDetailMarshaller.Instance;
                marshaller.Marshall(publicRequest.AdminContact, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetBillingContact())
            {
                context.Writer.WritePropertyName("BillingContact");
                context.Writer.WriteStartObject();

                var marshaller = ContactDetailMarshaller.Instance;
                marshaller.Marshall(publicRequest.BillingContact, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetConsent())
            {
                context.Writer.WritePropertyName("Consent");
                context.Writer.WriteStartObject();

                var marshaller = ConsentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Consent, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.WriteStringValue(publicRequest.DomainName);
            }
            if (publicRequest.IsSetRegistrantContact())
            {
                context.Writer.WritePropertyName("RegistrantContact");
                context.Writer.WriteStartObject();

                var marshaller = ContactDetailMarshaller.Instance;
                marshaller.Marshall(publicRequest.RegistrantContact, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTechContact())
            {
                context.Writer.WritePropertyName("TechContact");
                context.Writer.WriteStartObject();

                var marshaller = ContactDetailMarshaller.Instance;
                marshaller.Marshall(publicRequest.TechContact, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateDomainContactRequestMarshaller _instance = new();

        internal static UpdateDomainContactRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateDomainContactRequestMarshaller Instance => _instance;
    }
}
