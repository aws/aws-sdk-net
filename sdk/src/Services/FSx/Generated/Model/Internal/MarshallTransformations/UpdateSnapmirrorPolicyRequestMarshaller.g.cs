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

using Amazon.FSx.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSnapmirrorPolicy Request Marshaller
    /// </summary>
    public partial class UpdateSnapmirrorPolicyRequestMarshaller : IMarshaller<IRequest, UpdateSnapmirrorPolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSnapmirrorPolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateSnapmirrorPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FSx");
            string target = "AWSSimbaAPIService_v20180301.UpdateSnapmirrorPolicy";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-03-01";
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
            if (publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetNetworkCompressionEnabled())
            {
                context.Writer.WritePropertyName("NetworkCompressionEnabled");
                context.Writer.WriteBooleanValue(publicRequest.NetworkCompressionEnabled.Value);
            }
            if (publicRequest.IsSetRetentionRules())
            {
                context.Writer.WritePropertyName("RetentionRules");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRetentionRulesListValue in publicRequest.RetentionRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SnapmirrorPolicyRetentionRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestRetentionRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSnapmirrorPolicyId())
            {
                context.Writer.WritePropertyName("SnapmirrorPolicyId");
                context.Writer.WriteStringValue(publicRequest.SnapmirrorPolicyId);
            }
            if (publicRequest.IsSetThrottleInKbps())
            {
                context.Writer.WritePropertyName("ThrottleInKbps");
                context.Writer.WriteNumberValue(publicRequest.ThrottleInKbps.Value);
            }
            if (publicRequest.IsSetTransferSchedule())
            {
                context.Writer.WritePropertyName("TransferSchedule");
                context.Writer.WriteStringValue(publicRequest.TransferSchedule);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateSnapmirrorPolicyRequestMarshaller _instance = new();

        internal static UpdateSnapmirrorPolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateSnapmirrorPolicyRequestMarshaller Instance => _instance;
    }
}
