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

using Amazon.MarketplaceCatalog.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAssessments Request Marshaller
    /// </summary>
    public partial class ListAssessmentsRequestMarshaller : IMarshaller<IRequest, ListAssessmentsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAssessmentsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListAssessmentsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceCatalog");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ListAssessments";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAssessmentTargetFilter())
            {
                context.Writer.WritePropertyName("AssessmentTargetFilter");
                context.Writer.WriteStartObject();

                var marshaller = AssessmentTargetFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.AssessmentTargetFilter, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }
            if (publicRequest.IsSetFrameworkFilters())
            {
                context.Writer.WritePropertyName("FrameworkFilters");
                context.Writer.WriteStartObject();

                var marshaller = FrameworkFiltersMarshaller.Instance;
                marshaller.Marshall(publicRequest.FrameworkFilters, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetFrameworkId())
            {
                context.Writer.WritePropertyName("FrameworkId");
                context.Writer.WriteStringValue(publicRequest.FrameworkId);
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

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ListAssessmentsRequestMarshaller _instance = new();

        internal static ListAssessmentsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListAssessmentsRequestMarshaller Instance => _instance;
    }
}
