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

using Amazon.Glue.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataQualityEvaluationConfig Request Marshaller
    /// </summary>
    public partial class CreateDataQualityEvaluationConfigRequestMarshaller : IMarshaller<IRequest, CreateDataQualityEvaluationConfigRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataQualityEvaluationConfigRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDataQualityEvaluationConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.CreateDataQualityEvaluationConfig";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
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
            if (publicRequest.IsSetAdditionalDataSources())
            {
                context.Writer.WritePropertyName("AdditionalDataSources");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAdditionalDataSourcesKvp in publicRequest.AdditionalDataSources)
                {
                    context.Writer.WritePropertyName(publicRequestAdditionalDataSourcesKvp.Key);
                    var publicRequestAdditionalDataSourcesValue = publicRequestAdditionalDataSourcesKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestAdditionalDataSourcesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetAdditionalRunOptions())
            {
                context.Writer.WritePropertyName("AdditionalRunOptions");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityEvaluationConfigAdditionalRunOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.AdditionalRunOptions, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetDataSource())
            {
                context.Writer.WritePropertyName("DataSource");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityEvaluationConfigDataSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSource, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetEndAt())
            {
                context.Writer.WritePropertyName("EndAt");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(publicRequest.EndAt.Value));
            }
            if (publicRequest.IsSetLevel())
            {
                context.Writer.WritePropertyName("Level");
                context.Writer.WriteStringValue(publicRequest.Level);
            }
            if (publicRequest.IsSetManagedRulesetName())
            {
                context.Writer.WritePropertyName("ManagedRulesetName");
                context.Writer.WriteStringValue(publicRequest.ManagedRulesetName);
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetNumberOfWorkers())
            {
                context.Writer.WritePropertyName("NumberOfWorkers");
                context.Writer.WriteNumberValue(publicRequest.NumberOfWorkers.Value);
            }
            if (publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }
            if (publicRequest.IsSetRulesetName())
            {
                context.Writer.WritePropertyName("RulesetName");
                context.Writer.WriteStringValue(publicRequest.RulesetName);
            }
            if (publicRequest.IsSetScheduleExpression())
            {
                context.Writer.WritePropertyName("ScheduleExpression");
                context.Writer.WriteStringValue(publicRequest.ScheduleExpression);
            }
            if (publicRequest.IsSetStartAt())
            {
                context.Writer.WritePropertyName("StartAt");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(publicRequest.StartAt.Value));
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.WriteNumberValue(publicRequest.Timeout.Value);
            }
            if (publicRequest.IsSetTriggers())
            {
                context.Writer.WritePropertyName("Triggers");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTriggersListValue in publicRequest.Triggers)
                {
                    context.Writer.WriteStringValue(publicRequestTriggersListValue);
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

        private static readonly CreateDataQualityEvaluationConfigRequestMarshaller _instance = new();

        internal static CreateDataQualityEvaluationConfigRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDataQualityEvaluationConfigRequestMarshaller Instance => _instance;
    }
}
