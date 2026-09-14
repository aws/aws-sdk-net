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

using Amazon.ElementalInference.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ElementalInference.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateFeed Request Marshaller
    /// </summary>
    public partial class AssociateFeedRequestMarshaller : IMarshaller<IRequest, AssociateFeedRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateFeedRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AssociateFeedRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElementalInference");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetId())
            {
                throw new AmazonElementalInferenceException("Request object does not have required field Id set");
            }
            request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));

            request.ResourcePath = "/v1/feed/{id}/associate";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAssociatedResourceName())
            {
                context.Writer.WritePropertyName("associatedResourceName");
                context.Writer.WriteStringValue(publicRequest.AssociatedResourceName);
            }
            else
            {
                context.Writer.WritePropertyName("associatedResourceName");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("dryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }
            if (publicRequest.IsSetOutputs())
            {
                context.Writer.WritePropertyName("outputs");
                context.Writer.WriteStartArray();
                foreach (var publicRequestOutputsListValue in publicRequest.Outputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CreateOutputMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputsListValue, context);

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

        private static readonly AssociateFeedRequestMarshaller _instance = new();

        internal static AssociateFeedRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssociateFeedRequestMarshaller Instance => _instance;
    }
}
