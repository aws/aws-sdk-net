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

using Amazon.QBusiness.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePlugin Request Marshaller
    /// </summary>
    public partial class UpdatePluginRequestMarshaller : IMarshaller<IRequest, UpdatePluginRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePluginRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdatePluginRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetApplicationId())
            {
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            }
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));

            if (!publicRequest.IsSetPluginId())
            {
                throw new AmazonQBusinessException("Request object does not have required field PluginId set");
            }
            request.AddPathResource("{pluginId}", StringUtils.FromString(publicRequest.PluginId));

            request.ResourcePath = "/applications/{applicationId}/plugins/{pluginId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAuthConfiguration())
            {
                context.Writer.WritePropertyName("authConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PluginAuthConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AuthConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetCustomPluginConfiguration())
            {
                context.Writer.WritePropertyName("customPluginConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CustomPluginConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomPluginConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }
            if (publicRequest.IsSetServerUrl())
            {
                context.Writer.WritePropertyName("serverUrl");
                context.Writer.WriteStringValue(publicRequest.ServerUrl);
            }
            if (publicRequest.IsSetState())
            {
                context.Writer.WritePropertyName("state");
                context.Writer.WriteStringValue(publicRequest.State);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdatePluginRequestMarshaller _instance = new();

        internal static UpdatePluginRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdatePluginRequestMarshaller Instance => _instance;
    }
}
