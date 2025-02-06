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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lex.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lex.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PostContent operation
    /// </summary>  
    public class PostContentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            PostContentResponse response = new PostContentResponse();
            response.AudioStream = context.Stream;
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-active-contexts"))
            {
                var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("x-amz-lex-active-contexts"));
                response.ActiveContexts = Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-alternative-intents"))
            {
                var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("x-amz-lex-alternative-intents"));
                response.AlternativeIntents = Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-bot-version"))
                response.BotVersion = context.ResponseData.GetHeaderValue("x-amz-lex-bot-version");
            if (context.ResponseData.IsHeaderPresent("Content-Type"))
                response.ContentType = context.ResponseData.GetHeaderValue("Content-Type");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-dialog-state"))
                response.DialogState = context.ResponseData.GetHeaderValue("x-amz-lex-dialog-state");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-encoded-input-transcript"))
                response.EncodedInputTranscript = context.ResponseData.GetHeaderValue("x-amz-lex-encoded-input-transcript");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-encoded-message"))
                response.EncodedMessage = context.ResponseData.GetHeaderValue("x-amz-lex-encoded-message");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-input-transcript"))
                response.InputTranscript = context.ResponseData.GetHeaderValue("x-amz-lex-input-transcript");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-intent-name"))
                response.IntentName = context.ResponseData.GetHeaderValue("x-amz-lex-intent-name");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-message"))
                response.Message = context.ResponseData.GetHeaderValue("x-amz-lex-message");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-message-format"))
                response.MessageFormat = context.ResponseData.GetHeaderValue("x-amz-lex-message-format");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-nlu-intent-confidence"))
            {
                var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("x-amz-lex-nlu-intent-confidence"));
                response.NluIntentConfidence = Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-sentiment"))
                response.SentimentResponse = context.ResponseData.GetHeaderValue("x-amz-lex-sentiment");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-session-attributes"))
            {
                var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("x-amz-lex-session-attributes"));
                response.SessionAttributes = Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-session-id"))
                response.SessionId = context.ResponseData.GetHeaderValue("x-amz-lex-session-id");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-slots"))
            {
                var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("x-amz-lex-slots"));
                response.Slots = Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-slot-to-elicit"))
                response.SlotToElicit = context.ResponseData.GetHeaderValue("x-amz-lex-slot-to-elicit");

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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadGatewayException"))
                {
                    return BadGatewayExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DependencyFailedException"))
                {
                    return DependencyFailedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
                {
                    return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
                {
                    return LimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("LoopDetectedException"))
                {
                    return LoopDetectedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotAcceptableException"))
                {
                    return NotAcceptableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("RequestTimeoutException"))
                {
                    return RequestTimeoutExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedMediaTypeException"))
                {
                    return UnsupportedMediaTypeExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonLexException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        /// <summary>
        /// Overriden to return true indicating the response contains streaming data.
        /// </summary>
        public override bool HasStreamingProperty
        {
            get
            {
                return true;
            }
        }

        private static PostContentResponseUnmarshaller _instance = new PostContentResponseUnmarshaller();        

        internal static PostContentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PostContentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}