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

using Amazon.Elasticsearch.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateClone Request Marshaller
    /// </summary>
    public partial class UpdateCloneRequestMarshaller : IMarshaller<IRequest, UpdateCloneRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCloneRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateCloneRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Elasticsearch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-01-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainName())
            {
                throw new AmazonElasticsearchException("Request object does not have required field DomainName set");
            }
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));

            request.ResourcePath = "/2015-01-01/es/domain/{DomainName}/clone";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCutoverOptions())
            {
                context.Writer.WritePropertyName("CutoverOptions");
                context.Writer.WriteStartObject();

                var marshaller = CutoverRequestOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.CutoverOptions, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetRetentionOptions())
            {
                context.Writer.WritePropertyName("RetentionOptions");
                context.Writer.WriteStartObject();

                var marshaller = RetentionOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.RetentionOptions, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTrafficSplitOptions())
            {
                context.Writer.WritePropertyName("TrafficSplitOptions");
                context.Writer.WriteStartObject();

                var marshaller = TrafficSplitRequestOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.TrafficSplitOptions, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateCloneRequestMarshaller _instance = new();

        internal static UpdateCloneRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateCloneRequestMarshaller Instance => _instance;
    }
}
