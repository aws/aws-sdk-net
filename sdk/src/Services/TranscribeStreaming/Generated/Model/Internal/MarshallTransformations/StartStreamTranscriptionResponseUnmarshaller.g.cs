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

using Amazon.TranscribeStreaming.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StartStreamTranscription operation.
    /// </summary>
    public partial class StartStreamTranscriptionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new StartStreamTranscriptionResponse();
            unmarshalledObject.TranscriptResultStream = new TranscriptResultStream(context.Stream);
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-content-identification-type"))
            {
                unmarshalledObject.ContentIdentificationType = context.ResponseData.GetHeaderValue("x-amzn-transcribe-content-identification-type");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-content-redaction-type"))
            {
                unmarshalledObject.ContentRedactionType = context.ResponseData.GetHeaderValue("x-amzn-transcribe-content-redaction-type");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-enable-channel-identification"))
            {
                unmarshalledObject.EnableChannelIdentification = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-enable-channel-identification"));
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-enable-partial-results-stabilization"))
            {
                unmarshalledObject.EnablePartialResultsStabilization = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-enable-partial-results-stabilization"));
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-identify-language"))
            {
                unmarshalledObject.IdentifyLanguage = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-identify-language"));
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-identify-multiple-languages"))
            {
                unmarshalledObject.IdentifyMultipleLanguages = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-identify-multiple-languages"));
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-language-code"))
            {
                unmarshalledObject.LanguageCode = context.ResponseData.GetHeaderValue("x-amzn-transcribe-language-code");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-language-model-name"))
            {
                unmarshalledObject.LanguageModelName = context.ResponseData.GetHeaderValue("x-amzn-transcribe-language-model-name");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-language-options"))
            {
                unmarshalledObject.LanguageOptions = context.ResponseData.GetHeaderValue("x-amzn-transcribe-language-options");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-media-encoding"))
            {
                unmarshalledObject.MediaEncoding = context.ResponseData.GetHeaderValue("x-amzn-transcribe-media-encoding");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-sample-rate"))
            {
                unmarshalledObject.MediaSampleRateHertz = int.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-sample-rate"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-number-of-channels"))
            {
                unmarshalledObject.NumberOfChannels = int.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-number-of-channels"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-partial-results-stability"))
            {
                unmarshalledObject.PartialResultsStability = context.ResponseData.GetHeaderValue("x-amzn-transcribe-partial-results-stability");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-pii-entity-types"))
            {
                unmarshalledObject.PiiEntityTypes = context.ResponseData.GetHeaderValue("x-amzn-transcribe-pii-entity-types");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-preferred-language"))
            {
                unmarshalledObject.PreferredLanguage = context.ResponseData.GetHeaderValue("x-amzn-transcribe-preferred-language");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-request-id"))
            {
                unmarshalledObject.RequestId = context.ResponseData.GetHeaderValue("x-amzn-request-id");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-session-id"))
            {
                unmarshalledObject.SessionId = context.ResponseData.GetHeaderValue("x-amzn-transcribe-session-id");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-session-resume-window"))
            {
                unmarshalledObject.SessionResumeWindow = int.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-session-resume-window"), CultureInfo.InvariantCulture);
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-show-speaker-label"))
            {
                unmarshalledObject.ShowSpeakerLabel = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-show-speaker-label"));
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-transcript-format"))
            {
                unmarshalledObject.TranscriptFormat = context.ResponseData.GetHeaderValue("x-amzn-transcribe-transcript-format");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-filter-method"))
            {
                unmarshalledObject.VocabularyFilterMethod = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-filter-method");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-filter-name"))
            {
                unmarshalledObject.VocabularyFilterName = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-filter-name");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-filter-names"))
            {
                unmarshalledObject.VocabularyFilterNames = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-filter-names");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-name"))
            {
                unmarshalledObject.VocabularyName = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-name");
            }
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-names"))
            {
                unmarshalledObject.VocabularyNames = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-names");
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                    {
                        return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                    {
                        return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
                    {
                        return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
                    {
                        return LimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
                    {
                        return ServiceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonTranscribeStreamingException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        /// <summary>
        /// Overriden to return true indicating the response contains streaming data.
        /// </summary>
        public override bool HasStreamingProperty => true;

        /// <summary>
        /// Return false for reading the entire response
        /// </summary>
        protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse) => false;

        private static StartStreamTranscriptionResponseUnmarshaller _instance = new StartStreamTranscriptionResponseUnmarshaller();

        internal static StartStreamTranscriptionResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartStreamTranscriptionResponseUnmarshaller Instance => _instance;
    }
}
