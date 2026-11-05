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

using Amazon.Lambda.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCapacityProvider Request Marshaller
    /// </summary>
    public partial class UpdateCapacityProviderRequestMarshaller : IMarshaller<IRequest, UpdateCapacityProviderRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCapacityProviderRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateCapacityProviderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetCapacityProviderName())
            {
                throw new AmazonLambdaException("Request object does not have required field CapacityProviderName set");
            }
            request.AddPathResource("{CapacityProviderName}", StringUtils.FromString(publicRequest.CapacityProviderName));

            request.ResourcePath = "/2025-11-30/capacity-providers/{CapacityProviderName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCapacityProviderScalingConfig())
            {
                context.Writer.WritePropertyName("CapacityProviderScalingConfig");
                context.Writer.WriteStartObject();

                var marshaller = CapacityProviderScalingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CapacityProviderScalingConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("PropagateTags");
                context.Writer.WriteStartObject();

                var marshaller = PropagateTagsMarshaller.Instance;
                marshaller.Marshall(publicRequest.PropagateTags, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTelemetryConfig())
            {
                context.Writer.WritePropertyName("TelemetryConfig");
                context.Writer.WriteStartObject();

                var marshaller = CapacityProviderTelemetryConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TelemetryConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateCapacityProviderRequestMarshaller _instance = new();

        internal static UpdateCapacityProviderRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateCapacityProviderRequestMarshaller Instance => _instance;
    }
}
