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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityStore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityStore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeUser operation
    /// </summary>  
    public class DescribeUserResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeUserResponse response = new DescribeUserResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Addresses", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Address, AddressUnmarshaller>(AddressUnmarshaller.Instance);
                    response.Addresses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Emails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Email, EmailUnmarshaller>(EmailUnmarshaller.Instance);
                    response.Emails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExternalIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExternalId, ExternalIdUnmarshaller>(ExternalIdUnmarshaller.Instance);
                    response.ExternalIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IdentityStoreId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IdentityStoreId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Locale", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Locale = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = NameUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NickName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NickName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PhoneNumbers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhoneNumber, PhoneNumberUnmarshaller>(PhoneNumberUnmarshaller.Instance);
                    response.PhoneNumbers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredLanguage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PreferredLanguage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProfileUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProfileUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timezone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Timezone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.UserId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.UserName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.UserType = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
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
            return new AmazonIdentityStoreException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeUserResponseUnmarshaller _instance = new DescribeUserResponseUnmarshaller();        

        internal static DescribeUserResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeUserResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}