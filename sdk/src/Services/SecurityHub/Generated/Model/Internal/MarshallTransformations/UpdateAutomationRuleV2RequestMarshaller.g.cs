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

using Amazon.SecurityHub.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAutomationRuleV2 Request Marshaller
    /// </summary>
    public partial class UpdateAutomationRuleV2RequestMarshaller : IMarshaller<IRequest, UpdateAutomationRuleV2Request>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAutomationRuleV2Request)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateAutomationRuleV2Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-26";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetIdentifier())
            {
                throw new AmazonSecurityHubException("Request object does not have required field Identifier set");
            }
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));

            request.ResourcePath = "/automationrulesv2/{Identifier}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetActions())
            {
                context.Writer.WritePropertyName("Actions");
                context.Writer.WriteStartArray();
                foreach (var publicRequestActionsListValue in publicRequest.Actions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AutomationRulesActionV2Marshaller.Instance;
                    marshaller.Marshall(publicRequestActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetCriteria())
            {
                context.Writer.WritePropertyName("Criteria");
                context.Writer.WriteStartObject();

                var marshaller = CriteriaMarshaller.Instance;
                marshaller.Marshall(publicRequest.Criteria, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetRuleName())
            {
                context.Writer.WritePropertyName("RuleName");
                context.Writer.WriteStringValue(publicRequest.RuleName);
            }
            if (publicRequest.IsSetRuleOrder())
            {
                context.Writer.WritePropertyName("RuleOrder");
                if (StringUtils.IsSpecialFloatValue(publicRequest.RuleOrder.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(publicRequest.RuleOrder.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.RuleOrder.Value);
                }
            }
            if (publicRequest.IsSetRuleStatus())
            {
                context.Writer.WritePropertyName("RuleStatus");
                context.Writer.WriteStringValue(publicRequest.RuleStatus);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateAutomationRuleV2RequestMarshaller _instance = new();

        internal static UpdateAutomationRuleV2RequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateAutomationRuleV2RequestMarshaller Instance => _instance;
    }
}
