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

using Amazon.Lex.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Lex.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PutSession operation.
    /// </summary>
    public partial class PutSessionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new PutSessionResponse();
            unmarshalledObject.AudioStream = context.Stream;
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-active-contexts"))
            {
                var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("x-amz-lex-active-contexts"));
                unmarshalledObject.ActiveContexts = System.Text.Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
            }
            if (context.ResponseData.IsHeaderPresent("Content-Type"))
            {
                unmarshalledObject.ContentType = context.ResponseData.GetHeaderValue("Content-Type");
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-dialog-state"))
            {
                unmarshalledObject.DialogState = context.ResponseData.GetHeaderValue("x-amz-lex-dialog-state");
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-encoded-message"))
            {
                unmarshalledObject.EncodedMessage = context.ResponseData.GetHeaderValue("x-amz-lex-encoded-message");
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-intent-name"))
            {
                unmarshalledObject.IntentName = context.ResponseData.GetHeaderValue("x-amz-lex-intent-name");
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-message"))
            {
                unmarshalledObject.Message = context.ResponseData.GetHeaderValue("x-amz-lex-message");
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-message-format"))
            {
                unmarshalledObject.MessageFormat = context.ResponseData.GetHeaderValue("x-amz-lex-message-format");
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-session-attributes"))
            {
                var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("x-amz-lex-session-attributes"));
                unmarshalledObject.SessionAttributes = System.Text.Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-session-id"))
            {
                unmarshalledObject.SessionId = context.ResponseData.GetHeaderValue("x-amz-lex-session-id");
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-slot-to-elicit"))
            {
                unmarshalledObject.SlotToElicit = context.ResponseData.GetHeaderValue("x-amz-lex-slot-to-elicit");
            }
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-slots"))
            {
                var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("x-amz-lex-slots"));
                unmarshalledObject.Slots = System.Text.Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("NotAcceptableException"))
                    {
                        return NotAcceptableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                    {
                        return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonLexException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        /// <summary>
        /// Overriden to return true indicating the response contains streaming data.
        /// </summary>
        public override bool HasStreamingProperty => true;

        private static PutSessionResponseUnmarshaller _instance = new PutSessionResponseUnmarshaller();

        internal static PutSessionResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutSessionResponseUnmarshaller Instance => _instance;
    }
}
