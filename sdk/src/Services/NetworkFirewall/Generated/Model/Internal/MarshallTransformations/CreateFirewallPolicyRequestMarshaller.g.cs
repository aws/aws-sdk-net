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

using Amazon.NetworkFirewall.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFirewallPolicy Request Marshaller
    /// </summary>
    public partial class CreateFirewallPolicyRequestMarshaller : IMarshaller<IRequest, CreateFirewallPolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFirewallPolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateFirewallPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            string target = "NetworkFirewall_20201112.CreateFirewallPolicy";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
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
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("DryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }
            if (publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("EncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetFirewallPolicy())
            {
                context.Writer.WritePropertyName("FirewallPolicy");
                context.Writer.WriteStartObject();

                var marshaller = FirewallPolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.FirewallPolicy, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetFirewallPolicyName())
            {
                context.Writer.WritePropertyName("FirewallPolicyName");
                context.Writer.WriteStringValue(publicRequest.FirewallPolicyName);
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

        private static readonly CreateFirewallPolicyRequestMarshaller _instance = new();

        internal static CreateFirewallPolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateFirewallPolicyRequestMarshaller Instance => _instance;
    }
}
