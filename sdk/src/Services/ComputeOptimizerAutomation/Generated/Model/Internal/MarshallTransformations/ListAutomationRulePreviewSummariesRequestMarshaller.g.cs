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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListAutomationRulePreviewSummaries Request Marshaller
    /// </summary>
    public partial class ListAutomationRulePreviewSummariesRequestMarshaller : IMarshaller<IRequest, ListAutomationRulePreviewSummariesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAutomationRulePreviewSummariesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListAutomationRulePreviewSummariesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizerAutomation");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/ComputeOptimizerAutomationService/operation/ListAutomationRulePreviewSummaries";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetCriteria())
                {
                    context.Writer.WriteTextString("criteria");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CriteriaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Criteria, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetMaxResults())
                {
                    context.Writer.WriteTextString("maxResults");
                    context.Writer.WriteInt32(publicRequest.MaxResults.Value);
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("nextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetOrganizationScope())
                {
                    context.Writer.WriteTextString("organizationScope");
                    context.Writer.WriteStartMap(null);

                    var marshaller = OrganizationScopeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OrganizationScope, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetRecommendedActionTypes())
                {
                    context.Writer.WriteTextString("recommendedActionTypes");
                    context.Writer.WriteStartArray(publicRequest.RecommendedActionTypes.Count);
                    foreach (var publicRequestRecommendedActionTypesListValue in publicRequest.RecommendedActionTypes)
                    {
                        context.Writer.WriteTextString(publicRequestRecommendedActionTypesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetRuleType())
                {
                    context.Writer.WriteTextString("ruleType");
                    context.Writer.WriteTextString(publicRequest.RuleType);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly ListAutomationRulePreviewSummariesRequestMarshaller _instance = new();

        internal static ListAutomationRulePreviewSummariesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListAutomationRulePreviewSummariesRequestMarshaller Instance => _instance;
    }
}
