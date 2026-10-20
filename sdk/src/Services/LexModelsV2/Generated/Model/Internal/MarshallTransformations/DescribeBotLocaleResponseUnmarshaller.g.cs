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

using Amazon.LexModelsV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeBotLocale operation.
    /// </summary>
    public partial class DescribeBotLocaleResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeBotLocaleResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("audioFillerSettings", targetDepth, ref reader))
                {
                    var unmarshaller = AudioFillerSettingsUnmarshaller.Instance;
                    unmarshalledObject.AudioFillerSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("botId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("botLocaleHistoryEvents", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<BotLocaleHistoryEvent, BotLocaleHistoryEventUnmarshaller>(BotLocaleHistoryEventUnmarshaller.Instance);
                    unmarshalledObject.BotLocaleHistoryEvents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("botLocaleStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotLocaleStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("botVersion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BotVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("creationDateTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("description", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("failureReasons", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FailureReasons = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("generativeAISettings", targetDepth, ref reader))
                {
                    var unmarshaller = GenerativeAISettingsUnmarshaller.Instance;
                    unmarshalledObject.GenerativeAISettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("intentsCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.IntentsCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("lastBuildSubmittedDateTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastBuildSubmittedDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("lastUpdatedDateTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("localeId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocaleId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("localeName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocaleName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("nluIntentConfidenceThreshold", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.NluIntentConfidenceThreshold = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("recommendedActions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.RecommendedActions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("slotTypesCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SlotTypesCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("speakerDiarizationSettings", targetDepth, ref reader))
                {
                    var unmarshaller = SpeakerDiarizationSettingsUnmarshaller.Instance;
                    unmarshalledObject.SpeakerDiarizationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("speechDetectionSensitivity", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpeechDetectionSensitivity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("speechRecognitionSettings", targetDepth, ref reader))
                {
                    var unmarshaller = SpeechRecognitionSettingsUnmarshaller.Instance;
                    unmarshalledObject.SpeechRecognitionSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("unifiedSpeechSettings", targetDepth, ref reader))
                {
                    var unmarshaller = UnifiedSpeechSettingsUnmarshaller.Instance;
                    unmarshalledObject.UnifiedSpeechSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("voiceSettings", targetDepth, ref reader))
                {
                    var unmarshaller = VoiceSettingsUnmarshaller.Instance;
                    unmarshalledObject.VoiceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                    {
                        return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                    {
                        return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                    {
                        return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                    {
                        return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonLexModelsV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeBotLocaleResponseUnmarshaller _instance = new DescribeBotLocaleResponseUnmarshaller();

        internal static DescribeBotLocaleResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeBotLocaleResponseUnmarshaller Instance => _instance;
    }
}
