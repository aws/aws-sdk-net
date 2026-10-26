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

using Amazon.Lightsail.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDistribution Request Marshaller
    /// </summary>
    public partial class UpdateDistributionRequestMarshaller : IMarshaller<IRequest, UpdateDistributionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDistributionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateDistributionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.UpdateDistribution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
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
            if (publicRequest.IsSetCacheBehaviorSettings())
            {
                context.Writer.WritePropertyName("cacheBehaviorSettings");
                context.Writer.WriteStartObject();

                var marshaller = CacheSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.CacheBehaviorSettings, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetCacheBehaviors())
            {
                context.Writer.WritePropertyName("cacheBehaviors");
                context.Writer.WriteStartArray();
                foreach (var publicRequestCacheBehaviorsListValue in publicRequest.CacheBehaviors)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CacheBehaviorPerPathMarshaller.Instance;
                    marshaller.Marshall(publicRequestCacheBehaviorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetCertificateName())
            {
                context.Writer.WritePropertyName("certificateName");
                context.Writer.WriteStringValue(publicRequest.CertificateName);
            }
            if (publicRequest.IsSetCustomErrorResponses())
            {
                context.Writer.WritePropertyName("customErrorResponses");
                context.Writer.WriteStartArray();
                foreach (var publicRequestCustomErrorResponsesListValue in publicRequest.CustomErrorResponses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DistributionCustomErrorResponseMarshaller.Instance;
                    marshaller.Marshall(publicRequestCustomErrorResponsesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDefaultCacheBehavior())
            {
                context.Writer.WritePropertyName("defaultCacheBehavior");
                context.Writer.WriteStartObject();

                var marshaller = CacheBehaviorMarshaller.Instance;
                marshaller.Marshall(publicRequest.DefaultCacheBehavior, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDefaultRootObject())
            {
                context.Writer.WritePropertyName("defaultRootObject");
                context.Writer.WriteStringValue(publicRequest.DefaultRootObject);
            }
            if (publicRequest.IsSetDistributionName())
            {
                context.Writer.WritePropertyName("distributionName");
                context.Writer.WriteStringValue(publicRequest.DistributionName);
            }
            if (publicRequest.IsSetEnablePrivateOriginAccess())
            {
                context.Writer.WritePropertyName("enablePrivateOriginAccess");
                context.Writer.WriteBooleanValue(publicRequest.EnablePrivateOriginAccess.Value);
            }
            if (publicRequest.IsSetEnableWaf())
            {
                context.Writer.WritePropertyName("enableWaf");
                context.Writer.WriteBooleanValue(publicRequest.EnableWaf.Value);
            }
            if (publicRequest.IsSetIsEnabled())
            {
                context.Writer.WritePropertyName("isEnabled");
                context.Writer.WriteBooleanValue(publicRequest.IsEnabled.Value);
            }
            if (publicRequest.IsSetOrigin())
            {
                context.Writer.WritePropertyName("origin");
                context.Writer.WriteStartObject();

                var marshaller = InputOriginMarshaller.Instance;
                marshaller.Marshall(publicRequest.Origin, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetUseDefaultCertificate())
            {
                context.Writer.WritePropertyName("useDefaultCertificate");
                context.Writer.WriteBooleanValue(publicRequest.UseDefaultCertificate.Value);
            }
            if (publicRequest.IsSetViewerMinimumTlsProtocolVersion())
            {
                context.Writer.WritePropertyName("viewerMinimumTlsProtocolVersion");
                context.Writer.WriteStringValue(publicRequest.ViewerMinimumTlsProtocolVersion);
            }
            if (publicRequest.IsSetWafRules())
            {
                context.Writer.WritePropertyName("wafRules");
                context.Writer.WriteStartArray();
                foreach (var publicRequestWafRulesListValue in publicRequest.WafRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WafRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestWafRulesListValue, context);

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

        private static readonly UpdateDistributionRequestMarshaller _instance = new();

        internal static UpdateDistributionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateDistributionRequestMarshaller Instance => _instance;
    }
}
