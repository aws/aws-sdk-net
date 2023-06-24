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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RequestPhoneNumber operation
    /// </summary>  
    public class RequestPhoneNumberResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            RequestPhoneNumberResponse response = new RequestPhoneNumberResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeletionProtectionEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.DeletionProtectionEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsoCountryCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IsoCountryCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MessageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MessageType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonthlyLeasingPrice", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MonthlyLeasingPrice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberCapabilities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.NumberCapabilities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NumberType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OptOutListName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OptOutListName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PhoneNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumberArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PhoneNumberArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumberId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PhoneNumberId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PoolId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PoolId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelfManagedOptOutsEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.SelfManagedOptOutsEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TwoWayChannelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TwoWayChannelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TwoWayEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.TwoWayEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

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
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                {
                    return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonPinpointSMSVoiceV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static RequestPhoneNumberResponseUnmarshaller _instance = new RequestPhoneNumberResponseUnmarshaller();        

        internal static RequestPhoneNumberResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestPhoneNumberResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}