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

using Amazon.PartnerCentralAccount.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralAccount.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePartner Request Marshaller
    /// </summary>
    public partial class CreatePartnerRequestMarshaller : IMarshaller<IRequest, CreatePartnerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePartnerRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreatePartnerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralAccount");
            string target = "PartnerCentralAccount.CreatePartner";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-04-04";
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
            if (publicRequest.IsSetAllianceLeadContact())
            {
                context.Writer.WritePropertyName("AllianceLeadContact");
                context.Writer.WriteStartObject();

                var marshaller = AllianceLeadContactMarshaller.Instance;
                marshaller.Marshall(publicRequest.AllianceLeadContact, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetEmailVerificationCode())
            {
                context.Writer.WritePropertyName("EmailVerificationCode");
                context.Writer.WriteStringValue(publicRequest.EmailVerificationCode);
            }
            if (publicRequest.IsSetLegalName())
            {
                context.Writer.WritePropertyName("LegalName");
                context.Writer.WriteStringValue(publicRequest.LegalName);
            }
            if (publicRequest.IsSetPrimarySolutionType())
            {
                context.Writer.WritePropertyName("PrimarySolutionType");
                context.Writer.WriteStringValue(publicRequest.PrimarySolutionType);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreatePartnerRequestMarshaller _instance = new();

        internal static CreatePartnerRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreatePartnerRequestMarshaller Instance => _instance;
    }
}
