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

using Amazon.Glacier.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveTagsFromVault Request Marshaller
    /// </summary>
    public partial class RemoveTagsFromVaultRequestMarshaller : IMarshaller<IRequest, RemoveTagsFromVaultRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveTagsFromVaultRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RemoveTagsFromVaultRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glacier");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-06-01";
            request.HttpMethod = "POST";

            request.AddPathResource("{accountId}", publicRequest.IsSetAccountId() ? StringUtils.FromString(publicRequest.AccountId) : string.Empty);

            if (!publicRequest.IsSetVaultName())
            {
                throw new AmazonGlacierException("Request object does not have required field VaultName set");
            }
            request.AddPathResource("{vaultName}", StringUtils.FromString(publicRequest.VaultName));

            request.AddSubResource("operation", "remove");
            request.ResourcePath = "/{accountId}/vaults/{vaultName}/tags";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetTagKeys())
            {
                context.Writer.WritePropertyName("TagKeys");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagKeysListValue in publicRequest.TagKeys)
                {
                    context.Writer.WriteStringValue(publicRequestTagKeysListValue);
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

        private static readonly RemoveTagsFromVaultRequestMarshaller _instance = new();

        internal static RemoveTagsFromVaultRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RemoveTagsFromVaultRequestMarshaller Instance => _instance;
    }
}
