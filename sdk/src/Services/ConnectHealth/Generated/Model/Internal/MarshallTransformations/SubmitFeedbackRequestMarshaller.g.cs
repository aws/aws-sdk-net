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

using Amazon.ConnectHealth.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ConnectHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubmitFeedback Request Marshaller
    /// </summary>
    public partial class SubmitFeedbackRequestMarshaller : IMarshaller<IRequest, SubmitFeedbackRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SubmitFeedbackRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SubmitFeedbackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectHealth");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-01-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainId())
            {
                throw new AmazonConnectHealthException("Request object does not have required field DomainId set");
            }
            request.AddPathResource("{domainId}", StringUtils.FromString(publicRequest.DomainId));

            request.ResourcePath = "/domain/{domainId}/feedback";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetArtifactSourceId())
            {
                context.Writer.WritePropertyName("artifactSourceId");
                context.Writer.WriteStringValue(publicRequest.ArtifactSourceId);
            }
            if (publicRequest.IsSetArtifactType())
            {
                context.Writer.WritePropertyName("artifactType");
                context.Writer.WriteStringValue(publicRequest.ArtifactType);
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetComments())
            {
                context.Writer.WritePropertyName("comments");
                context.Writer.WriteStringValue(publicRequest.Comments);
            }
            if (publicRequest.IsSetGeneratedArtifactS3Uri())
            {
                context.Writer.WritePropertyName("generatedArtifactS3Uri");
                context.Writer.WriteStringValue(publicRequest.GeneratedArtifactS3Uri);
            }
            if (publicRequest.IsSetSignedArtifactS3Uri())
            {
                context.Writer.WritePropertyName("signedArtifactS3Uri");
                context.Writer.WriteStringValue(publicRequest.SignedArtifactS3Uri);
            }
            if (publicRequest.IsSetSubscriptionId())
            {
                context.Writer.WritePropertyName("subscriptionId");
                context.Writer.WriteStringValue(publicRequest.SubscriptionId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.HostPrefix = $"runtime.";

            return request;
        }

        private static readonly SubmitFeedbackRequestMarshaller _instance = new();

        internal static SubmitFeedbackRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SubmitFeedbackRequestMarshaller Instance => _instance;
    }
}
