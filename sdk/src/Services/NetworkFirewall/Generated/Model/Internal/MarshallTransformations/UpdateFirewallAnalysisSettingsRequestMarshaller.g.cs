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
    /// UpdateFirewallAnalysisSettings Request Marshaller
    /// </summary>
    public partial class UpdateFirewallAnalysisSettingsRequestMarshaller : IMarshaller<IRequest, UpdateFirewallAnalysisSettingsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFirewallAnalysisSettingsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateFirewallAnalysisSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            string target = "NetworkFirewall_20201112.UpdateFirewallAnalysisSettings";
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
            if (publicRequest.IsSetEnabledAnalysisTypes())
            {
                context.Writer.WritePropertyName("EnabledAnalysisTypes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestEnabledAnalysisTypesListValue in publicRequest.EnabledAnalysisTypes)
                {
                    context.Writer.WriteStringValue(publicRequestEnabledAnalysisTypesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetFirewallArn())
            {
                context.Writer.WritePropertyName("FirewallArn");
                context.Writer.WriteStringValue(publicRequest.FirewallArn);
            }
            if (publicRequest.IsSetFirewallName())
            {
                context.Writer.WritePropertyName("FirewallName");
                context.Writer.WriteStringValue(publicRequest.FirewallName);
            }
            if (publicRequest.IsSetUpdateToken())
            {
                context.Writer.WritePropertyName("UpdateToken");
                context.Writer.WriteStringValue(publicRequest.UpdateToken);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateFirewallAnalysisSettingsRequestMarshaller _instance = new();

        internal static UpdateFirewallAnalysisSettingsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateFirewallAnalysisSettingsRequestMarshaller Instance => _instance;
    }
}
