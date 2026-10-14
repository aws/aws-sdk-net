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

using Amazon.CostExplorer.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCostCategoryDefinition Request Marshaller
    /// </summary>
    public partial class UpdateCostCategoryDefinitionRequestMarshaller : IMarshaller<IRequest, UpdateCostCategoryDefinitionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCostCategoryDefinitionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateCostCategoryDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CostExplorer");
            string target = "AWSInsightsIndexService.UpdateCostCategoryDefinition";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-25";
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
            if (publicRequest.IsSetCostCategoryArn())
            {
                context.Writer.WritePropertyName("CostCategoryArn");
                context.Writer.WriteStringValue(publicRequest.CostCategoryArn);
            }
            if (publicRequest.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("DefaultValue");
                context.Writer.WriteStringValue(publicRequest.DefaultValue);
            }
            if (publicRequest.IsSetEffectiveStart())
            {
                context.Writer.WritePropertyName("EffectiveStart");
                context.Writer.WriteStringValue(publicRequest.EffectiveStart);
            }
            if (publicRequest.IsSetRuleVersion())
            {
                context.Writer.WritePropertyName("RuleVersion");
                context.Writer.WriteStringValue(publicRequest.RuleVersion);
            }
            if (publicRequest.IsSetRules())
            {
                context.Writer.WritePropertyName("Rules");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRulesListValue in publicRequest.Rules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CostCategoryRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSplitChargeRules())
            {
                context.Writer.WritePropertyName("SplitChargeRules");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSplitChargeRulesListValue in publicRequest.SplitChargeRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CostCategorySplitChargeRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestSplitChargeRulesListValue, context);

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

        private static readonly UpdateCostCategoryDefinitionRequestMarshaller _instance = new();

        internal static UpdateCostCategoryDefinitionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateCostCategoryDefinitionRequestMarshaller Instance => _instance;
    }
}
