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

using Amazon.MTurk.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MTurk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListReviewPolicyResultsForHIT Request Marshaller
    /// </summary>
    public partial class ListReviewPolicyResultsForHITRequestMarshaller : IMarshaller<IRequest, ListReviewPolicyResultsForHITRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListReviewPolicyResultsForHITRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListReviewPolicyResultsForHITRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MTurk");
            string target = "MTurkRequesterServiceV20170117.ListReviewPolicyResultsForHIT";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-17";
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
            if (publicRequest.IsSetHITId())
            {
                context.Writer.WritePropertyName("HITId");
                context.Writer.WriteStringValue(publicRequest.HITId);
            }
            if (publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }
            if (publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }
            if (publicRequest.IsSetPolicyLevels())
            {
                context.Writer.WritePropertyName("PolicyLevels");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPolicyLevelsListValue in publicRequest.PolicyLevels)
                {
                    context.Writer.WriteStringValue(publicRequestPolicyLevelsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRetrieveActions())
            {
                context.Writer.WritePropertyName("RetrieveActions");
                context.Writer.WriteBooleanValue(publicRequest.RetrieveActions.Value);
            }
            if (publicRequest.IsSetRetrieveResults())
            {
                context.Writer.WritePropertyName("RetrieveResults");
                context.Writer.WriteBooleanValue(publicRequest.RetrieveResults.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ListReviewPolicyResultsForHITRequestMarshaller _instance = new();

        internal static ListReviewPolicyResultsForHITRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListReviewPolicyResultsForHITRequestMarshaller Instance => _instance;
    }
}
