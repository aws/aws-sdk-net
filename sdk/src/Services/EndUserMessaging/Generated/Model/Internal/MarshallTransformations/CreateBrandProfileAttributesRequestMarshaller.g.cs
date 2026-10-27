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

using Amazon.EndUserMessaging.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBrandProfileAttributes Request Marshaller
    /// </summary>
    public partial class CreateBrandProfileAttributesRequestMarshaller : IMarshaller<IRequest, CreateBrandProfileAttributesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBrandProfileAttributesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateBrandProfileAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EndUserMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-09-21";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetBrandProfileId())
            {
                throw new AmazonEndUserMessagingException("Request object does not have required field BrandProfileId set");
            }
            request.AddPathResource("{brandProfileId}", StringUtils.FromString(publicRequest.BrandProfileId));

            request.ResourcePath = "/v1/brand-profiles/{brandProfileId}/attributes";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAttributesListValue in publicRequest.Attributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BrandProfileAttributeInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateBrandProfileAttributesRequestMarshaller _instance = new();

        internal static CreateBrandProfileAttributesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateBrandProfileAttributesRequestMarshaller Instance => _instance;
    }
}
