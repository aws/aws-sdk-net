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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutBot Request Marshaller
    /// </summary>       
    public class PutBotRequestMarshaller : IMarshaller<IRequest, PutBotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelBuildingService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-04-19";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetName())
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/bots/{name}/versions/$LATEST";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAbortStatement())
            {
                context.Writer.WritePropertyName("abortStatement");
                context.Writer.WriteStartObject();

                var marshaller = StatementMarshaller.Instance;
                marshaller.Marshall(publicRequest.AbortStatement, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetChecksum())
            {
                context.Writer.WritePropertyName("checksum");
                context.Writer.WriteStringValue(publicRequest.Checksum);
            }

            if(publicRequest.IsSetChildDirected())
            {
                context.Writer.WritePropertyName("childDirected");
                context.Writer.WriteBooleanValue(publicRequest.ChildDirected.Value);
            }

            if(publicRequest.IsSetClarificationPrompt())
            {
                context.Writer.WritePropertyName("clarificationPrompt");
                context.Writer.WriteStartObject();

                var marshaller = PromptMarshaller.Instance;
                marshaller.Marshall(publicRequest.ClarificationPrompt, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCreateVersion())
            {
                context.Writer.WritePropertyName("createVersion");
                context.Writer.WriteBooleanValue(publicRequest.CreateVersion.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDetectSentiment())
            {
                context.Writer.WritePropertyName("detectSentiment");
                context.Writer.WriteBooleanValue(publicRequest.DetectSentiment.Value);
            }

            if(publicRequest.IsSetEnableModelImprovements())
            {
                context.Writer.WritePropertyName("enableModelImprovements");
                context.Writer.WriteBooleanValue(publicRequest.EnableModelImprovements.Value);
            }

            if(publicRequest.IsSetIdleSessionTTLInSeconds())
            {
                context.Writer.WritePropertyName("idleSessionTTLInSeconds");
                context.Writer.WriteNumberValue(publicRequest.IdleSessionTTLInSeconds.Value);
            }

            if(publicRequest.IsSetIntents())
            {
                context.Writer.WritePropertyName("intents");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIntentsListValue in publicRequest.Intents)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IntentMarshaller.Instance;
                    marshaller.Marshall(publicRequestIntentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLocale())
            {
                context.Writer.WritePropertyName("locale");
                context.Writer.WriteStringValue(publicRequest.Locale);
            }

            if(publicRequest.IsSetNluIntentConfidenceThreshold())
            {
                context.Writer.WritePropertyName("nluIntentConfidenceThreshold");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.NluIntentConfidenceThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.NluIntentConfidenceThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.NluIntentConfidenceThreshold.Value);
                }
            }

            if(publicRequest.IsSetProcessBehavior())
            {
                context.Writer.WritePropertyName("processBehavior");
                context.Writer.WriteStringValue(publicRequest.ProcessBehavior);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVoiceId())
            {
                context.Writer.WritePropertyName("voiceId");
                context.Writer.WriteStringValue(publicRequest.VoiceId);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static PutBotRequestMarshaller _instance = new PutBotRequestMarshaller();        

        internal static PutBotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}