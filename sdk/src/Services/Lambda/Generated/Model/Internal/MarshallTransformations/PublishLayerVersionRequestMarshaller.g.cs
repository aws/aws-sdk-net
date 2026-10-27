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
    /// PublishLayerVersion Request Marshaller
    /// </summary>
    public partial class PublishLayerVersionRequestMarshaller : IMarshaller<IRequest, PublishLayerVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PublishLayerVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PublishLayerVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetLayerName())
            {
                throw new AmazonLambdaException("Request object does not have required field LayerName set");
            }
            request.AddPathResource("{LayerName}", StringUtils.FromString(publicRequest.LayerName));

            request.ResourcePath = "/2018-10-31/layers/{LayerName}/versions";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCompatibleArchitectures())
            {
                context.Writer.WritePropertyName("CompatibleArchitectures");
                context.Writer.WriteStartArray();
                foreach (var publicRequestCompatibleArchitecturesListValue in publicRequest.CompatibleArchitectures)
                {
                    context.Writer.WriteStringValue(publicRequestCompatibleArchitecturesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetCompatibleRuntimes())
            {
                context.Writer.WritePropertyName("CompatibleRuntimes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestCompatibleRuntimesListValue in publicRequest.CompatibleRuntimes)
                {
                    context.Writer.WriteStringValue(publicRequestCompatibleRuntimesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetContent())
            {
                context.Writer.WritePropertyName("Content");
                context.Writer.WriteStartObject();

                var marshaller = LayerVersionContentInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Content, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetLicenseInfo())
            {
                context.Writer.WritePropertyName("LicenseInfo");
                context.Writer.WriteStringValue(publicRequest.LicenseInfo);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PublishLayerVersionRequestMarshaller _instance = new();

        internal static PublishLayerVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PublishLayerVersionRequestMarshaller Instance => _instance;
    }
}
