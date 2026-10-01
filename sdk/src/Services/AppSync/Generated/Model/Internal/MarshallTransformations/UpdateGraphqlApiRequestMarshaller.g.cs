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

using Amazon.AppSync.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGraphqlApi Request Marshaller
    /// </summary>
    public partial class UpdateGraphqlApiRequestMarshaller : IMarshaller<IRequest, UpdateGraphqlApiRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGraphqlApiRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateGraphqlApiRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApiId())
            {
                throw new AmazonAppSyncException("Request object does not have required field ApiId set");
            }
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));

            request.ResourcePath = "/v1/apis/{apiId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAdditionalAuthenticationProviders())
            {
                context.Writer.WritePropertyName("additionalAuthenticationProviders");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAdditionalAuthenticationProvidersListValue in publicRequest.AdditionalAuthenticationProviders)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdditionalAuthenticationProviderMarshaller.Instance;
                    marshaller.Marshall(publicRequestAdditionalAuthenticationProvidersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetAuthenticationType())
            {
                context.Writer.WritePropertyName("authenticationType");
                context.Writer.WriteStringValue(publicRequest.AuthenticationType);
            }
            if (publicRequest.IsSetEnhancedMetricsConfig())
            {
                context.Writer.WritePropertyName("enhancedMetricsConfig");
                context.Writer.WriteStartObject();

                var marshaller = EnhancedMetricsConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.EnhancedMetricsConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetIntrospectionConfig())
            {
                context.Writer.WritePropertyName("introspectionConfig");
                context.Writer.WriteStringValue(publicRequest.IntrospectionConfig);
            }
            if (publicRequest.IsSetLambdaAuthorizerConfig())
            {
                context.Writer.WritePropertyName("lambdaAuthorizerConfig");
                context.Writer.WriteStartObject();

                var marshaller = LambdaAuthorizerConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.LambdaAuthorizerConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetLogConfig())
            {
                context.Writer.WritePropertyName("logConfig");
                context.Writer.WriteStartObject();

                var marshaller = LogConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetMergedApiExecutionRoleArn())
            {
                context.Writer.WritePropertyName("mergedApiExecutionRoleArn");
                context.Writer.WriteStringValue(publicRequest.MergedApiExecutionRoleArn);
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetOpenIDConnectConfig())
            {
                context.Writer.WritePropertyName("openIDConnectConfig");
                context.Writer.WriteStartObject();

                var marshaller = OpenIDConnectConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OpenIDConnectConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetOwnerContact())
            {
                context.Writer.WritePropertyName("ownerContact");
                context.Writer.WriteStringValue(publicRequest.OwnerContact);
            }
            if (publicRequest.IsSetQueryDepthLimit())
            {
                context.Writer.WritePropertyName("queryDepthLimit");
                context.Writer.WriteNumberValue(publicRequest.QueryDepthLimit.Value);
            }
            if (publicRequest.IsSetResolverCountLimit())
            {
                context.Writer.WritePropertyName("resolverCountLimit");
                context.Writer.WriteNumberValue(publicRequest.ResolverCountLimit.Value);
            }
            if (publicRequest.IsSetUserPoolConfig())
            {
                context.Writer.WritePropertyName("userPoolConfig");
                context.Writer.WriteStartObject();

                var marshaller = UserPoolConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.UserPoolConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetXrayEnabled())
            {
                context.Writer.WritePropertyName("xrayEnabled");
                context.Writer.WriteBooleanValue(publicRequest.XrayEnabled.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateGraphqlApiRequestMarshaller _instance = new();

        internal static UpdateGraphqlApiRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateGraphqlApiRequestMarshaller Instance => _instance;
    }
}
