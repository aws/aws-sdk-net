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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SetAlarmState operation
    /// </summary>  
    public class SetAlarmStateResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            SetAlarmStateResponse response = new SetAlarmStateResponse();
            var reader = context.Reader;
            context.AddPathSegment("SetAlarmState");

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new CborUnmarshallerContext(streamCopy, true, context.ResponseData))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidFormatFault"))
                {
                    errorResponse.Code = "InvalidFormat";
                    return InvalidFormatExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            var errorCode = errorResponse.Code;
            var errorType = errorResponse.Type;
            var queryHeaderKey = Amazon.Util.HeaderKeys.XAmzQueryError;
            if (context.ResponseData.IsHeaderPresent(queryHeaderKey))
            {
                var queryError = context.ResponseData.GetHeaderValue(queryHeaderKey);
                if (!string.IsNullOrEmpty(queryError) && queryError.Contains(";"))
                {
                    var queryErrorParts = queryError.Split(';');
                    if (queryErrorParts.Length == 2)
                    {
                        errorCode = queryErrorParts[0];
                        var errorTypeString = queryErrorParts[1];
                        if (Enum.IsDefined(typeof(ErrorType), errorTypeString))
                        {
                            errorType = (ErrorType) Enum.Parse(typeof(ErrorType), errorTypeString);
                        }
                    }
                }
            }
            return new AmazonCloudWatchException(errorResponse.Message, errorResponse.InnerException, errorType, errorCode, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static SetAlarmStateResponseUnmarshaller _instance = new SetAlarmStateResponseUnmarshaller();        

        internal static SetAlarmStateResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SetAlarmStateResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}