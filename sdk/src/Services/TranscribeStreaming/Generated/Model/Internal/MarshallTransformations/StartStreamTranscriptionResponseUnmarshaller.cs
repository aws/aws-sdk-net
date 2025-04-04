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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeStreaming.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StartStreamTranscription operation
    /// </summary>  
    public class StartStreamTranscriptionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            StartStreamTranscriptionResponse response = new StartStreamTranscriptionResponse();
            response.TranscriptResultStream = new TranscriptResultStream(context.Stream);
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-content-identification-type"))
                response.ContentIdentificationType = context.ResponseData.GetHeaderValue("x-amzn-transcribe-content-identification-type");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-content-redaction-type"))
                response.ContentRedactionType = context.ResponseData.GetHeaderValue("x-amzn-transcribe-content-redaction-type");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-enable-channel-identification"))
                response.EnableChannelIdentification = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-enable-channel-identification"));
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-enable-partial-results-stabilization"))
                response.EnablePartialResultsStabilization = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-enable-partial-results-stabilization"));
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-identify-language"))
                response.IdentifyLanguage = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-identify-language"));
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-identify-multiple-languages"))
                response.IdentifyMultipleLanguages = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-identify-multiple-languages"));
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-language-code"))
                response.LanguageCode = context.ResponseData.GetHeaderValue("x-amzn-transcribe-language-code");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-language-model-name"))
                response.LanguageModelName = context.ResponseData.GetHeaderValue("x-amzn-transcribe-language-model-name");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-language-options"))
                response.LanguageOptions = context.ResponseData.GetHeaderValue("x-amzn-transcribe-language-options");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-media-encoding"))
                response.MediaEncoding = context.ResponseData.GetHeaderValue("x-amzn-transcribe-media-encoding");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-sample-rate"))
                response.MediaSampleRateHertz = int.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-sample-rate"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-number-of-channels"))
                response.NumberOfChannels = int.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-number-of-channels"), CultureInfo.InvariantCulture);
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-partial-results-stability"))
                response.PartialResultsStability = context.ResponseData.GetHeaderValue("x-amzn-transcribe-partial-results-stability");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-pii-entity-types"))
                response.PiiEntityTypes = context.ResponseData.GetHeaderValue("x-amzn-transcribe-pii-entity-types");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-preferred-language"))
                response.PreferredLanguage = context.ResponseData.GetHeaderValue("x-amzn-transcribe-preferred-language");
            if (context.ResponseData.IsHeaderPresent("x-amzn-request-id"))
                response.RequestId = context.ResponseData.GetHeaderValue("x-amzn-request-id");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-session-id"))
                response.SessionId = context.ResponseData.GetHeaderValue("x-amzn-transcribe-session-id");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-show-speaker-label"))
                response.ShowSpeakerLabel = bool.Parse(context.ResponseData.GetHeaderValue("x-amzn-transcribe-show-speaker-label"));
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-filter-method"))
                response.VocabularyFilterMethod = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-filter-method");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-filter-name"))
                response.VocabularyFilterName = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-filter-name");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-filter-names"))
                response.VocabularyFilterNames = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-filter-names");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-name"))
                response.VocabularyName = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-name");
            if (context.ResponseData.IsHeaderPresent("x-amzn-transcribe-vocabulary-names"))
                response.VocabularyNames = context.ResponseData.GetHeaderValue("x-amzn-transcribe-vocabulary-names");

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
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
            return new AmazonTranscribeStreamingException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static StartStreamTranscriptionResponseUnmarshaller _instance = new StartStreamTranscriptionResponseUnmarshaller();        

        internal static StartStreamTranscriptionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartStreamTranscriptionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Return false for reading the entire response
        /// </summary>
        /// <param name="response"></param>
        /// <param name="readEntireResponse"></param>
        /// <returns></returns>
        protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse)
        {
            return false;
        }
        /// <summary>
        /// Specifies that the response should be streamed
        /// </summary>
        public override bool HasStreamingProperty => true;
    }
}