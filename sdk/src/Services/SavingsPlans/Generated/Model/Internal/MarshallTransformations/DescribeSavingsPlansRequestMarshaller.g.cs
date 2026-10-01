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

using Amazon.SavingsPlans.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SavingsPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeSavingsPlans Request Marshaller
    /// </summary>
    public partial class DescribeSavingsPlansRequestMarshaller : IMarshaller<IRequest, DescribeSavingsPlansRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeSavingsPlansRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeSavingsPlansRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SavingsPlans");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/DescribeSavingsPlans";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("filters");
                context.Writer.WriteStartArray();
                foreach (var publicRequestFiltersListValue in publicRequest.Filters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SavingsPlanFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("maxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }
            if (publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("nextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }
            if (publicRequest.IsSetSavingsPlanArns())
            {
                context.Writer.WritePropertyName("savingsPlanArns");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSavingsPlanArnsListValue in publicRequest.SavingsPlanArns)
                {
                    context.Writer.WriteStringValue(publicRequestSavingsPlanArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSavingsPlanIds())
            {
                context.Writer.WritePropertyName("savingsPlanIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSavingsPlanIdsListValue in publicRequest.SavingsPlanIds)
                {
                    context.Writer.WriteStringValue(publicRequestSavingsPlanIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetStates())
            {
                context.Writer.WritePropertyName("states");
                context.Writer.WriteStartArray();
                foreach (var publicRequestStatesListValue in publicRequest.States)
                {
                    context.Writer.WriteStringValue(publicRequestStatesListValue);
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

        private static readonly DescribeSavingsPlansRequestMarshaller _instance = new();

        internal static DescribeSavingsPlansRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeSavingsPlansRequestMarshaller Instance => _instance;
    }
}
