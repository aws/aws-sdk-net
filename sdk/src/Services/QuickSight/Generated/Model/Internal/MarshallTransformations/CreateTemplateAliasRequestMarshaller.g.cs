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

using Amazon.QuickSight.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTemplateAlias Request Marshaller
    /// </summary>
    public partial class CreateTemplateAliasRequestMarshaller : IMarshaller<IRequest, CreateTemplateAliasRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTemplateAliasRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateTemplateAliasRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAliasName())
            {
                throw new AmazonQuickSightException("Request object does not have required field AliasName set");
            }
            request.AddPathResource("{AliasName}", StringUtils.FromString(publicRequest.AliasName));

            if (!publicRequest.IsSetAwsAccountId())
            {
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            }
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));

            if (!publicRequest.IsSetTemplateId())
            {
                throw new AmazonQuickSightException("Request object does not have required field TemplateId set");
            }
            request.AddPathResource("{TemplateId}", StringUtils.FromString(publicRequest.TemplateId));

            request.ResourcePath = "/accounts/{AwsAccountId}/templates/{TemplateId}/aliases/{AliasName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetTemplateVersionNumber())
            {
                context.Writer.WritePropertyName("TemplateVersionNumber");
                context.Writer.WriteNumberValue(publicRequest.TemplateVersionNumber.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateTemplateAliasRequestMarshaller _instance = new();

        internal static CreateTemplateAliasRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateTemplateAliasRequestMarshaller Instance => _instance;
    }
}
