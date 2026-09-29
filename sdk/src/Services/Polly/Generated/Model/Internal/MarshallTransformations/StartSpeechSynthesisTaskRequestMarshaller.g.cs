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

using Amazon.Polly.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Polly.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSpeechSynthesisTask Request Marshaller
    /// </summary>
    public partial class StartSpeechSynthesisTaskRequestMarshaller : IMarshaller<IRequest, StartSpeechSynthesisTaskRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartSpeechSynthesisTaskRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartSpeechSynthesisTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Polly");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/synthesisTasks";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.WriteStringValue(publicRequest.Engine);
            }
            if (publicRequest.IsSetLanguageCode())
            {
                context.Writer.WritePropertyName("LanguageCode");
                context.Writer.WriteStringValue(publicRequest.LanguageCode);
            }
            if (publicRequest.IsSetLexiconNames())
            {
                context.Writer.WritePropertyName("LexiconNames");
                context.Writer.WriteStartArray();
                foreach (var publicRequestLexiconNamesListValue in publicRequest.LexiconNames)
                {
                    context.Writer.WriteStringValue(publicRequestLexiconNamesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetOutputFormat())
            {
                context.Writer.WritePropertyName("OutputFormat");
                context.Writer.WriteStringValue(publicRequest.OutputFormat);
            }
            if (publicRequest.IsSetOutputS3BucketName())
            {
                context.Writer.WritePropertyName("OutputS3BucketName");
                context.Writer.WriteStringValue(publicRequest.OutputS3BucketName);
            }
            if (publicRequest.IsSetOutputS3KeyPrefix())
            {
                context.Writer.WritePropertyName("OutputS3KeyPrefix");
                context.Writer.WriteStringValue(publicRequest.OutputS3KeyPrefix);
            }
            if (publicRequest.IsSetSampleRate())
            {
                context.Writer.WritePropertyName("SampleRate");
                context.Writer.WriteStringValue(publicRequest.SampleRate);
            }
            if (publicRequest.IsSetSnsTopicArn())
            {
                context.Writer.WritePropertyName("SnsTopicArn");
                context.Writer.WriteStringValue(publicRequest.SnsTopicArn);
            }
            if (publicRequest.IsSetSpeechMarkTypes())
            {
                context.Writer.WritePropertyName("SpeechMarkTypes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSpeechMarkTypesListValue in publicRequest.SpeechMarkTypes)
                {
                    context.Writer.WriteStringValue(publicRequestSpeechMarkTypesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetText())
            {
                context.Writer.WritePropertyName("Text");
                context.Writer.WriteStringValue(publicRequest.Text);
            }
            if (publicRequest.IsSetTextType())
            {
                context.Writer.WritePropertyName("TextType");
                context.Writer.WriteStringValue(publicRequest.TextType);
            }
            if (publicRequest.IsSetVoiceId())
            {
                context.Writer.WritePropertyName("VoiceId");
                context.Writer.WriteStringValue(publicRequest.VoiceId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly StartSpeechSynthesisTaskRequestMarshaller _instance = new();

        internal static StartSpeechSynthesisTaskRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartSpeechSynthesisTaskRequestMarshaller Instance => _instance;
    }
}
