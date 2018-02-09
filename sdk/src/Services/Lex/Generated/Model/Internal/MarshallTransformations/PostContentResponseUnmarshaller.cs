/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            if (context.ResponseData.IsHeaderPresent("Content-Type"))
                response.ContentType = context.ResponseData.GetHeaderValue("Content-Type");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-dialog-state"))
                response.DialogState = context.ResponseData.GetHeaderValue("x-amz-lex-dialog-state");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-input-transcript"))
                response.InputTranscript = context.ResponseData.GetHeaderValue("x-amz-lex-input-transcript");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-intent-name"))
                response.IntentName = context.ResponseData.GetHeaderValue("x-amz-lex-intent-name");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-message"))
                response.Message = context.ResponseData.GetHeaderValue("x-amz-lex-message");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-message-format"))
                response.MessageFormat = context.ResponseData.GetHeaderValue("x-amz-lex-message-format");
            if (context.ResponseData.IsHeaderPresent("x-amz-lex-session-attributes"))
            {
                var headerBytes = Convert.FromBase64String(context.ResponseData.GetHeaderValue("x-amz-lex-session-attributes"));
                response.SessionAttributes = Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
            }
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
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("BadGatewayException"))
            {
                return new BadGatewayException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
            {
                return new BadRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
            {
                return new ConflictException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("DependencyFailedException"))
            {
                return new DependencyFailedException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
            {
                return new InternalFailureException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
            {
                return new LimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("LoopDetectedException"))
            {
                return new LoopDetectedException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("NotAcceptableException"))
            {
                return new NotAcceptableException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
            {
                return new NotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("RequestTimeoutException"))
            {
                return new RequestTimeoutException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedMediaTypeException"))
            {
                return new UnsupportedMediaTypeException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonLexException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
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