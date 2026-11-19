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
    /// CreateQuestionSet Request Marshaller
    /// </summary>
    public partial class CreateQuestionSetRequestMarshaller : IMarshaller<IRequest, CreateQuestionSetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateQuestionSetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateQuestionSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElementalInference");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/question-set";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetChooseOne())
            {
                context.Writer.WritePropertyName("chooseOne");
                context.Writer.WriteStartArray();
                foreach (var publicRequestChooseOneListValue in publicRequest.ChooseOne)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ChooseOneQuestionMarshaller.Instance;
                    marshaller.Marshall(publicRequestChooseOneListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetYesNo())
            {
                context.Writer.WritePropertyName("yesNo");
                context.Writer.WriteStartArray();
                foreach (var publicRequestYesNoListValue in publicRequest.YesNo)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = YesNoQuestionMarshaller.Instance;
                    marshaller.Marshall(publicRequestYesNoListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetYesNoPerOption())
            {
                context.Writer.WritePropertyName("yesNoPerOption");
                context.Writer.WriteStartArray();
                foreach (var publicRequestYesNoPerOptionListValue in publicRequest.YesNoPerOption)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = YesNoPerOptionQuestionMarshaller.Instance;
                    marshaller.Marshall(publicRequestYesNoPerOptionListValue, context);

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

        private static readonly CreateQuestionSetRequestMarshaller _instance = new();

        internal static CreateQuestionSetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateQuestionSetRequestMarshaller Instance => _instance;
    }
}
