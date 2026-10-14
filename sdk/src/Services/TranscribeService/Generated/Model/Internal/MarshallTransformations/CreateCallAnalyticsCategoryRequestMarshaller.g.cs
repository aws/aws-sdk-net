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

using Amazon.TranscribeService.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCallAnalyticsCategory Request Marshaller
    /// </summary>
    public partial class CreateCallAnalyticsCategoryRequestMarshaller : IMarshaller<IRequest, CreateCallAnalyticsCategoryRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCallAnalyticsCategoryRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateCallAnalyticsCategoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeService");
            string target = "Transcribe.CreateCallAnalyticsCategory";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
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
            if (publicRequest.IsSetCategoryName())
            {
                context.Writer.WritePropertyName("CategoryName");
                context.Writer.WriteStringValue(publicRequest.CategoryName);
            }
            if (publicRequest.IsSetInputType())
            {
                context.Writer.WritePropertyName("InputType");
                context.Writer.WriteStringValue(publicRequest.InputType);
            }
            if (publicRequest.IsSetRules())
            {
                context.Writer.WritePropertyName("Rules");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRulesListValue in publicRequest.Rules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

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

        private static readonly CreateCallAnalyticsCategoryRequestMarshaller _instance = new();

        internal static CreateCallAnalyticsCategoryRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateCallAnalyticsCategoryRequestMarshaller Instance => _instance;
    }
}
